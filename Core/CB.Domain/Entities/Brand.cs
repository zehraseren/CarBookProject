namespace CB.Domain.Entities
{
    public class Brand
    {
        public int BrandId { get; set; }
        public string Name { get; set; }
        public List<Car> Cars { get; set; }
    }
}