namespace CB.Domain.Entities
{
    public class CarFeature
    {
        public int CarFeatureId { get; set; }
        public int CarId { get; set; }
        public Car Car { get; set; }
        public int FeatureId { get; set; }
        public Feature Feature { get; set; }
        public bool Available { get; set; }
    }
}