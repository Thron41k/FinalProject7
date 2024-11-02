namespace FinalProject7.Order;

/// <summary>
/// Представляет заказ с конкретным методом доставки и корзиной покупок.
/// </summary>
/// <typeparam name="TDelivery">Тип метода доставки, который должен наследовать от Delivery.Delivery.</typeparam>
public class Order<TDelivery> : IOrder where TDelivery : Delivery.Delivery
{
    /// <summary>
    /// Инициализирует новый экземпляр класса Order.
    /// </summary>
    /// <param name="delivery">Метод доставки для заказа.</param>
    /// <param name="shoppingCart">Корзина покупок, связанная с заказом.</param>
    public Order(TDelivery delivery, ShoppingCart shoppingCart)
    {
        Delivery = delivery;
        ShoppingCart = shoppingCart;
    }

    /// <summary>
    /// Возвращает или задает метод доставки для заказа.
    /// </summary>
    public TDelivery Delivery { get; set; }

    /// <summary>
    /// Возвращает или задает уникальный идентификатор для заказа.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Возвращает или задает корзину покупок, связанную с заказом.
    /// </summary>
    public ShoppingCart ShoppingCart { get; set; }

    /// <summary>
    /// Определяет, равны ли два заказа на основе их идентификаторов.
    /// </summary>
    /// <param name="order1">Первый заказ для сравнения.</param>
    /// <param name="order2">Второй заказ для сравнения.</param>
    /// <returns>true, если заказы равны; в противном случае — false.</returns>
    public static bool operator ==(Order<TDelivery> order1, Order<TDelivery> order2)
    {
        return order1.Id == order2.Id;
    }

    /// <summary>
    /// Определяет, не равны ли два заказа на основе их идентификаторов.
    /// </summary>
    /// <param name="order1">Первый заказ для сравнения.</param>
    /// <param name="order2">Второй заказ для сравнения.</param>
    /// <returns>true, если заказы не равны; в противном случае — false.</returns>
    public static bool operator !=(Order<TDelivery> order1, Order<TDelivery> order2)
    {
        return order1.Id != order2.Id;
    }
}