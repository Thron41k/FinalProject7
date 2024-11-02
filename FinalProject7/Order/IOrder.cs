namespace FinalProject7.Order;

public interface IOrder
{
    public int Id { get; set; }
    public ShoppingCart ShoppingCart { get; set; }
}