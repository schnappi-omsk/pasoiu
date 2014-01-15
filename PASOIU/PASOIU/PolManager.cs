using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class PolManager
    {

        public Poll getPoll(string name)
        {
            return null;
        }

        public Poll createPoll(string name) 
        {
            return new Poll(name);
        }

        public void removePoll(string name) 
        { 
            
        }

    }
}
