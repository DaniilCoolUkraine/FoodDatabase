using FoodDatabase.Localization;
using UnityEngine;

namespace FoodDatabase.DataProviders
{
    public class DataProvider : MonoBehaviour, IDataProvider
    {
        [SerializeField] private ScriptableLocalizer _localizer;

        public ILocalizer Localizer => _localizer;
    }
}