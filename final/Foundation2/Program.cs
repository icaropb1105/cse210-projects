using System;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product { Name = "Laptop", ProductId = "123", Price = 999.99m, Quantity = 1 };
        Product product2 = new Product { Name = "Mouse", ProductId = "456", Price = 29.99m, Quantity = 2 };

        Address address1 = new Address("123 Main St", "Los Angeles", "California", "USA");
        Customer customer1 = new Customer { Name = "John Doe", Address = address1 };

        // Create order
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        // Display order 1
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.CalculateTotalCost()}");

        Console.WriteLine();

        // Create another order
        Product product3 = new Product { Name = "Headphones", ProductId = "789", Price = 49.99m, Quantity = 1 };
        Address address2 = new Address("456 Oak St", "Toronto", "Ontario", "Canada");
        Customer customer2 = new Customer { Name = "Jane Smith", Address = address2 };
        Order order2 = new Order(customer2);
        order2.AddProduct(product1);
        order2.AddProduct(product3);

        // Display order 2
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.CalculateTotalCost()}");
    }
}