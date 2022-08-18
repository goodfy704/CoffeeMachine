using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    public class CoffeeMachineClass
    {
        const decimal countInsertedCoins = 3.0m; //Change value 3.0m => 1.0m to run TestMethod InsertedCoinsAreNotEnough()
        const decimal costOfCoffee = 1.20m;
        public decimal coins(decimal coin1, decimal coin2, decimal coin3, decimal coin4)
        {
            decimal sum = coin1 + coin2 + coin3 + coin4;
            return sum;
        }

        public decimal checkIfInsertedCoinsAreEnough(decimal addMoreCoins)
        {

            if (countInsertedCoins < costOfCoffee)
            {
                //Change countInsertedCoins value 3.0m => 1.0m to trigger if statement
                addMoreCoins = costOfCoffee - countInsertedCoins;
                Console.WriteLine("You must add this much coins: {0}" + addMoreCoins);
                return addMoreCoins;
                throw new ArgumentException();
            }
            else
                Console.WriteLine("Thanks! Please, select the drink.");
                return ReturnChange(addMoreCoins);
        }

        public decimal ReturnChange(decimal exchange)
        {

            exchange = countInsertedCoins - costOfCoffee;
            if (countInsertedCoins > costOfCoffee)
                Console.WriteLine("Your change is {0:C}", exchange);
                return exchange;
            

            List<Coffee> Coffees = new List<Coffee>()
        {
            new Coffee() { coffeeID = 1, coffeeName = "Americano", PriceOfCoffee = 1.20m},
            new Coffee() { coffeeID = 2, coffeeName = "Cappuccino", PriceOfCoffee = 1.20m},
            new Coffee() { coffeeID = 3, coffeeName = "Black", PriceOfCoffee = 1.20m},
            new Coffee() { coffeeID = 4, coffeeName = "Espresso", PriceOfCoffee = 1.20m},
            new Coffee() { coffeeID = 5, coffeeName = "Latte", PriceOfCoffee = 1.20m},
            new Coffee() { coffeeID = 6, coffeeName = "Robusta", PriceOfCoffee = 1.20m}
        };

        }
    }
}
