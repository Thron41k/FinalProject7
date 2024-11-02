namespace FinalProject7.Product.Categories;

/// <summary>
/// Представляет базовую категорию с характеристиками.
/// </summary>
public abstract class BaseCategory
{
    /// <summary>
    /// Возвращает или устанавливает тип категории.
    /// </summary>
    public CategoryEnum Category { get; set; }

    /// <summary>
    /// Возвращает словарь характеристик.
    /// </summary>
    protected Dictionary<string, string> CharacteristicsDictionary { get; } = new Dictionary<string, string>();

    /// <summary>
    /// Возвращает список имен характеристик.
    /// </summary>
    /// <returns>Список строк, представляющих имена характеристик.</returns>
    public List<string> GetCharacteristicsNames()
    {
        return CharacteristicsDictionary.Keys.ToList();
    }

    /// <summary>
    /// Возвращает или устанавливает значение характеристики по ее ключу.
    /// </summary>
    /// <param name="key">Ключ характеристики.</param>
    /// <returns>Значение характеристики.</returns>
    public string this[string key]
    {
        get => CharacteristicsDictionary[key];
        set => CharacteristicsDictionary[key] = value;
    }

    /// <summary>
    /// Возвращает или устанавливает значение характеристики по ее индексу.
    /// </summary>
    /// <param name="index">Индекс характеристики.</param>
    /// <returns>Значение характеристики.</returns>
    public string this[int index]
    {
        get => CharacteristicsDictionary.Values.ElementAt(index);
        set => CharacteristicsDictionary[CharacteristicsDictionary.Keys.ElementAt(index)] = value;
    }

    /// <summary>
    /// Возвращает словарь характеристик.
    /// </summary>
    /// <returns>Словарь строк, представляющих характеристики.</returns>
    public Dictionary<string, string> GetCharacteristics()
    {
        return CharacteristicsDictionary;
    }
}