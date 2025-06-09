using System.Collections.Generic;

namespace FoodDatabase.Database
{
    public interface IDatabase
    {
        public bool IsBusy { get; }

        public void Load();
        public void Save();

        public IEnumerable<IITem> GetAll();
        public IITem GetItem(int id);
        public void AddItem(IITem item);
    }
}