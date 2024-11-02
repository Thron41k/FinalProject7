namespace FinalProject7.Product.Categories;

/// <summary>
/// Инициализирует новый экземпляр класса FridgeCategory.
/// </summary>
/// <param name="energyConsumption">Энергопотребление холодильника.</param>
/// <param name="noiseLevel">Уровень шума холодильника.</param>
/// <param name="totalVolume">Общий полезный объем холодильника.</param>
/// <param name="numberOfCameras">Количество камер холодильника.</param>
public class FridgeCategory : BaseCategory
{
    public FridgeCategory(
        string energyConsumption,
        string noiseLevel,
        string totalVolume,
        int numberOfCameras)
    {
        Category = CategoryEnum.Fridge;
        CharacteristicsDictionary.Add("Энергопотребление", energyConsumption);
        CharacteristicsDictionary.Add("Уровень шума", noiseLevel);
        CharacteristicsDictionary.Add("Общий полезный объем", totalVolume);
        CharacteristicsDictionary.Add("Количество камер", numberOfCameras.ToString());
    }
}