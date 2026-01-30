using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Dallas", "TX", "USA");
        Customer customer1 = new Customer("John Smith", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "P1001", 800, 1));
        order1.AddProduct(new Product("Mouse", "P1002", 25, 2));

        Address address2 = new Address("45 Queen St", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Sarah Lee", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Phone", "P2001", 600, 1));
        order2.AddProduct(new Product("Headphones", "P2002", 100, 1));
        order2.AddProduct(new Product("Charger", "P2003", 20, 2));

        DisplayOrder(order1);
        Console.WriteLine();
        DisplayOrder(order2);
    }

    static void DisplayOrder(Order order)
    {
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order.GetTotalCost()}");
    }
}
