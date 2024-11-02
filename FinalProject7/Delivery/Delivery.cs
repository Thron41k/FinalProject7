namespace FinalProject7.Delivery;

/// <summary>
/// Абстрактный класс, представляющий доставку.
/// </summary>
public abstract class Delivery
{
    /// <summary>
    /// Дата доставки.
    /// </summary>
    public DateTime Date { get; set; }

    /// <summary>
    /// Возвращает контактный телефон курьера, пункта выдачи или магазина.
    /// </summary>
    /// <returns>Контактный телефон курьера, пункта выдачи или магазина.</returns>
    public abstract string ContactPhoneNumber { get; }

    /// <summary>
    /// Возвращает адрес доставки, пункта выдачи или магазина. 
    /// </summary>
    /// <returns>Адрес доставки, пункта выдачи или магазина.</returns>
    public abstract string GetAddress();
}

