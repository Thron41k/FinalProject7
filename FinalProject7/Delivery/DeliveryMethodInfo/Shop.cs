namespace FinalProject7.Delivery.DeliveryMethodInfo;

/// <summary>
/// Представляет магазин с названием, телефонным номером, адресом и номером кассы.
/// </summary>
/// <param name="name">Название магазина.</param>
/// <param name="phone">Телефонный номер магазина.</param>
/// <param name="address">Адрес магазина.</param>
/// <param name="cashDeskNumber">Номер кассы.</param>
public class Shop(string name, string phone, string address, int cashDeskNumber) : PickupPoint(name, phone, address)
{
    /// <summary>
    /// Возвращает номер кассы.
    /// </summary>
    /// <value>Номер кассы.</value>
    public int CashDeskNumber { get; } = cashDeskNumber;
}