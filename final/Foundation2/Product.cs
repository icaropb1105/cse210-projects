
public class Product
{
    private string name;
    private string productId;
    private decimal price;
    private int quantity;

    public string Name { get => name; set => name = value; }
    public string ProductId { get => productId; set => productId = value; }
    public decimal Price { get => price; set => price = value; }
    public int Quantity { get => quantity; set => quantity = value; }

    public decimal GetTotalCost()
    {
        return Price * Quantity;
    }
}