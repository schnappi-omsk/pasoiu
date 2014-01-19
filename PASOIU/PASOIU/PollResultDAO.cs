using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using System.Data.SqlServerCe;
using System.Data;

namespace DS
{
    class PollResultDAO
    {

        DBConnector connector = new DBConnector();

        private PollDAO pollDao = new PollDAO();

        public void Create(PollResult result)
        {
            connector.Open();
            var command = new SqlCeCommand();
            command.Connection = connector.Connection;
            var pollId = pollDao.GetPollId(result.Poll);
            var insertResult = String.Format("INSERT INTO Poll_Result (poll_id) VALUES ({0})", pollId);
            command.CommandText = insertResult;
            command.ExecuteNonQuery();
            command.CommandText = "SELECT @@IDENTITY";
            var resultId = command.ExecuteScalar();
            var answers = result.GetAnswers();
            var choices = result.GetChoices();
            foreach (var question in answers.Keys)
            {
                var insertAnswer = String.Format("INSERT INTO Answer_Result (result_id, alternative_id, question_id, answer) " +
                "VALUES ({0}, NULL, {1} , '{2}')", resultId, question.Id, answers[question]
                );
                command.CommandText = insertAnswer;
                command.ExecuteNonQuery();
                
            }
            foreach (var question in choices.Keys)
            {
                var alternative = choices[question];
                var insertAlternative = String.Format("INSERT INTO Answer_Result (result_id, alternative_id, question_id, answer) " +
                    "VALUES ({0}, {1}, {2}, NULL)", resultId, alternative.Bid, question.Id
                    );
                command.CommandText = insertAlternative;
                command.ExecuteNonQuery();
            }
            connector.Close();
        }

        public PollResult Read(int id)
        {
            return null;
        }

        public List<PollResult> AllByPoll(Poll poll)
        {
            connector.Open();
            var command = new SqlCeCommand();
            command.Connection = connector.Connection;
            var id = pollDao.GetPollId(poll);
            var results = new List<PollResult>();
            var getResults = String.Format("SELECT id FROM Poll_Result WHERE poll_id = {0}", id);
            command.CommandText = getResults;
            var resultSet = command.ExecuteResultSet(ResultSetOptions.None);
            while (resultSet.Read())
            {
                var pollResult = new PollResult(poll);
                var pollQuestions = poll.GetQuestions();
                foreach (var question in pollQuestions)
                {
                    var getAnswers = String.Format("SELECT result_id, answer " + 
                        "FROM Answer_Result " + 
                        "WHERE question_id = {0} AND alternative_id IS NULL AND result_id = {1}",
                        question.Id, resultSet.GetInt32(0)
                        );
                    command.CommandText = getAnswers;
                    var answerSet = command.ExecuteResultSet(ResultSetOptions.None);
                    while (answerSet.Read())
                    {
                        var answerString = answerSet.GetString(1);
                        pollResult.AnswerTo(question, answerString);
                    }
                    var getChoices = String.Format("SELECT result_id, alternative_id " +
                        "FROM Answer_Result " +
                        "WHERE question_id = {0} AND answer IS NULL AND result_id = {1}",
                        question.Id, resultSet.GetInt32(0)
                        );
                    command.CommandText = getChoices;
                    var alternativeSet = command.ExecuteResultSet(ResultSetOptions.None);
                    while (alternativeSet.Read())
                    {
                        var alternativeId = alternativeSet.GetInt32(1);
                        var getAlt = String.Format("SELECT number, text " + 
                            "FROM Alternative " + 
                            "WHERE id = {0}",
                            alternativeId
                            );
                        command.CommandText = getAlt;
                        var choiceSet = command.ExecuteResultSet(ResultSetOptions.None);
                        var choice = new Alternative();
                        while (choiceSet.Read())
                        {
                            choice.Id = choiceSet.GetInt32(0);
                            choice.Text = choiceSet.GetString(1);
                            choice.Question = question;
                        }
                        pollResult.SelectAlternative(question, choice);
                    }                                        
                }
                results.Add(pollResult);
            }
            connector.Close();
            return results;
        }


        public void Delete()
        { 
        }

    }
}
