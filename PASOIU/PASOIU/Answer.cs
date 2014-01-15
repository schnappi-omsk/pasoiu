using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class Answer
    {

        private Question question;

        private string answer;

        public string Answer
        {
            get
            {
                if (this.answer == null) return "";
                return this.answer;
            }
            set
            {                
                this.answer = value;
            }
        }

        public Answer(Question question) {
            this.question = question;
        }

    }
}
