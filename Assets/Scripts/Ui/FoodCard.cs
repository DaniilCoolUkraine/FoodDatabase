using System.Text;
using FoodDatabase.Database;
using FoodDatabase.DataProviders;
using FoodDatabase.Localization;
using TMPro;
using UnityEngine;

namespace FoodDatabase.Ui
{
    public class FoodCard : MonoBehaviour
    {
        [Header("References")]
        [SerializeField] private TextMeshProUGUI _header;
        [SerializeField] private TextMeshProUGUI _description;

        [Header("Locals")]
        [SerializeField] private string _quantityKey;
        [SerializeField] private string _dateUpdatedKey;

        private ILocalizer _localizer;

        public void Initialize(IITem itemData)
        {
            _header.text = itemData.Name;
            _description.text = CollectDescription(itemData);
        }

        private string CollectDescription(IITem itemData)
        {
            _localizer = ContainerProvider.Container.Resolve<IDataProvider>().Localizer;

            var sb = new StringBuilder();

            sb.Append(_localizer.GetLocalizedString(_quantityKey));
            sb.Append(": ");
            sb.Append(itemData.Quantity);
            sb.Append(" ");
            sb.Append(_localizer.GetLocalizedString(itemData.MeasurementType.ToString()));
            sb.Append("\t\t");
            sb.Append(_localizer.GetLocalizedString(_dateUpdatedKey));
            sb.Append(": ---");
            
            return sb.ToString();
        }
    }
}