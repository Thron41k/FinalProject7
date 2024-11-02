namespace FinalProject7.Product;

/// <summary>
/// Базовый класс для продукта.
/// </summary>
/// <param name="productName">Название продукта.</param>
/// <param name="articleNumber">Артикул продукта.</param>
/// <param name="productDescription">Описание продукта.</param>
/// <param name="unitPrice">Цена за единицу продукта.</param>
/// <param name="quantity">Количество продукта.</param>
/// <param name="brandName">Бренд продукта.</param>
public abstract class BaseProduct(
    string productName,
    string articleNumber,
    string productDescription,
    double unitPrice,
    int quantity,
    string brandName)
{
    /// <summary>
    /// Уникальный идентификатор продукта.
    /// </summary>
    public int ProductId { get; set; }

    private readonly string _productName = productName;
    /// <summary>
    /// Название продукта, с указанием, что он б/у, если это так.
    /// </summary>
    public string ProductName => IsUsed ? $"{_productName} (б/у)" : _productName;

    /// <summary>
    /// Артикул продукта.
    /// </summary>
    public string ArticleNumber { get; } = articleNumber;
    /// <summary>
    /// Описание продукта.
    /// </summary>
    public string ProductDescription { get; } = productDescription;
    /// <summary>
    /// Цена за единицу продукта.
    /// </summary>
    public double UnitPrice { get; } = unitPrice;
    /// <summary>
    /// Количество продукта.
    /// </summary>
    public int Quantity { get; } = quantity;
    /// <summary>
    /// Бренд продукта.
    /// </summary>
    public string BrandName { get; } = brandName;

    /// <summary>
    /// Общая стоимость продукта.
    /// </summary>
    public double TotalPrice => UnitPrice * Quantity;

    /// <summary>
    /// Признак того, что продукт б/у.
    /// </summary>
    protected bool IsUsed { get; init; }
}