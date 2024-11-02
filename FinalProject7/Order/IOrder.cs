using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject7.Order
{
    public interface IOrder
    {
        public int Id { get; set; }
        public ShoppingCart ShoppingCart { get; set; }
    }
}
