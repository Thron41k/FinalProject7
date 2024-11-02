using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject7.Product.Categories
{
    internal class FridgeCategory : BaseCategory
    {
        public FridgeCategory(string energyConsumption, string noiseLevel,string totalVolume, int numberOfCameras)
        {
            Category = CategoryEnum.Fridge;
            CharacteristicsDictionary.Add("Энергопотребление", energyConsumption);
            CharacteristicsDictionary.Add("Уровень шума", noiseLevel);
            CharacteristicsDictionary.Add("Общий полезный объем", totalVolume);
            CharacteristicsDictionary.Add("Количество камер", numberOfCameras.ToString());
        }
    }
}
