namespace FinalProject7.Product.Categories;

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