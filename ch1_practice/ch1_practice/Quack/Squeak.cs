﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch1_practice
{
    class Squeak : QuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("삑");
        }
    }
}
