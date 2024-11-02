namespace FinalProject7.Order;

public static class OrderExtension
{
    /// <summary>
    /// Выводит информацию о заказе в консоль.
    /// </summary>
    /// <param name="order">Заказ, информацию о котором нужно вывести.</param>
    public static void WriteOrderInfo(this IOrder order)
    {
        Console.WriteLine($"Заказ №{order.Id}");
        Console.WriteLine($"Количество позиций: {order.ShoppingCart.TotalQuantity} шт.");
        Console.WriteLine($"Сумма заказа: {order.ShoppingCart.TotalPrice} руб.");
        Console.WriteLine("-------------------------------------");
        for (var i = 0; i < order.ShoppingCart.ProductCount; i++)
        {
            var item = order.ShoppingCart[i];
            Console.WriteLine($"\t{i + 1}) {item.ProductName} - {item.Quantity} шт. - {item.TotalPrice} руб.");
            Console.WriteLine("\t-----------------------------------");
        }
        Console.WriteLine("-------------------------------------");
    }
}