namespace WebMVC.Common
{
    public static class EntityValidation
    {
        public static class Barber
        {
            /* Barber Begin */
            public const int BarberMinAge = 18;
            public const int BarberMaxAge = 65;

            public const int BarberFirstNameMinLength = 2;
            public const int BarberFirstNameMaxLength = 50;

            public const int BarberLastNameMinLength = 2;
            public const int BarberLastNameMaxLength = 50;
            /* Barber End */
        }

        public static class Shop
        {
            /* Shop Begin */
            public const int ShopLocationMinLength = 2;
            public const int ShopLocationMaxLength = 56;

            public const int ShopNameMinLength = 2;
            public const int ShopNameMaxLength = 100;
            /* Shop End */
        }
    }
}
