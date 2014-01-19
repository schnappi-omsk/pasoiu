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

        private int bid;

        private int id;

        private string text;

        public Alternative()
        { }

        public Alternative(int id, string text)
        {
            this.id = id;
            this.text = text;
        }

        public Alternative(IQuestion question, int id, string text) 
        {
            this.question = question;
            this.id = id;
            this.text = text;
        }

        public int Bid
        {
            get
            {
                return this.bid;
            }
            set
            {
                this.bid = value;
            }
        }

        public IQuestion Question 
        {
            get
            {
                return this.question;
            }
            set 
            {
                this.question = value;
            }
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

        public override bool Equals(object obj)
        {
            return text == ((Alternative) obj).text;
        }

        public override int GetHashCode()
        {
            return text.GetHashCode();
        }

    }
}
