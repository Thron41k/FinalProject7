using FinalProject7.Delivery.DeliveryMethodInfo;

namespace FinalProject7.Delivery;

/// <summary>
/// Представляет доставку в магазин.
/// </summary>
internal class ShopDelivery : Delivery
{
    private readonly Shop _shop;
    /// <summary>
    /// Возвращает контактный телефон магазина.
    /// </summary>
    /// <value>Контактный телефон.</value>
    public override string ContactPhoneNumber => _shop.Phone;

    /// <summary>
    /// Инициализирует новый экземпляр класса <see cref="ShopDelivery"/>.
    /// </summary>
    /// <param name="shop">Магазин, в который доставляется.</param>
    public ShopDelivery(Shop shop)
    {
        _shop = shop;
    }

    /// <summary>
    /// Возвращает адрес магазина.
    /// </summary>
    /// <returns>Адрес магазина.</returns>
    public override string GetAddress()
    {
        return _shop.Address;
    }
}