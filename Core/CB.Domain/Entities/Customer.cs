namespace CB.Domain.Entities
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public List<RentACarProcess> RentACarProcesses { get; set; }
    }
}
