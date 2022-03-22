using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Name: Manlin Mao
//Purpose:manage coffee shops
namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            int coffeeCups, teaCups;

            CoffeeShop.teaPrice = 1.50;
            CoffeeShop.coffeePrice = 2.50;

            CoffeeShop shopOne = new CoffeeShop("Moon Pie");
            CoffeeShop shopTwo = new CoffeeShop("Break");

            Console.Write( "Please enter total coffee sold for " + shopOne.GetName()+": ");
            coffeeCups = Int32.Parse(Console.ReadLine());
            shopOne.SetCoffee(coffeeCups);
            Console.Write("Pleas enter total tea sold for " + shopOne.GetName()+": ");
            teaCups = Int32.Parse(Console.ReadLine());
            shopOne.SetTea(teaCups);

            Console.Write("Please enter total coffee sold for " + shopTwo.GetName() + ": ");
            coffeeCups = Int32.Parse(Console.ReadLine());
            shopTwo.SetCoffee(coffeeCups);
            Console.Write("Pleas enter total tea sold for " + shopTwo.GetName() + ": ");
            teaCups = Int32.Parse(Console.ReadLine());
            shopTwo.SetTea(teaCups);

            Console.WriteLine(shopOne.GetName()+ "'s total sale is: "+shopOne.GetTotalSales()+"$");
            Console.WriteLine(shopTwo.GetName() + "'s total sale is: " + shopTwo.GetTotalSales() + "$");

            if (shopOne.GetTotalSales() > shopTwo.GetTotalSales())
                DisplayBestShop(shopOne.GetName());
            else
                DisplayBestShop(shopTwo.GetName());

            Console.Write("Press enter to continue");
            Console.ReadLine();
        }
        static void DisplayBestShop(string passedShopName)
        {
            Console.WriteLine(passedShopName + " is the winner");
        }
    }
}

/*
 Please enter total coffee sold for Moon Pie: 22
Pleas enter total tea sold for Moon Pie: 31
Please enter total coffee sold for Break: 23
Pleas enter total tea sold for Break: 40
Moon Pie's total sale is: 101.5$
Break's total sale is: 117.5$
Break is the winner
Press enter to continue
Press any key to continue . . .
 
 */
