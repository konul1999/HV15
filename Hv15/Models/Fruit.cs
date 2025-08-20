using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hv15.Models
{
    internal abstract class Fruit
    {
        public decimal Price { get; set; }
        public string Sort { get; set; }

        public virtual void Taste()
        {
            Console.WriteLine("Fruits are tasty!");
        }
    }
}

