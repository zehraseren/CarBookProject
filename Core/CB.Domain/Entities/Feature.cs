namespace CB.Domain.Entities
{
    public class Feature
    {
        public int FeatureId { get; set; }
        public string Name { get; set; }
        public List<CarFeature> CarFeatures { get; set; }
    }
}