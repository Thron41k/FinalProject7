namespace FinalProject7.Delivery.DeliveryMethodInfo;

/// <summary>
/// Представляет пункт выдачи с наименованием, телефонным номером и адресом.
/// </summary>
/// <param name="name">Название пункта выдачи.</param>
/// <param name="phone">Телефонный номер пункта выдачи.</param>
/// <param name="address">Адрес пункта выдачи.</param>
public class PickupPoint(string name, string phone, string address) : DeliveryMethodInfo(name, phone)
{
    /// <summary>
    /// Возвращает адрес пункта выдачи.
    /// </summary>
    /// <value>Адрес пункта выдачи.</value>
    public string Address { get; } = address;
}