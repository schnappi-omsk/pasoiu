using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class Question : IQuestion
    {

        private string text;

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
            return this.text == ((Question)obj).text;            
        }
        

    }
}
