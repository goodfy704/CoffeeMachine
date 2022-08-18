using CoffeeMachine;
namespace TestMethod
{
    [TestClass]
    public class TestCases
    {
        [TestMethod]
        public void payForDrink()
        {
            decimal expectedResult = 3.0m;
            decimal coin1 = 0.00m;
            decimal coin2 = 1.00m;
            decimal coin3 = 1.00m;
            decimal coin4 = 1.00m;
            decimal sum = coin2 + coin3 + coin4;
            CoffeeMachineClass result = new CoffeeMachineClass();
            Assert.AreEqual(expectedResult, result.coins(coin1, coin2, coin3, coin4));
        }
        [TestMethod]

        public void getMoneyBack()
        {
            decimal expectedResult = 1.80m;
            decimal coin1 = 0.10m;
            decimal coin2 = 0.20m;
            decimal coin3 = 0.50m;
            decimal coin4 = 1.00m;
            decimal sum = coin1 + coin2 + coin3 + coin4;
            CoffeeMachineClass result = new CoffeeMachineClass();
            Assert.AreEqual(expectedResult, result.ReturnChange(sum));
        }
        [TestMethod]
        public void InsertedCoinsAreEnough()
        {
            decimal expectedResult = 1.80m;
            decimal coin1 = 0.10m;
            decimal coin2 = 0.20m;
            decimal coin3 = 0.50m;
            decimal coin4 = 1.00m;
            decimal coinSum = coin1 + coin2 + coin3 + coin4;
            CoffeeMachineClass result = new CoffeeMachineClass();
            Assert.AreEqual(expectedResult, result.checkIfInsertedCoinsAreEnough(coinSum));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void addDrinks()
        {
            
            List<Coffee> expectedResult = new List<Coffee>();
            new Coffee { coffeeID = 1, coffeeName = "Americano", PriceOfCoffee = 1.20m };

            CollectionAssert.AreEqual(expectedResult, Coffee.buyCoffee());
        }

        [TestMethod]
        [Ignore] //Comment this lane and in CoffeMachine change const decimal countInsertedCoins value 3.0m to 1.0m
        public void InsertedCoinsAreNotEnough()
        {
            decimal expectedResult = 0.20m;
            decimal coin1 = 0.50m;
            decimal coin2 = 0.20m;
            decimal coin3 = 0.20m;
            decimal coin4 = 0.10m;
            decimal coinSum = coin1 + coin2 + coin3 + coin4;
            CoffeeMachineClass result = new CoffeeMachineClass();
            Assert.AreEqual(expectedResult, result.checkIfInsertedCoinsAreEnough(coinSum));
        }
    }
}