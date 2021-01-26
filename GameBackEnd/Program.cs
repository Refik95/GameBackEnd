using System;

namespace GameBackEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            IEntity customer1 = new Customer() { NationalityNumber = 12345, Name = "Refik", SurName = "Günhan", YearOfBirth = 1995 };
            IEntity customer2 = new Customer() { NationalityNumber = 13579, Name = "Jason", SurName = "Tatum", YearOfBirth = 1998 };

            ICustomerDal customerManager = new CustomerManager(new EdevletValidationManager());
            customerManager.Add(customer1);
            customerManager.Add(customer2);

            IEntity game1 = new Game { Id = 1, Name = "CS:GO", Price = "24$" };
            IEntity game2 = new Game { Id = 2, Name = "Demon's Souls", Price = "80$" };

            ICustomerDal gameManager = new GameManager();
            gameManager.Add(game1);
            gameManager.Add(game2);

            ISteamSaleService saleSteam = new SteamManager();
            saleSteam.BuyGame(game1, customer1);
            saleSteam.BuyGame(game2, customer2);

            IDiscountService summerSale = new SummerSaleManager();
            summerSale.Discount(game1);

            IDiscountService winterSale = new WinterSaleManager();
            winterSale.Discount(game2);

            Console.ReadLine();
        }
    }
}
