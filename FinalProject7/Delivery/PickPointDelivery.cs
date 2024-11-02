using FinalProject7.Delivery.DeliveryMethodInfo;

namespace FinalProject7.Delivery;

/// <summary>
/// Представляет доставку в пункт выдачи.
/// </summary>
public class PickPointDelivery : Delivery
{
    private readonly PickupPoint _pickupPoint;

    /// <summary>
    /// Инициализирует новый экземпляр класса <see cref="PickPointDelivery"/>.
    /// </summary>
    /// <param name="pickupPoint">Пункт выдачи для доставки.</param>
    public PickPointDelivery(PickupPoint pickupPoint)
    {
        _pickupPoint = pickupPoint;
    }

    /// <summary>
    /// Возвращает контактный телефонный номер пункта выдачи.
    /// </summary>
    /// <returns>Контактный телефонный номер в виде строки.</returns>
    public override string ContactPhoneNumber => _pickupPoint.Phone;

    /// <summary>
    /// Возвращает адрес пункта выдачи.
    /// </summary>
    /// <returns>Адрес в виде строки.</returns>
    public override string GetAddress()
    {
        return _pickupPoint.Address;
    }
}