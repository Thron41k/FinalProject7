using FinalProject7.Product;

namespace FinalProject7;

/// <summary>
/// Представляет корзину для покупок, которая может содержать различные продукты.
/// </summary>
public class ShoppingCart
{
    private readonly List<BaseProduct> _products = new List<BaseProduct>();

    /// <summary>
    /// Возвращает продукт по указанному индексу.
    /// </summary>
    /// <param name="index">Индекс продукта, который нужно вернуть.</param>
    /// <returns>Продукт по указанному индексу.</returns>
    public BaseProduct this[int index] => _products[index];

    /// <summary>
    /// Возвращает общую стоимость всех продуктов в корзине.
    /// </summary>
    /// <returns>Общая стоимость всех продуктов в корзине.</returns>
    public double TotalPrice => _products.Sum(p => p.TotalPrice);

    /// <summary>
    /// Возвращает общее количество всех продуктов в корзине.
    /// </summary>
    /// <returns>Общее количество всех продуктов в корзине.</returns>
    public int TotalQuantity => _products.Sum(p => p.Quantity);

    /// <summary>
    /// Возвращает количество продуктов в корзине.
    /// </summary>
    /// <returns>Количество продуктов в корзине.</returns>
    public int ProductCount => _products.Count;

    /// <summary>
    /// Добавляет продукт в корзину и возвращает его присвоенный ID.
    /// </summary>
    /// <typeparam name="TProduct">Тип продукта, который нужно добавить.</typeparam>
    /// <param name="product">Продукт, который нужно добавить.</param>
    /// <returns>Присвоенный ID добавленного продукта.</returns>
    public int AddProduct<TProduct>(TProduct product) where TProduct : BaseProduct
    {
        product.ProductId = _products.Any() ? _products.Max(p => p.ProductId) + 1 : 0;
        _products.Add(product);
        return product.ProductId;
    }

    /// <summary>
    /// Удаляет указанный продукт из корзины.
    /// </summary>
    /// <typeparam name="TProduct">Тип продукта, который нужно удалить.</typeparam>
    /// <param name="product">Продукт, который нужно удалить.</param>
    public void RemoveProduct<TProduct>(TProduct product) where TProduct : BaseProduct
    {
        _products.Remove(product);
    }

    /// <summary>
    /// Удаляет продукт по указанному индексу из корзины.
    /// </summary>
    /// <param name="index">Индекс продукта, который нужно удалить.</param>
    public void RemoveProductAt(int index)
    {
        _products.RemoveAt(index);
    }
}