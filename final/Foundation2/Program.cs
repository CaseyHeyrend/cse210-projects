// Products
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Foundation2 World!");

        // Order 1
        Address address1 = new Address("", "", "", "");
        Customer customer1 = new Customer("", address1);
        List<Product> productsList1 = new List<Product>();

        Product p1001 = new Product("", "", 50.00, 1);
        Product p1002 = new Product("", "", 50.00, 1);
        Product p1003 = new Product("", "", 50.00, 1);

        Order order1 = new Order(productsList1, customer1);

        Console.WriteLine("Order Number: 1");
        order1.DisplayResults();
        Console.WriteLine();

        //Order 2
        Address address2 = new Address("", "", "", "");
        Customer customer2 = new Customer("", address2);
        List<Product> productsList2 = new List<Product>();

        Product p2001 = new Product("", "", 50.00, 1);
        Product p2002 = new Product("", "", 50.00, 1);
        Product p2003 = new Product("", "", 50.00, 1);

        Order order2 = new Order(productsList2, customer2);

        Console.WriteLine("Order Number: 2");
        order1.DisplayResults();
        Console.WriteLine();

        // Order 3
        Address address3 = new Address("", "", "", "");
        Customer customer3 = new Customer ("", address3);
        List<Product> productsList3 = new List<Product>();

        Product p3001 = new Product("", "", 50.00, 1);
        Product p3002 = new Product("", "", 50.00, 1);
        Product p3003 = new Product("", "", 50.00, 1);

        Order order3 = new Order(productsList3, customer3);

        Console.WriteLine("Order Number: 3");
        order1.DisplayResults();
        Console.WriteLine();

    }
}