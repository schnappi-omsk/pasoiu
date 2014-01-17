﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using System.Data.SqlServerCe;
using System.Data;

namespace DS
{
    class PollDAO
    {

        private DBConnector connector = new DBConnector();

        public void Create(Poll poll) 
        {
            connector.Open();
            var command = new SqlCeCommand();
            command.Connection = connector.Connection;
            var insertPoll = String.Format("INSERT INTO Poll (name) VALUES ('{0}')", poll.Name);
            command.CommandText = insertPoll;
            command.ExecuteNonQuery();
            command.CommandText = "SELECT @@IDENTITY";
            var lastId = command.ExecuteScalar();
            var questions = poll.GetQuestions();
            foreach (var question in questions)
            {                
                var insertQuestion = String.Format("INSERT INTO Question (text, poll_id) VALUES ('{0}', {1})", question.Text, lastId);                
                command.CommandText = insertQuestion;
                command.ExecuteNonQuery();
                command.CommandText = "SELECT @@IDENTITY";
                var lastQuestion = command.ExecuteScalar();
                if (poll.HasAlternatives(question))
                {
                    var alternatives = poll.GetAlternatives(question);
                    foreach (var variant in alternatives)
                    {
                        var insertAlt = String.Format(
                            "INSERT INTO Alternative (question_id, number, text) VALUES ({0}, {1}, '{2}')",
                            lastQuestion, variant.Id, variant.Text
                            );
                        command.CommandText = insertAlt;
                        command.ExecuteNonQuery();
                    }
                }
            }                
            connector.Close();
        }

        public Poll Read(string name)
        {
            connector.Open();
            var selectPoll = String.Format("SELECT id, name FROM Poll WHERE name = '{0}'", name);
            var command = new SqlCeCommand();            
            command.Connection = connector.Connection;
            command.CommandText = selectPoll;
            var resultSet = command.ExecuteResultSet(ResultSetOptions.None);
            var pollName = "";
            var pollId = 0;
            while (resultSet.Read()) {
                pollId = resultSet.GetInt32(0);
                pollName = resultSet.GetString(1);
            }
            Poll result = new Poll(pollName);
            var selectQuestions = String.Format("SELECT id, text FROM Question WHERE poll_id = {0}", pollId);
            command.CommandText = selectQuestions;
            var questionsSet = command.ExecuteResultSet(ResultSetOptions.None);
            while (questionsSet.Read())
            {
                var question = new Question();                
                question.Text = questionsSet.GetString(1);
                var questionId = questionsSet.GetInt32(0);
                result.AddQuestion(question);
                var selectAlternatives = String.Format("SELECT number, text FROM Alternative WHERE question_id = {0}", questionId);
                command.CommandText = selectAlternatives;
                var alternativesScalar = command.ExecuteScalar();
                if (alternativesScalar != null)
                {
                    var alternativesSet = command.ExecuteResultSet(ResultSetOptions.None);
                    while (alternativesSet.Read())
                    {
                        var number = alternativesSet.GetInt32(0);
                        var text = alternativesSet.GetString(1);
                        var alternative = new Alternative(question, number, text);
                        result.AddAlternative(question, alternative);
                    }
                }                                
            }
            connector.Close();
            return result;
        }

        public void Update(Poll poll)
        { 
        }

        public void Delete(Poll poll)
        { 
        }


    }
}
