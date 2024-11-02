namespace FinalProject7.Delivery.DeliveryMethodInfo;

internal class Shop(string name, string phone, string address, int cashDeskNumber) : PickupPoint(name, phone, address)
{
    public int CashDeskNumber { get; } = cashDeskNumber;
}