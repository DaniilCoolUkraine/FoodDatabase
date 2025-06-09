namespace FoodDatabase.Database.JsonDatabase
{
    public class JsonItem : IITem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public EMeasurementType MeasurementType { get; set; }
    }
}