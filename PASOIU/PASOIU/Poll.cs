using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class Poll
    {
        
        private string name;

        public string Name
        {
            get
            {
                return name;
            }            
        }

        private List<Question> questions = new List<Question>();

        public Poll(string name) {
            this.name = name;
        }

        public void AddQuestion(Question question) 
        {
            questions.Add(question);
        }

        public IReadOnlyList<Question> GetQuestions() 
        {
            return questions.AsReadOnly();
        }

    }
}
