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
