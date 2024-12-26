using CB.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CB.Persistence.Context
{
    public class CarBookContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=Zehra;initial catalog=CarBookDb;integrated security=true;TrustServerCertificate=True");
        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarDescription> CarDescriptions { get; set; }
        public DbSet<CarFeature> CarFeatures { get; set; }
        public DbSet<CarPricing> CarPricings { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<FooterAddress> FooterAddresses { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Pricing> Pricings { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<TagCloud> TagClouds { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<RentACar> RentACars { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CarPricing>()
                .Property(p => p.Price)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<RentACarProcess>()
                .Property(p => p.TotalPrice)
                .HasColumnType("decimal(18,2)");

            // Reservation entity'si için aşağıdaki gibi yapılandırma yapılır. Burada amaç bir tablo içerisinde iki farklı ID'yi karşı tarafın tek ID'si ile birleştirmek.
            modelBuilder.Entity<Reservation>()
                // Reservation entity'sinde bulunan DropOffLocation navigation property’si tanımlanır.
                .HasOne(x => x.PickUpLocation)
                // Location entity'sinin birden fazla Reservation ile ilişkilendirilebileceğini belirtilir.
                .WithMany(y => y.PickUpReservations)
                // Reservation tablosunda DropOffLocationId isimli bir foreign key olduğunu tanımlanır.
                .HasForeignKey(z => z.PickUpLocationId)
                // PickUpLocationId silindiğinde, ilgili Reservation kayıtlarında PickUpLocationId değerinin NULL olmasını sağlanır. (Cascade delete uygulanmıyor).
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Reservation>()
                .HasOne(x => x.DropOffLocation)
                .WithMany(y => y.DropOffReservations)
                .HasForeignKey(z => z.DropOffLocationId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            base.OnModelCreating(modelBuilder);
        }
    }
}
