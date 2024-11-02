namespace FinalProject7.Order;

public static class OrderExtension
{
    public static void WriteOrderInfo(this IOrder order)
    {
        Console.WriteLine($"Заказ №{order.Id}");
        Console.WriteLine($"Количество позиций: {order.ShoppingCart.TotalCount} шт.");
        Console.WriteLine($"Сумма заказа: {order.ShoppingCart.SumPrice} руб.");
        Console.WriteLine("-------------------------------------");
        for (var i = 0; i < order.ShoppingCart.Count; i++)
        {
            var item = order.ShoppingCart[i];
            Console.WriteLine($"\t{i + 1}) {item.Name} - {item.Quantity} шт. - {item.SumPrice} руб.");
            Console.WriteLine("\t-----------------------------------");
        }
        Console.WriteLine("-------------------------------------");
    }
}