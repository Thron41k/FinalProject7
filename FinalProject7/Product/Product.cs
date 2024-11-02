using FinalProject7.Product.Categories;

namespace FinalProject7.Product;

public class Product<TCategory>(string name, string article, TCategory category, string description, double price, int quantity, string brand) : BaseProduct(name, article, description, price, quantity, brand) where TCategory : BaseCategory
{
    public TCategory Category { get; } = category;
}