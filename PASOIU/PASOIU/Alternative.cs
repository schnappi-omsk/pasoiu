using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class Alternative
    {

        private IQuestion question;

        private int id;

        private string text;

        public Alternative(IQuestion question, int id, string text) 
        {
            this.question = question;
            this.id = id;
            this.text = text;
        }

        public IQuestion Question 
        {
            get
            {
                return this.question;
            }
            private set { }
        }

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

        public string Text
        {
            get
            {
                return this.text;
            }
            set
            {
                this.text = value;
            }
        }

    }
}
