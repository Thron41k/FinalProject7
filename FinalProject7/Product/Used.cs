namespace FinalProject7.Product;

/// <summary>
/// Представляет состояние использованного продукта.
/// </summary>
public class Used
{
    /// <summary>
    /// Указывает, был ли продукт отремонтирован.
    /// </summary>
    public bool IsRenovated { get; }

    /// <summary>
    /// Количество месяцев, в течение которых продукт использовался.
    /// </summary>
    public int MonthsInUse { get; }

    /// <summary>
    /// Текущее состояние продукта от 0 до 10.
    /// </summary>
    public short State { get; }

    /// <summary>
    /// Инициализирует новый экземпляр класса Used.
    /// </summary>
    /// <param name="isRenovated">Указывает, был ли продукт отремонтирован.</param>
    /// <param name="monthsInUse">Количество месяцев, в течение которых продукт использовался.</param>
    /// <param name="state">Текущее состояние продукта от 0 до 10.</param>
    public Used(bool isRenovated, int monthsInUse, short state)
    {
        IsRenovated = isRenovated;
        MonthsInUse = monthsInUse;
        State = state;
    }
}