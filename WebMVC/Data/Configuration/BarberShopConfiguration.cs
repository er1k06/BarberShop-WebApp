namespace WebMVC.Data.Configuration
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Models;
    public class BarberShopConfiguration: IEntityTypeConfiguration<Shops>
    {
        public static readonly List<Shops>Shops=new List<Shops>()
        {
            new Shops()
            {
                Id=1,
                Location="Sofia",
                Name="BarberShop Sofia"
            },
            new Shops()
            {
                Id=2,
                Location="Plovdiv",
                Name="HeadHunters Plovdiv"
            },
            new Shops()
            {
                Id=3,
                Location="Varna",
                Name="BarberShop Varna"
            },
            new Shops()
            {
                Id=4,
                Location="Sofia",
                Name="BestBarbers"
            },
            new Shops()
            {
                Id=5,
                Location="Plovdiv",
                Name="BlendHouse Plovdiv"
            },
            new Shops()
            {
                Id=6,
                Location="Kalofer",
                Name="KaloferBarbs"
            },
            new Shops()
            {
                Id=7,
                Location="Vidin",
                Name="BlendHouse Vidin"
            },
            new Shops()
            {
                Id=8,
                Location="Smolqn",
                Name="HouseOFBarbers"
            }
        };
        public void Configure(EntityTypeBuilder<Shops> builder)
        {
          builder.HasData(Shops);
        }
    }
}
