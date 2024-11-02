namespace FinalProject7.Delivery;
public abstract class Delivery
{
    public DateTime Date { get; set; }
    public abstract string ContactPhoneNumber { get; }

    public abstract string GetAddress();
}

