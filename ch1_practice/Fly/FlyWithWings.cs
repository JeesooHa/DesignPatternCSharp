using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch1_strategy
{
    class FlyWithWings : FlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("날고 있어요!");
        }
    }
}
