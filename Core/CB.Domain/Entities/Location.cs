namespace CB.Domain.Entities
{
    public class Location
    {
        public int LocationId { get; set; }
        public string Name { get; set; }
        public List<RentACar> RentACars { get; set; }
        public List<Reservation> PickUpReservations { get; set; }
        public List<Reservation> DropOffReservations { get; set; }
    }
}
