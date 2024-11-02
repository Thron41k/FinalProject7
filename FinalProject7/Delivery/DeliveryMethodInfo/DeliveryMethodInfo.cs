namespace FinalProject7.Delivery.DeliveryMethodInfo;

internal abstract class DeliveryMethodInfo(string name, string phone)
{
    public string Name { get; } = name;
    public string Phone { get; } = phone;
}
