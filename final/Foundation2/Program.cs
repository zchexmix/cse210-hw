using System;

class Program
{
    static void Main(string[] args)
    {
        Address usaAddress = new Address("123 Main St", "New York", "NY", "USA");
        Address intlAddress = new Address("456 Rue Street", "Paris", "Île-de-France", "France");

        Customer customer1 = new Customer("John Doe", usaAddress);
        Customer customer2 = new Customer("Jane Smith", intlAddress);

        Product product1 = new Product("Laptop", "ABC123", 999.99m, 2);
        Product product2 = new Product("Headphones", "XYZ456", 149.99m, 3);

        Product[] order1Products = { product1, product2 };
        Product[] order2Products = { product1 };

        Order order1 = new Order(customer1, order1Products);
        Order order2 = new Order(customer2, order2Products);

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total Cost: $" + order1.GetTotalCost());

        Console.WriteLine();

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total Cost: $" + order2.GetTotalCost());
    }
}