using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class Answer
    {

        private IQuestion question;

        private string answer;

        public string AnswerValue
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

        public Answer(IQuestion question) {
            this.question = question;
        }

    }
}
