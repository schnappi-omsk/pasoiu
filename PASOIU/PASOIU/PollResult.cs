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

        public PollResult(Poll poll)
        {
            this.poll = poll;            
        }        

    }
}
