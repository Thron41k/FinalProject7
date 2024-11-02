using FinalProject7.Product.Categories;

namespace FinalProject7.Product;

/// <summary>
/// Инициализирует новый экземпляр класса Product.
/// </summary>
/// <typeparam name="TCategory">Тип категории, который должен наследовать от BaseCategory.</typeparam>
/// <param name="name">Название продукта.</param>
/// <param name="article">Артикул продукта.</param>
/// <param name="category">Категория продукта.</param>
/// <param name="description">Описание продукта.</param>
/// <param name="price">Цена продукта.</param>
/// <param name="quantity">Количество продукта.</param>
/// <param name="brand">Бренд продукта.</param>
public class Product<TCategory>(string name, string article, TCategory category, string description, double price, int quantity, string brand) : BaseProduct(name, article, description, price, quantity, brand) where TCategory : BaseCategory
{
    /// <summary>
    /// Категория продукта.
    /// </summary>
    public TCategory Category { get; } = category;
}