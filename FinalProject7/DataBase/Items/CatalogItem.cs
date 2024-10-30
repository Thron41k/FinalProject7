using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject7.DataBase.Items
{
    internal class CatalogItem(string name, string article, string description, double price)
        : BaseItem
    {
        public string Name { get; set; } = name;
        public string Article { get; set; } = article;
        public string Description { get; set; } = description;
        public double Price { get; set; } = price;
    }
}
