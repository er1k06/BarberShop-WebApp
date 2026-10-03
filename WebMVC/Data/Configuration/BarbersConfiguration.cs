namespace WebMVC.Data.Configuration
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Models;
    public class BarbersConfiguration: IEntityTypeConfiguration<Barber>
    {
        public static readonly List<Barber> Barbers = new List<Barber>()
        {
            new Barber()
            {
                Id=1,
                FirstName="John",
                LastName="Doe",
                Experience=5,
                ShopId=1
            },
            new Barber()
            {
                Id=2,
                FirstName="Jane",
                LastName="Smith",
                Experience=3,
                ShopId=8
            },
            new Barber()
            {
                Id=3,
                FirstName="Mike",
                LastName="Johnson",
                Experience=7,
                ShopId=3
            },
            new Barber()
            {
                Id=4,
                FirstName="Emily",
                LastName="Davis",
                Experience=4,
                ShopId=4
            },
            new Barber()
            {
                Id=5,
                FirstName="David",
                LastName="Wilson",
                Experience=6,
                ShopId=5
            },
            new Barber()
            {
                Id=6,
                FirstName="Stoyan",
                LastName="Stanislavov",
                Experience=5,
                ShopId=1
            },
            new Barber()
            {
                Id=7,
                FirstName="Anna",
                LastName="Boneva",
                Experience=3,
                ShopId=2
            },
            new Barber()
            {
                Id=8,
                FirstName="Ivan",
                LastName="Petrov",
                Experience=7,
                ShopId=3
            },
            new Barber()
            {
                Id=9,
                FirstName="Lyubomir",
                LastName="Savov",
                Experience=4,
                ShopId=4
            },
            new Barber()
            {
                Id=10,
                FirstName="Denis",
                LastName="Stoilov",
                Experience=3,
                ShopId=7
            }
        };
        public void Configure(EntityTypeBuilder<Barber> builder)
        {
           builder.HasData(Barbers);
        }
    }
}
