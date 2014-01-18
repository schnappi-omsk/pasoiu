using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class PollResult
    {

        private Dictionary<IQuestion, string> answers = new Dictionary<IQuestion, string>();

        private Dictionary<IQuestion, Alternative> choices = new Dictionary<IQuestion, Alternative>();

        private Poll poll;

        private int id;

        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }

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
            foreach (IQuestion question in answers.Keys) 
            {
                if (!poll.HasAlternatives(question)) answers.Add(question, null);
            }
        }

        public void SelectAlternative(IQuestion question, Alternative alternative) {
            if (poll.HasAlternative(question, alternative) && !choices.ContainsKey(question))
            {
                choices.Add(question, alternative);
            }
        }

        public void AnswerTo(IQuestion question, string answer)
        {
            if (answers.ContainsKey(question))
            {
                answers[question] = answer;
            }
            else
            {
                answers.Add(question, answer);
            }
        }

        public Dictionary<IQuestion, string> GetAnswers() 
        {
            return answers;
        }

        public Dictionary<IQuestion, Alternative> GetChoices() 
        {
            return choices;
        }

        public IReadOnlyList<Alternative> ChoicesByQuestion(IQuestion question)
        {
            List<Alternative> result = new List<Alternative>();
            if (choices.ContainsKey(question))
            {
                result.Add(choices[question]);
            }
            return result.AsReadOnly();
        }

    }
}
