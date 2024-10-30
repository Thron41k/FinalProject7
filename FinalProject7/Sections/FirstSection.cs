using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject7.Sections;
public class FirstSection(string title) : BaseSection(title)
{
    public override void Activate()
    {
        Console.Title = Title;
        if (_mainNavigationList == null)
        {
            _mainNavigationList = new Dictionary<short,string>();
            _mainNavigationList.Add(0, "Каталог товаров");
            _mainNavigationList.Add(1, "Корзина");
            _mainNavigationList.Add(2, "Заказы");
            _mainNavigationList.Add(3, "Выход");
        }
    }
}
