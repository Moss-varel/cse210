namespace OnlineOrderingSystem.Models;
public class Product
{
    public string Name { get; }
    public string ProductID { get; }
    public double Price { get; }
    public int Quantity { get; }

    public Product(string name, string productID, double price, int quantity)
    {
        Name = name;
        ProductID = productID;
        Price = price;
        Quantity = quantity;
    }

    public double GetTotalCost() => Price * Quantity;
}
