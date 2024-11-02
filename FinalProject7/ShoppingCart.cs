using FinalProject7.Product;

namespace FinalProject7;

public class ShoppingCart
{
    private readonly List<BaseProduct> _products = [];
    public BaseProduct this[int index] => _products[index];

    public int Add<TProduct>(TProduct product) where TProduct : BaseProduct
    {
        product.Id = _products.Count == 0 ? 0 : _products.Max(product1 => product1.Id) + 1;
        _products.Add(product);
        return product.Id;
    }
    public void Remove<TProduct>(TProduct product) where TProduct : BaseProduct
    {
        _products.Remove(product);
    }
    public void Remove(int index)
    {
        _products.RemoveAt(index);
    }
    public double SumPrice => _products.Sum(p => p.SumPrice);
        
    public int TotalCount => _products.Sum(p => p.Quantity);
    public int Count => _products.Count;

}