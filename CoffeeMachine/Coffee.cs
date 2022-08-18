using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    public class Coffee
    {
        public int coffeeID { get; set; }
        public string coffeeName { get; set; }
        public decimal PriceOfCoffee { get; set; }

        public static ICollection buyCoffee()
        {
            throw new ArgumentException();
        }
    }
}
