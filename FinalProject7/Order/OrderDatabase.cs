using FinalProject7.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject7.Order
{
    internal class OrderDatabase
    {
        private static readonly OrderDatabase Instance = new();
        private readonly List<IOrder> _orders = [];

        public IOrder this[int index] => _orders[index];

        public List<IOrder> GetOrders()
        {
            return _orders;
        }

        public int AddOrder<TOrder>(TOrder order) where TOrder : IOrder
        {
            order.Id = _orders.Count == 0 ? 0 : _orders.Max(product1 => product1.Id) + 1;
            _orders.Add(order);
            return order.Id;
        }

        public void RemoveOrder<TOrder>(TOrder order) where TOrder : IOrder
        {
            _orders.Remove(order);
        }

        public void UpdateOrder<TOrder>(TOrder order) where TOrder : IOrder
        {
            _orders.Remove(order);
            _orders.Add(order);
        }

        public TOrder? GetOrderById<TOrder>(int id) where TOrder : IOrder
        {
            return _orders.OfType<TOrder>().FirstOrDefault(order => order.Id == id);
        }

        public static OrderDatabase GetInstance()
        {
            return Instance;
        }
    }
}
