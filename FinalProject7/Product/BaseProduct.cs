namespace FinalProject7.Product;

public abstract class BaseProduct(
    string name,
    string article,
    string description,
    double price,
    int quantity,
    string brand)
{
    public int Id { get; set; }
    private readonly string _name = name;
    public string Name => IsUsed ?  $"{_name}(б/у)" : _name;

    public string Article { get; } = article;
    public string Description { get; } = description;
    public double Price { get; } = price;
    public int Quantity { get; } = quantity;
    public string Brand { get; set; } = brand;
    public double SumPrice => Price * Quantity;
    public bool IsUsed { get; set; } = false;
}