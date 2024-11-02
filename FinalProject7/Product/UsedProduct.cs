using FinalProject7.Product.Categories;

namespace FinalProject7.Product;

/// <summary>
/// Представляет продукт с конкретной категорией и информацией об использовании.
/// </summary>
/// <typeparam name="TCategory">Тип категории, который должен наследовать от BaseCategory.</typeparam>
/// <typeparam name="TUsed">Тип информации об использовании.</typeparam>
public class Product<TCategory, TUsed> : Product<TCategory>
    where TCategory : BaseCategory
{
    /// <summary>
    /// Инициализирует новый экземпляр класса Product.
    /// </summary>
    /// <param name="name">Название продукта.</param>
    /// <param name="article">Артикул продукта.</param>
    /// <param name="category">Категория продукта.</param>
    /// <param name="description">Описание продукта.</param>
    /// <param name="price">Цена продукта.</param>
    /// <param name="quantity">Количество продукта.</param>
    /// <param name="brand">Бренд продукта.</param>
    /// <param name="used">Информация об использовании продукта.</param>
    public Product(
        string name,
        string article,
        TCategory category,
        string description,
        double price,
        int quantity,
        string brand,
        TUsed used)
        : base(
            name,
            article,
            category,
            description,
            price,
            quantity,
            brand)
    {
        UsedInformation = used;
        IsUsed = true;
    }

    /// <summary>
    /// Возвращает информацию об использовании продукта.
    /// </summary>
    /// <value>Информация об использовании продукта.</value>
    public TUsed UsedInformation { get; }
}