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


        public QuestionStatistics StatsOf(IQuestion question)
        {
            var minimums = new Dictionary<IQuestion, double>();
            var maximums = new Dictionary<IQuestion, double>();
            var averages = new Dictionary<IQuestion, double>();
            foreach (PollResult result in results)
            { 

            }
            return null;
        }


    }
}
