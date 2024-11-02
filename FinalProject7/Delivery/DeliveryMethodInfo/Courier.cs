namespace FinalProject7.Delivery.DeliveryMethodInfo;

internal class Courier(string name, string phone, string contractor): DeliveryMethodInfo(name, phone)
{
    public string Contractor { get; } = contractor;
}