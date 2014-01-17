using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class Poll : IPoll
    {
        const string WHITESPACE = "____________";

        const string SELECT_ALTERNATIVE = "Select one of alternatives: ";
        
        private string name;

        public string Name
        {
            get
            {
                return name;
            }            
        }

        private List<IQuestion> questions = new List<IQuestion>();

        private Dictionary<IQuestion, List<Alternative>> alternatives = new Dictionary<IQuestion, List<Alternative>>();

        public Poll(string name) 
        {
            this.name = name;
        }

        public void AddQuestion(IQuestion question) 
        {
            questions.Add(question);
        }

        public void AddAlternative(IQuestion question, Alternative alternative) 
        {
            if (!alternatives.ContainsKey(question)) 
            {
                alternatives.Add(question, new List<Alternative>());                   
            }
            alternatives[question].Add(alternative); 
        }

        public void AddAllAlternatives(IQuestion question, params Alternative[] allAlternatives) 
        {
            foreach (Alternative variant in allAlternatives) 
            {
                AddAlternative(question, variant);
            }
        }

        public bool HasAlternatives(IQuestion question) 
        {
            return alternatives.ContainsKey(question);
        }

        public bool HasAlternative(IQuestion question, Alternative alternative)
        {
            return alternatives.ContainsKey(question) &&
                alternatives[question].Contains(alternative);
        }

        public IReadOnlyList<Alternative> GetAlternatives(IQuestion question)
        {
            if (alternatives.ContainsKey(question))
            {
                return alternatives[question].AsReadOnly();
            }
            return null;
        }

        public IReadOnlyList<IQuestion> GetQuestions() 
        {
            return questions.AsReadOnly();
        }

        public string QuestionString(IQuestion question) 
        {
            StringBuilder sb = new StringBuilder(question.Text);
            sb.AppendLine();
            if (alternatives.ContainsKey(question))
            {
                sb.AppendLine(SELECT_ALTERNATIVE);
                foreach (Alternative variant in alternatives[question])
                {
                    sb.AppendLine(String.Format("{0}. {1}", variant.Id, variant.Text));
                }
            } 
            else
            {
                sb.AppendLine(WHITESPACE);
            }
            return sb.ToString();
        }

        public override string ToString() 
        {
            StringBuilder sb = new StringBuilder(name);
            sb.AppendLine();
            foreach (IQuestion question in questions) 
            { 
                sb.AppendLine(QuestionString(question));
            }
            return sb.ToString();
        }

    }
}
