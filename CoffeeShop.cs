using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Name: Manlin Mao
//Purpose:manage coffee shops
namespace assignment1
{
    class CoffeeShop
    {
        
        private string shopName;
        private int coffeeSold, teaSold;
        public static double coffeePrice, teaPrice;

        //Constructor
        public CoffeeShop(string initialShopName)
        {
            coffeeSold = 0;
            teaSold = 0;
            shopName = initialShopName;
        }

        public string GetName()
        {
            return shopName;
        }

        public void SetCoffee(int passedCups)
        {
            
            while (passedCups < 0|| passedCups >500 )
            {
                Console.Write("Invalid number of cups, please enter 0 to 500: ");
                passedCups = Int32.Parse(Console.ReadLine());
            }
            coffeeSold = passedCups;
        }

        public void SetTea(int passedCups)
        {
            while (passedCups < 0 || passedCups > 500)
            {
                Console.Write("Invalid number of cups, please enter 0 to 500: ");
                passedCups = Int32.Parse(Console.ReadLine());
            }

            teaSold = passedCups;
           
        }

        public double GetTotalSales()
        {
        
            return coffeeSold * coffeePrice + teaSold * teaPrice;

        }
    }
}
