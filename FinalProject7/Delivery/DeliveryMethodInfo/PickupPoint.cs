namespace FinalProject7.Delivery.DeliveryMethodInfo;

internal class PickupPoint(string name, string phone, string address) : DeliveryMethodInfo(name, phone)
{
    public string Address { get; } = address;
}