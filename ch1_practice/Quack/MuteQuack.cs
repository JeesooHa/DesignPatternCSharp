using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch1_strategy
{
    class MuteQuack : QuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("<< 조용~ >>");
        }
    }
}
