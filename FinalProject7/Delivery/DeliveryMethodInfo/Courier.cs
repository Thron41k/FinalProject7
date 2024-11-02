namespace FinalProject7.Delivery.DeliveryMethodInfo;

/// <summary>
/// Инициализирует новый экземпляр класса Courier.
/// </summary>
/// <param name="name">Имя курьера.</param>
/// <param name="phone">Номер телефона курьера.</param>
/// <param name="contractor">Подрядчик курьера.</param>
public class Courier(string name, string phone, string contractor): DeliveryMethodInfo(name, phone)
{
    /// <summary>
    /// Возвращает подрядчика курьера.
    /// </summary>
    public string Contractor { get; } = contractor;
}