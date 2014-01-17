using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Report;

namespace Domain
{
    class PollManager
    {
        private List<PollResult> results = new List<PollResult>();

        public void AddResult(PollResult result)
        {
            results.Add(result);        
        }

        public void AddAllResults(params PollResult[] results) {
            this.results.AddRange(results);
        }

        public void RemoveResult(PollResult result)
        {
            results.Remove(result);
        }

        public IReadOnlyList<PollResult> GetResults()
        {
            return results.AsReadOnly();
        }

        /**
         * Расчет и формирование одномерных таблиц вида:
         * 
         * |    Альтернатива    | Частота (число ответов) | Доля от числа опрошенных |
         *         
         */ 
        public AlternativesFrequency AlternativesByQuestion(IQuestion question)
        {
            Dictionary<Alternative, int> frequencies = new Dictionary<Alternative, int>();
            Dictionary<Alternative, double> percentage = new Dictionary<Alternative, double>();                        
            var reportTable = new AlternativesFrequency();            
            int totalAnswered = 0;            
            foreach (PollResult result in results) 
            {
                totalAnswered += 1;
                var choices = result.ChoicesByQuestion(question);
                foreach (Alternative choice in choices) 
                {
                    if (!frequencies.ContainsKey(choice)) frequencies.Add(choice, 1);
                    else frequencies[choice] += 1;
                }                
            }
            foreach (PollResult result in results) 
            {
                Poll poll = result.Poll;
                var allAlternatives = poll.GetAlternatives(question);
                foreach (Alternative variant in allAlternatives)
                {
                    if (!frequencies.ContainsKey(variant)) frequencies.Add(variant, 0);
                }
            }            
            foreach (Alternative alternative in frequencies.Keys) 
            {
                if (!percentage.ContainsKey(alternative)) percentage.Add(alternative, 0.0);
                percentage[alternative] = (double) frequencies[alternative] / (double) totalAnswered * 100.0;
                reportTable.AddRecord(String.Format("{0}.{1}", alternative.Id, alternative.Text), frequencies[alternative], percentage[alternative]);                
            }            
            return reportTable;
        }


        /**
         *  Расчет таблиц вида для открытых вопросов числового типа 
         *  
         *  | Текст вопроса | Минимум | Среднее | Максимум |
         * 
         */
        public QuestionStatistics StatsOf(IQuestion question)
        {            
            double minimum;
            double maximum;
            double average;
            double sum = 0.0;            
            List<double> answersList = new List<double>();
            QuestionStatistics resultSet = new QuestionStatistics();
            foreach (PollResult result in results)
            {
                double val;
                var answers = result.GetAnswers();                
                if (answers.ContainsKey(question))
                {
                    var answer = answers[question];                    
                    if (Double.TryParse(answer, out val))
                    {                        
                        answersList.Add(val);
                    }                    
                }
            }
            minimum = answersList.Min();
            maximum = answersList.Max();
            average = answersList.Average();
            resultSet.AddRecord(question.Text, minimum, average, maximum);
            return resultSet;
        }


    }
}
