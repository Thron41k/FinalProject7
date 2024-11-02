using FinalProject7.Delivery.DeliveryMethodInfo;

namespace FinalProject7.Delivery;

internal class HomeDelivery(Courier courier, string address) : Delivery
{
    public override string ContactPhoneNumber => courier.Phone;

    public override string GetAddress()
    {
        return address;
    }
}