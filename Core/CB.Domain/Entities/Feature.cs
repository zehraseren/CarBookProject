namespace CB.Domain.Entities
{
    public class Feature
    {
        public int FeatureId { get; set; }
        public int Name { get; set; }
        public List<CarFeature> CarFeatures { get; set; }
    }
}