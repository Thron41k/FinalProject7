using FinalProject7.Delivery.DeliveryMethodInfo;

namespace FinalProject7.Delivery;

internal class PickPointDelivery(PickupPoint pickupPoint) : Delivery
{
    private PickupPoint PickupPoint { get; } = pickupPoint;
    public override string ContactPhoneNumber => PickupPoint.Phone;
    public override string GetAddress()
    {
        return PickupPoint.Address;
    }
}