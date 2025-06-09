using FoodDatabase.Localization;
using UnityEngine;

namespace FoodDatabase.DataProviders
{
    public interface IDataProvider
    {
        public GameObject gameObject { get; }
        
        public ILocalizer Localizer { get; }
    }
}