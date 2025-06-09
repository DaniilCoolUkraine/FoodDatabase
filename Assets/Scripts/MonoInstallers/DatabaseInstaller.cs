using FoodDatabase.Database;
using FoodDatabase.Database.JsonDatabase;
using Zenject;

namespace FoodDatabase.MonoInstallers
{
    public class DatabaseInstaller : MonoInstaller
    {
        private JsonDatabase _database;

        public override void InstallBindings()
        {
            _database = new JsonDatabase();
            Container.Bind<IDatabase>().FromInstance(_database).AsSingle();
        }
    }
}