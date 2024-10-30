using FinalProject7;
using FinalProject7.DataBase;
using FinalProject7.DataBase.Items;
using FinalProject7.Sections;

var sm = new SectionManager();
sm.Add(new FirstSection("Главный раздел"));
DataBase.GetInstance().Add(new BaseData<CatalogItem>(), DataBaseEnum.Catalog);
var dd = DataBase.GetInstance().Get<BaseData<CatalogItem>>(DataBaseEnum.Catalog);
dd.Add(new CatalogItem("Кофеварка", "MS-19876","Лучшая кофеварка",200.4));
DataBase.GetInstance().Save();
sm.ActiveSection = 0;
string? input;
do
{
    input = Console.ReadLine();
    sm.Input(input);
} while (!string.Equals(input, "exit"));

