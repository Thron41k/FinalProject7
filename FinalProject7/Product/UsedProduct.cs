using FinalProject7.Product.Categories;

namespace FinalProject7.Product;

public class Product<TCategory, TUsed> : Product<TCategory> where TCategory : BaseCategory
{
    public Product(string name, string article, TCategory category, string description, double price, int quantity, string brand, TUsed used) : base(name, article, category, description, price, quantity, brand)
    {
        UsedInfo = used;
        IsUsed = true;
    }

    public TUsed UsedInfo { get; }
}