namespace OnlineOrderingSystem.Models;
public class Order
{
    private List<Product> Products;
    private Customer Customer;

    public Order(Customer customer)
    {
        Customer = customer;
        Products = new List<Product>();
    }

    public void AddProduct(Product product) => Products.Add(product);
    public double CalculateTotal()
    {
        double total = 0;
        foreach (var product in Products)
        {
            total += product.GetTotalCost();
        }
        total += Customer.IsInUSA() ? 5 : 35;
        return total;
    }

    public string GetPackingLabel()
    {
        string label = "";
        foreach (var product in Products)
        {
            label += $"{product.Name} (ID: {product.ProductID}) - ${product.Price} x {product.Quantity}\n";
        }
        return label;
    }

    public string GetShippingLabel() => $"{Customer.Name}\n{Customer.Address}";
}
