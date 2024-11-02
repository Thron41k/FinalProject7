namespace FinalProject7.Order;

public class Order<TDelivery>(TDelivery delivery, ShoppingCart shoppingCart) : IOrder where TDelivery : Delivery.Delivery
{
    public TDelivery Delivery = delivery;
    public int Id { get; set; }
    public ShoppingCart ShoppingCart { get; set; } = shoppingCart;

    public static bool operator ==(Order<TDelivery> order1, Order<TDelivery> order2)
    {
        return order1.Id == order2.Id;
    }

    public static bool operator !=(Order<TDelivery> order1, Order<TDelivery> order2)
    {
        return order1.Id != order2.Id;
    }
}