namespace CB.Domain.Entities
{
    public class Reservation
    {
        public int ReservationId { get; set; }
        public int CarId { get; set; }
        public Car Car { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int Age { get; set; }
        public int DrivingLicenseAge { get; set; }
        public int? PickUpLocationId { get; set; }
        public Location PickUpLocation { get; set; }
        public int? DropOffLocationId { get; set; }
        public Location DropOffLocation { get; set; }
        public string? Description { get; set; }
        public string Status { get; set; }
    }
}
