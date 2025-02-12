using System;
using System.Collections.Specialized;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Address a1 = new Address("1606 Havasu Ct", "Henderson", "NV", "89014");
        Customer c1 = new Customer("Carin Gardner", a1);
        Order o1 = new Order(c1);
        Product o1p1 = new Product("Mixed Wheat Loaf", "MW", 6.50f, 2);
        Product o1p2 = new Product("Sourdough Sandwich Loaf", "SS", 6.50f);
        Product o1p3 = new Product("Cinnamon Roll", "CR", 2.00f, 6);
        o1.AddProduct(o1p1);
        o1.AddProduct(o1p2);
        o1.AddProduct(o1p3);
        o1.GeneratePackingSlip();
        Console.WriteLine();
        o1.GenerateShippingLabel();
        Console.WriteLine();

        Address a2 = new Address("Castellón 1063 Oficina Norte", "Casilla 2210", "Concepción", "Bio-Bio", "Chile");
        Customer c2 = new Customer("Élder Benjamin Gardner", a2);
        Order o2 = new Order(c2);
        Product o2p1 = new Product("White Bread", "WB", 6.00f);
        Product o2p2 = new Product("Sourdough Baguette", "SB", 6.00f, 3);
        Product o2p3 = new Product("Whole Wheat Loaf", "WW", 7.00f, 2);
        o2.AddProduct(o2p1);
        o2.AddProduct(o2p2);
        o2.AddProduct(o2p3);
        o2.GeneratePackingSlip();
        Console.WriteLine();
        o2.GenerateShippingLabel();
        Console.WriteLine();

        Address a3 = new Address("18550 County RD 1560", "Ada", "OK", "74820");
        Customer c3 = new Customer("Jamie Marshall", a3);
        Order o3 = new Order(c3);
        Product o3p1 = new Product("Sourdough Baguette", "SB", 6.00f, 3);
        Product o3p2 = new Product("Cinnamon Roll", "CR", 2.00f, 12);
        o3.AddProduct(o3p1);
        o3.AddProduct(o3p2);
        o3.GeneratePackingSlip();
        Console.WriteLine();
        o3.GenerateShippingLabel();
        Console.WriteLine();

    }
}