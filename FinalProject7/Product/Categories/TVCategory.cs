namespace FinalProject7.Product.Categories;

public class TVCategory : BaseCategory
{
    public TVCategory(string diagonal, string resolution, string frequency, bool smartTv)
    {
        Category = CategoryEnum.TV;
        CharacteristicsDictionary.Add("Диагональ экрана", diagonal);
        CharacteristicsDictionary.Add("Разрешение экрана", resolution);
        CharacteristicsDictionary.Add("Частота экрана", frequency);
        CharacteristicsDictionary.Add("Поддержка Smart TV", smartTv ? "Есть" : "Нет");
    }
}