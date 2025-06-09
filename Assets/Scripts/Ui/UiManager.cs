using FoodDatabase.Database;
using UnityEngine;

namespace FoodDatabase.Ui
{
    public class UiManager : MonoBehaviour
    {
        [SerializeField] private Transform _cardsContainer;
        [SerializeField] private FoodCard _foodCardPrefab;
        
        [Zenject.Inject] private IDatabase _database;

        private void OnEnable()
        {
            for (int i = _cardsContainer.childCount - 1; i >= 0; i--)
                Destroy(_cardsContainer.GetChild(i).gameObject);

            PopulateCards();
        }

        private void PopulateCards()
        {
            var items = _database.GetAll();
            foreach (var item in items)
            {
                var card = Instantiate(_foodCardPrefab, _cardsContainer);
                card.Initialize(item);
            }
        }
    }
}