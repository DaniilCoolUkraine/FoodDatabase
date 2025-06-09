namespace FoodDatabase.Database.JsonDatabase
{
    public class JsonItem :  IITem
    {
        public int Id { get; }
        public string Name { get; }

        public JsonItem(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}