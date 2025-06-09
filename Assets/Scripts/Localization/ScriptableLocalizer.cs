using System.Linq;
using UnityEngine;

namespace FoodDatabase.Localization
{
    [CreateAssetMenu(fileName = "ScriptableLocalizer", menuName = "Localization/Scriptable Localizer")]
    public class ScriptableLocalizer : ScriptableObject, ILocalizer
    {
        [SerializeField] private LocalizationItem[] _keyToLocal;

        public string GetLocalizedString(string key)
        {
            return _keyToLocal.FirstOrDefault(l => l.Key == key)?.Local ?? "*NO LOCAL*";
        }
    }
}