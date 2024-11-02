namespace FinalProject7.Order;

/// <summary>
/// Представляет базу данных заказов.
/// </summary>
public class OrderDatabase
{
    /// <summary>
    /// Единственный экземпляр базы данных заказов.
    /// </summary>
    private static readonly OrderDatabase Instance = new();

    /// <summary>
    /// Список заказов в базе данных.
    /// </summary>
    private readonly List<IOrder> _orders = [];

    /// <summary>
    /// Возвращает заказ по указанному индексу.
    /// </summary>
    /// <param name="index">Индекс заказа для получения.</param>
    /// <returns>Заказ по указанному индексу.</returns>
    public IOrder this[int index] => _orders[index];

    /// <summary>
    /// Возвращает список всех заказов в базе данных.
    /// </summary>
    /// <returns>Список всех заказов в базе данных.</returns>
    public List<IOrder> GetOrders()
    {
        return _orders;
    }

    /// <summary>
    /// Добавляет новый заказ в базу данных.
    /// </summary>
    /// <typeparam name="TOrder">Тип заказа для добавления.</typeparam>
    /// <param name="order">Заказ для добавления.</param>
    /// <returns>Идентификатор добавленного заказа.</returns>
    public int AddOrder<TOrder>(TOrder order) where TOrder : IOrder
    {
        order.Id = _orders.Count == 0 ? 0 : _orders.Max(product1 => product1.Id) + 1;
        _orders.Add(order);
        return order.Id;
    }

    /// <summary>
    /// Удаляет заказ из базы данных.
    /// </summary>
    /// <typeparam name="TOrder">Тип заказа для удаления.</typeparam>
    /// <param name="order">Заказ для удаления.</param>
    public void RemoveOrder<TOrder>(TOrder order) where TOrder : IOrder
    {
        _orders.Remove(order);
    }

    /// <summary>
    /// Обновляет существующий заказ в базе данных.
    /// </summary>
    /// <typeparam name="TOrder">Тип заказа для обновления.</typeparam>
    /// <param name="order">Заказ для обновления.</param>
    public void UpdateOrder<TOrder>(TOrder order) where TOrder : IOrder
    {
        _orders.Remove(order);
        _orders.Add(order);
    }

    /// <summary>
    /// Возвращает заказ по его идентификатору.
    /// </summary>
    /// <typeparam name="TOrder">Тип заказа для получения.</typeparam>
    /// <param name="id">Идентификатор заказа для получения.</param>
    /// <returns>Заказ с указанным идентификатором, или null, если не найден.</returns>
    public TOrder? GetOrderById<TOrder>(int id) where TOrder : IOrder
    {
        return _orders.OfType<TOrder>().FirstOrDefault(order => order.Id == id);
    }

    /// <summary>
    /// Возвращает единственный экземпляр базы данных заказов.
    /// </summary>
    /// <returns>Единственный экземпляр базы данных заказов.</returns>
    public static OrderDatabase GetInstance()
    {
        return Instance;
    }
}