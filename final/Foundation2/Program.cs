// Products
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Foundation2 World!");

        // Order 1
        Address address1 = new Address("2052 Sunny Day Drive", "Huntington Beach", "CA", "USA");
        Customer customer1 = new Customer("Hunter Underwood", address1);
        List<Product> productsList1 = new List<Product>();

        Product p1001 = new Product("Count Tree Food", "CTF1", 11.48 , 2);
        Product p1002 = new Product("Tree Wrap", "TW04", 4.98, 5);
        Product p1003 = new Product("Tree Diaper", "TD30", 36.00, 1);

        Order order1 = new Order(productsList1, customer1);

        Console.WriteLine("Order Number: 1");
        order1.DisplayResults();
        Console.WriteLine();

        //Order 2
        Address address2 = new Address("3299 Snider Street", "Englewood", "CO", "USA");
        Customer customer2 = new Customer("Manuel Love", address2);
        List<Product> productsList2 = new List<Product>();

        Product p2001 = new Product("Tree Food", "TF08", 8.56, 2);
        Product p2002 = new Product("Gardening Gloves", "GG06", 6.98, 1);
        Product p2003 = new Product("Mulch", "M003", 3.98, 2 );

        Order order2 = new Order(productsList2, customer2);

        Console.WriteLine("Order Number: 2");
        order1.DisplayResults();
        Console.WriteLine();

        // Order 3
        Address address3 = new Address("3910 Richison Drive", "Melstone", "MT", "USA");
        Customer customer3 = new Customer ("Louie Mills", address3);
        List<Product> productsList3 = new List<Product>();

        Product p3001 = new Product("Mulch", "M003", 6.98, 3);
        Product p3002 = new Product("Tree Food", "TF34", 34.99, 1);
        Product p3003 = new Product("Stainless Steel Lopper/Pruner Set", "SSSET", 44.99, 1);
        
        Order order3 = new Order(productsList3, customer3);

        Console.WriteLine("Order Number: 3");
        order1.DisplayResults();
        Console.WriteLine();

    }
}
