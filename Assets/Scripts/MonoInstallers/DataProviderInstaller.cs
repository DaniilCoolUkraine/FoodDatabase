using FoodDatabase.DataProviders;
using UnityEngine;
using Zenject;

namespace FoodDatabase.MonoInstallers
{
    public class DataProviderInstaller : MonoInstaller
    {
        [SerializeField] private DataProvider _dataProvider;

        public override void InstallBindings()
        {
            Container.Bind<IDataProvider>().To<DataProvider>().FromInstance(_dataProvider).AsSingle();
            ContainerProvider.Container = Container;
        }
    }
}