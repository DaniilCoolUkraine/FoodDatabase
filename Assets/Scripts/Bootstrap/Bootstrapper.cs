using Cysharp.Threading.Tasks;
using FoodDatabase.Database;
using UnityEngine;
using UnityEngine.SceneManagement;
using Zenject;

namespace FoodDatabase.Bootstrap
{
    public class Bootstrapper : MonoBehaviour
    {
        private const int MainSceneIndex = 1;

        [Inject] private IDatabase _database;

        private async void Awake()
        {
            _database.Load();
            await UniTask.WaitUntil(() => !_database.IsBusy);

            var loadingHandler = SceneManager.LoadSceneAsync(MainSceneIndex);
            await loadingHandler.ToUniTask();
        }
    }
}