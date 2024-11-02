namespace FinalProject7.Order;

/// <summary>
/// Представляет заказ с уникальным идентификатором и корзиной покупок.
/// </summary>
public interface IOrder
{
    /// <summary>
    /// Возвращает или устанавливает уникальный идентификатор заказа.
    /// </summary>
    /// <value>Уникальный идентификатор заказа.</value>
    int Id { get; set; }

    /// <summary>
    /// Возвращает или устанавливает корзину покупок, связанную с заказом.
    /// </summary>
    /// <value>Корзина покупок, связанная с заказом.</value>
    ShoppingCart ShoppingCart { get; set; }
}