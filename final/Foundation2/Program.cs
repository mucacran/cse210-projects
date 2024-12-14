using System;

class Program
{
    static void Main(string[] args)
    {
        // Crear direcciones, clientes y productos
        Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Customer customer1 = new Customer("John Doe", address1);
        Product product1 = new Product("T-shirt", "C001", 10m, 2);
        Product product2 = new Product("Cap", "C002", 5m, 3);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total Cost: $" + order1.GetTotalCost());
        Console.WriteLine();

        Address address2 = new Address("456 Avenida del Mar", "Guayas", "Guayaquil", "Ecuador");
        Customer customer2 = new Customer("María López", address2);
        Product product3 = new Product("Shoes", "Z001", 20m, 1);
        Product product4 = new Product("Bag", "B001", 15m, 2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total Cost: $" + order2.GetTotalCost());

        Console.WriteLine("Press ENTER to exit...");
        Console.ReadLine();
    }
}
