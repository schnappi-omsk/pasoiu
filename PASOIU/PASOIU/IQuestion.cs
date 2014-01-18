using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    interface IQuestion
    {
        int Id
        {
            get;
            set;
        }

        string Text
        {
            get;
            set;
        }

    }
}
