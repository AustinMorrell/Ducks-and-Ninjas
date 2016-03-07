using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninjas_and_Ducks
{
    interface IStats
    {
        int health
        {
            get;
            set;
        }
        int attack
        {
            get;
            set;
        }
        string name
        {
            get;
            set;
        }
    }
}
