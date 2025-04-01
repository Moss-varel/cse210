using System;
using System.Collections.Generic;
using OnlineOrderingSystem.Models;

class Program
{
    static void Main()
    {
        Address address1 = new Address("123 Bitelika Av", "Pointe Noire", "PN", "CONGO");
        Customer customer1 = new Customer("Moss Jeansty", address1);
        
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "L123", 1200, 1));
        order1.AddProduct(new Product("Mouse", "M456", 25, 2));

        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        
        Console.WriteLine("\nShipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        
        Console.WriteLine("\nTotal Cost: $" + order1.CalculateTotal());
    }
}
