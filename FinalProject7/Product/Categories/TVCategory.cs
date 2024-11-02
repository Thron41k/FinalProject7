namespace FinalProject7.Product.Categories;

/// <summary>
/// Инициализирует новый экземпляр класса TVCategory.
/// </summary>
/// <param name="diagonal">Диагональ экрана.</param>
/// <param name="resolution">Разрешение экрана.</param>
/// <param name="frequency">Частота экрана.</param>
/// <param name="smartTv">Поддержка Smart TV.</param>
public class TVCategory : BaseCategory
{
    public TVCategory(
        string diagonal,
        string resolution,
        string frequency,
        bool smartTv)
    {
        Category = CategoryEnum.TV;
        CharacteristicsDictionary.Add("Диагональ экрана", diagonal);
        CharacteristicsDictionary.Add("Разрешение экрана", resolution);
        CharacteristicsDictionary.Add("Частота экрана", frequency);
        CharacteristicsDictionary.Add("Поддержка Smart TV", smartTv ? "Есть" : "Нет");
    }
}