namespace HikingRoutes.API.Common
{
    public static class EntityVlidationConstants
    {
        public static class Difficulty
        {
            public const int NameMinLength = 2;
            public const int NameMaxLength = 30;
        }

        public static class Region
        {
            public const int CodeMinLength = 2;
            public const int CodeMaxLength = 5;

            public const int NameMinLength = 2;
            public const int NameMaxLength = 20;
            
            public const int ImageUrlMaxLength = 2048;
        }

        public static class Route
        {
            public const int NameMinLength = 3;
            public const int NameMaxLength = 50;

            public const int DescriptionMinLength = 10;
            public const int DescriptionMaxLength = 1000;

            public const double LengthInKmMinValue = 0.1;
            public const double LengthInKmMaxValue = 200;

            public const int ImageUrlMaxLength = 2048;

        }
    }
}
