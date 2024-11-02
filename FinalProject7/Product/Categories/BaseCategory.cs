namespace FinalProject7.Product.Categories;

public abstract class BaseCategory
{
    public CategoryEnum Category { get; set; }
    protected Dictionary<string, string> CharacteristicsDictionary { get; } = new();

    public List<string> GetCharacteristicsNames()
    {
        return CharacteristicsDictionary.Keys.ToList();
    }
    public string this[string key]
    {
        get => CharacteristicsDictionary[key];
        set => CharacteristicsDictionary[key] = value;
    }
    public string this[int index]
    {
        get => CharacteristicsDictionary.Values.ElementAt(index);
        set => CharacteristicsDictionary[CharacteristicsDictionary.Keys.ElementAt(index)] = value;
    }
    public Dictionary<string, string> GetCharacteristics()
    {
        return CharacteristicsDictionary;
    }
}