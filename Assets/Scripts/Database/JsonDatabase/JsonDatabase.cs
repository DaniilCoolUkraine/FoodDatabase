using System.Collections.Generic;
using System.IO;
using System.Linq;
using Cysharp.Threading.Tasks;
using Newtonsoft.Json;
using UnityEngine;

namespace FoodDatabase.Database.JsonDatabase
{
    public class JsonDatabase : IDatabase
    {
        public bool IsBusy { get; private set; }

        private readonly string _filePath;
        private HashSet<IITem> _items;

        public JsonDatabase()
        {
            _filePath = Application.persistentDataPath + "/database.json";
        }

        public async void Load()
        {
            IsBusy = true;

            var readingHandler = File.ReadAllTextAsync(_filePath).AsUniTask();
            var json = await readingHandler;

            var array = JsonConvert.DeserializeObject<IITem[]>(json);

            if (array != null)
            {
                _items = array.ToHashSet();
            }
            else
            {
                Debug.LogWarning("Failed to load database");
            }

            IsBusy = false;
        }

        public async void Save()
        {
            IsBusy = true;

            var json = JsonConvert.SerializeObject(_items);
            await File.WriteAllTextAsync(_filePath, json).AsUniTask();

            IsBusy = false;
        }
        
        public IEnumerable<IITem> GetAll()
        {
            return _items;
        }

        public IITem GetItem(int id)
        {
            return _items.First(i => i.Id == id);
        }

        public void AddItem(IITem item)
        {
            _items.Add(item);
        }
    }
}