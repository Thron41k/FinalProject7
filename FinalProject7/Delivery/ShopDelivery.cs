using FinalProject7.Delivery.DeliveryMethodInfo;

namespace FinalProject7.Delivery;

internal class ShopDelivery(Shop shop) : Delivery
{
    private Shop Shop { get; } = shop;
    public override string ContactPhoneNumber => Shop.Phone;

    public override string GetAddress()
    {
        return Shop.Address;
    }
}