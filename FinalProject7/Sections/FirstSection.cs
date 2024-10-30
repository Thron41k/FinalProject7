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
        _mainNavigationList ??= new Dictionary<short, string>
        {
            { 0, "Каталог товаров" },
            { 1, "Корзина" },
            { 2, "Заказы" },
            { 3, "Назад" },
        };

        InfoBoard.SetMainNav = _mainNavigationList;
    }
}
