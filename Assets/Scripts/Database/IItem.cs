namespace FoodDatabase.Database
{
    public interface IITem
    {
        public int Id { get; }
        public string Name { get; }
        public int Quantity { get; }
        public EMeasurementType MeasurementType { get; }
    }
}