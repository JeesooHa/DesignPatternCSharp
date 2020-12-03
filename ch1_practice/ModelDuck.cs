using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch1_strategy
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            quackBehavior = new Quack();
            flyBehavior = new FlyNoWay();
        }

        public override void display()
        {
            Console.WriteLine("저는 모형 오리입니다");
        }
    }
}
