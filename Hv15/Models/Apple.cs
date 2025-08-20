using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hv15.Models
{
    internal class Apple : Fruit
    {
        public int VitaminA { get; set; }
        public int VitaminB { get; set; }

        public override void Taste()
        {
            Console.WriteLine("Apple tastes sweet");
        }
    }
}
