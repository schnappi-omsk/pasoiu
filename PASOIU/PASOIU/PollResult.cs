using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class PollResult
    {

        private Dictionary<Question, string> answers = new Dictionary<Question, string>();

        private Poll poll;

        public Poll Poll
        {
            get
            {
                return this.poll;
            }            
        }

        public PollResult(Poll poll)
        {
            this.poll = poll;
            foreach (Question question in answers.Keys) 
            {
                answers.Add(question, null);
            }
        }

        public void AnswerTo(Question question, string answer)
        {
            if (answers.ContainsKey(question)) 
            {
                answers[question] = answer;
            }
        }

    }
}
