using FinalProject7.Delivery.DeliveryMethodInfo;

namespace FinalProject7.Delivery;

/// <summary>
/// Представляет доставку на дом с курьером и адресом.
/// </summary>
public class HomeDelivery : Delivery
{
    private readonly Courier _courier;
    private readonly string _address;

    /// <summary>
    /// Инициализирует новый экземпляр класса <see cref="HomeDelivery"/>.
    /// </summary>
    /// <param name="courier">Курьер, отвечающий за доставку.</param>
    /// <param name="address">Адрес, куда будет доставлено.</param>
    public HomeDelivery(Courier courier, string address)
    {
        _courier = courier;
        _address = address;
    }

    /// <summary>
    /// Возвращает контактный телефон курьера.
    /// </summary>
    /// <returns>Контактный телефон курьера.</returns>
    public override string ContactPhoneNumber => _courier.Phone;

    /// <summary>
    /// Возвращает адрес, куда будет доставлено.
    /// </summary>
    /// <returns>Адрес, куда будет доставлено.</returns>
    public override string GetAddress()
    {
        return _address;
    }
}