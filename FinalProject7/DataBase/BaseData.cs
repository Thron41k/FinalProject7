using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject7.DataBase.Items;

namespace FinalProject7.DataBase
{
    public class BaseData<T> where T : BaseItem
    {
        protected readonly List<T> Data = [];

        public void Add(T item)
        {
            item.Id = Data.Count == 0 ? 0 : Data.Max(x => x.Id) + 1;
            Data.Add(item);
        }
        public void Remove(T item)
        {
            Data.Remove(item);
        }
        public T this [int index] => Data[index];

        public void Update(int index, T item)
        {
            Data[index] = item;
        }

        public void Update(T item)
        {
            if(Data.Any(x => x.Id == item.Id))
            {
                Update(Data.FindIndex(x => x.Id == item.Id), item);
            }
            else
            {
                Add(item);
            }
        }
        public int Count => Data.Count;
    }
}
