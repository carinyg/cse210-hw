public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public float CalculateCost()
    {
        float total = 0;
        foreach (Product product in _products)
        {
            total += product.ProductCost();
        }
        return total;
    }

    public float ShippingCost()
    {
        if (_customer.GetAddress().IsInUSA())
        {
            return 5.00f;
        }
        else
        {
            return 35.00f;
        }
    }

    public void ProductReceipt()
    {
        foreach (Product product in _products)
        {
            Console.WriteLine(product.DisplayProduct());
        }
    
    }

    public void GeneratePackingSlip()
    {
        Console.WriteLine("Packing Slip:");
        Console.WriteLine();
        Console.WriteLine($"Products for {_customer.GetName()}:");
        ProductReceipt();
        Console.WriteLine($"Subtotal: ${CalculateCost()}");
        Console.WriteLine($"Shipping: ${ShippingCost()}");
        Console.WriteLine($"Total: ${CalculateCost() + ShippingCost()}");
    }

    public void GenerateShippingLabel ()
    {
        Console.WriteLine("Ship to:");
        Console.WriteLine();
        Console.WriteLine(_customer.GetName());
        Console.WriteLine(_customer.GetAddress().DisplayAddress());
    }
}
        
