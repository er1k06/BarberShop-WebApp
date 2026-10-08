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
                Age=25,
                Experience=5,
                ShopId=1,
                ImageUrl="/images/barbers/John-Doe.png"
            },
            new Barber()
            {
                Id=2,
                FirstName="Jane",
                LastName="Smith",
                 Age=25,
                Experience=3,
                ShopId=8,
                ImageUrl="/images/barbers/Jane-Smith.png"
            },
            new Barber()
            {
                Id=3,
                FirstName="Mike",
                LastName="Johnson",
                 Age=29,
                Experience=7,
                ShopId=3,
                ImageUrl="/images/barbers/Mike-Johnson.png"
            },
            new Barber()
            {
                Id=4,
                FirstName="Emily",
                LastName="Davis",
                 Age=28,
                Experience=4,
                ShopId=4,
                ImageUrl="/images/barbers/Emily-Davis.png"
            },
            new Barber()
            {
                Id=5,
                FirstName="David",
                LastName="Wilson",
                 Age=34,
                Experience=6,
                ShopId=5,
                ImageUrl="/images/barbers/David-Wilson.png"
            },
            new Barber()
            {
                Id=6,
                FirstName="Stoyan",
                LastName="Stanislavov",
                 Age=22,
                Experience=5,
                ShopId=1,
                ImageUrl="/images/barbers/Stoyan-Stanislavov.png"
            },
            new Barber()
            {
                Id=7,
                FirstName="Anna",
                LastName="Boneva",
                 Age=18,
                Experience=3,
                ShopId=2,
                ImageUrl="/images/barbers/Anna-Boneva.png"
            },
            new Barber()
            {
                Id=8,
                FirstName="Ivan",
                LastName="Petrov",
                 Age=32,
                Experience=7,
                ShopId=3,
                ImageUrl="/images/barbers/Ivan-Petrov.png"
            },
            new Barber()
            {
                Id=9,
                FirstName="Lyubomir",
                LastName="Savov",
                 Age=21,
                Experience=4,
                ShopId=4,
                ImageUrl="/images/barbers/Lyubomir-Savov.png"
            },
            new Barber()
            {
                Id=10,
                FirstName="Denis",
                LastName="Stoilov",
                 Age=30,
                Experience=3,
                ShopId=7,
                ImageUrl="/images/barbers/Demis-Stoilov.png"
            }
        };
        public void Configure(EntityTypeBuilder<Barber> builder)
        {
           builder.HasData(Barbers);
        }
    }
}
