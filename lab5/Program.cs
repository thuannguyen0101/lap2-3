
using System;
using Customer;
using Order;
namespace Customer
{
    class CustomerDetails
    {
        public string Name;
        public void GetName()
        {
            Console.WriteLine("Enter your name:");
            Name = Console.ReadLine();
        }
    }
}
namespace Order
{
    class GroceryItems
    {
        public void Ord_grocery()
        {
            Console.WriteLine("You have ordered grocery items");
        }
    }
    class BakeryItems
    {
        public void Ord_bakery()
        {
            Console.WriteLine("You have ordered bakery items");
        }
    }
}
class OrderTest
{
    public static void Main()
    {
        CustomerDetails customer = new CustomerDetails();
        customer.GetName();
        Console.WriteLine("What would you like to order? 1-Grocery Items, 2-Bakery Items");
        var choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Console.WriteLine("Hello {0}", customer.Name);
                GroceryItems objGrocery = new GroceryItems();
                objGrocery.Ord_grocery();
                break;
            case 2:
                Console.WriteLine("Hello {0}", customer.Name);
                BakeryItems objBakery = new BakeryItems();
                objBakery.Ord_bakery();
                break;
            default:
                Console.WriteLine("Enter either 1 or 2");
                break;
        }
        Console.ReadLine();
    }
}