namespace FinalProject7.Product.Categories;

/// <summary>
/// Инициализирует новый экземпляр класса NetworkEquipmentCategory.
/// </summary>
/// <param name="wifi">Флаг наличия Wi-Fi.</param>
/// <param name="wifiType">Тип Wi-Fi.</param>
/// <param name="lanPorts">Количество LAN портов.</param>
/// <param name="lanSpeed">Скорость LAN портов.</param>
public class NetworkEquipmentCategory : BaseCategory
{
    public NetworkEquipmentCategory(bool wifi, string wifiType = "", int lanPorts = 0, string lanSpeed = "")
    {
        Category = CategoryEnum.NetworkEquipment;
        if (wifi)
        {
            CharacteristicsDictionary.Add("Wi-Fi", "Есть");
            CharacteristicsDictionary.Add("Тип Wi-Fi", wifiType);
        }
        else
        {
            CharacteristicsDictionary.Add("Wi-Fi", "Нет");
        }
        if (lanPorts <= 0) return;
        CharacteristicsDictionary.Add("Количество LAN портов", lanPorts.ToString());
        CharacteristicsDictionary.Add("Скорость LAN портов", lanSpeed);
    }
}