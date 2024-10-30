using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace FinalProject7.DataBase
{
    public class DataBase
    {
        private static readonly DataBase Instance = new DataBase();
        private Dictionary<DataBaseEnum, object>? _data = new();
        private string _dbPath = "DataBase.json";
        private DataBase()
        {
            var jsonOptions = new JsonSerializerOptions
            {
                WriteIndented = true,
            };
            if (File.Exists(_dbPath))
            {
                var json = File.ReadAllText(_dbPath);
                _data = JsonSerializer.Deserialize<Dictionary<DataBaseEnum, object>>(json);
            }
            else
            {
                using var fs = new FileStream(_dbPath, FileMode.Create);
                JsonSerializer.Serialize(fs, this, jsonOptions);
            }
        }

        public static DataBase GetInstance()
        {
            return Instance;
        }

        public void Add<T>(T item, DataBaseEnum key)
        {
            if (item == null) return;
            if(_data != null && _data.ContainsKey(key))return;
            _data?.Add(key, item);
            Save();
        }

        public T Get<T>(DataBaseEnum key)
        {
            return (T)_data![key];
        }
        public void Save()
        {
            var jsonOptions = new JsonSerializerOptions
            {
                WriteIndented = true,
            };
            using var fs = new FileStream(_dbPath, FileMode.Create);
            JsonSerializer.Serialize(fs, _data, jsonOptions);
        }
    }
}
