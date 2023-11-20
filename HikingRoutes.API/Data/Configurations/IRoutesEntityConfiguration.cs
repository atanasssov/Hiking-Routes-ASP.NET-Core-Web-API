using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

// Use Aliases
using Route = HikingRoutes.API.Models.Domain.Route;

namespace HikingRoutes.API.Data.Configurations
{
    public class IRoutesEntityConfiguration : IEntityTypeConfiguration<Route>
    {
        public void Configure(EntityTypeBuilder<Route> builder)
        {
            builder.HasData(this.GenerateRoutes());
        }

        private Route[] GenerateRoutes()
        {
            ICollection<Route> routes = new HashSet<Route>();

            Route route;

            route = new Route
            {
                Name = "Екопътека до Преображенския манастир",
                Description = "копътеката започва над стария квартал \"Варуша\" и се изкачва по североизточните склонове на \"Картала\", като колкото по-високо се качва, толкова гледката към старата част на града става по-панорамна и красива. Оттук пътеката се спуска през местност наречена \"Зелени дол\", за да достигне до красив водопад. След водопада се продължава в подножието на западния скален венец на прохода Дервент, през който река Янтра напуска Търново и се отправя в северна посока към Дунавската равнина, за да се достигне до манастира. Това е добра възможност за разходка сред природата, комбинирана с посещение на Преображенския манастир, чрез която да се разтоварите и заредите с положителни емоции.",
                LengthInKm = 3,
                WalkImageUrl = "https://www.bestplacesinbulgaria.com/wp-content/uploads/2017/01/preobrajenski-monastery-stara-planina-mountain-tourist-eco-route-04.jpg",
                DifficultyId = Guid.Parse("CFDB74D0-8EF8-43BA-81A5-CC6D5FE36270"),
                RegionId = Guid.Parse("F9F73085-0059-4837-85E2-6995D0656B82")
                
            };
            routes.Add(route);

            route = new Route
            {
                Name = "Хайдушка пътека гр.Сливен ",
                Description = "Маршрутът е с историческа и биологична насоченост и с продължителност около 2 ч. 30 м.\r\nНачалото на Хайдушката пътека е до Информационно-Посетителския център на парка. По маркирана пътека след около 2 часа се достига до Туристически комплекс Карандила. Поема се на север по асфалтов път и след 30 минути се достига извора Кушбунар, разположен във вековна букова гора, която е обявена за природна забележителност.",
                LengthInKm = 6,
                WalkImageUrl = "https://tripsjournal.com/wp-content/uploads/2016/03/kym-ravninata.jpg",
                DifficultyId = Guid.Parse("777C4644-A5F7-42A5-A086-44ECD5ECE1CE"),
                RegionId = Guid.Parse("81AD011C-60F0-4969-90DB-219E3E2A5728")

            };
            routes.Add(route);

            route = new Route
            {
                Name = "Екопътека „Поглед към девет планини“ ",
                Description = "Този туристически маршрут води началото си от село Сирищник и води до изкачване на най-високия връх на планина Рудини – връх Сирищнишка рудина. Името на екопътека „Поглед към девет планини“, както можете да се досетите, идва от зашеметяващата гледка във всички посоки от вишката, изградена на върха. Указателна табела ще ви насочи накъде какво виждате, но лично според мен се виждат повече от 9 планини. По пътя нагоре ще минете по горска пътека, покрай един малък параклис, по виещо дървено стълбище, ще поставите и своя камък в интересната мозайка „Окото“, след което ще изкачите и връх Сирищнишка рудина. ",
                LengthInKm = 6,
                WalkImageUrl = "https://tripsjournal.com/wp-content/uploads/2016/03/po-stylbite-nadolu-300x169.jpg",
                DifficultyId = Guid.Parse("CFDB74D0-8EF8-43BA-81A5-CC6D5FE36270"),
                RegionId = Guid.Parse("6ED072FF-7D65-4288-851B-0D7669060CE9")

            };
            routes.Add(route);

            route = new Route
            {
                Name = "Екопътека Чернелка",
                Description = "До екопътеката може да стигнете лесно от Плевен в посока Ловеч, преминавайки през селата Брестовец и Тодорово и Горталово. Освен, че ще се озовете в пълен унисон с природата, в мястото са изградени много барбекюта, беседки и места за отдих.",
                LengthInKm = 7,
                WalkImageUrl = "https://www.360mag.bg/wp-content/uploads/2020/06/%D0%B5%D0%BA%D0%BE%D0%BF%D1%8A%D1%82%D0%B5%D0%BA%D0%B0-%D1%87%D0%B5%D1%80%D0%BD%D0%B5%D0%BB%D0%BA%D0%B0.jpg",
                DifficultyId = Guid.Parse("B26B0570-CF97-49A6-A74E-ACF6ED6C58D0"),
                RegionId = Guid.Parse("C94159C3-715C-4ED1-8649-6A28130D5563")

            };
            routes.Add(route);

            route = new Route
            {
                Name = "Бяла река",
                Description = "Районът се отличава с красива природа и най-вече със страхотна кухня. Отправяме се на път към екопътека „Бяла река”. Ще стигнете и до бивак Бялата река, от който започва и красивата екопътека. Разкриват се уникални гледки от реката и малки водопади. Тук могат да бъдат видени 11 уникални за района растителни вида. В Национален парк Централен балкан също така има и огромно разнообразие от животински видове, сред които: мечки, вълци, диви кози, царски орли и редица други.",
                LengthInKm = 8,
                WalkImageUrl = "https://trafficnews.bg/data/images/2021_04_28/DSC_0085-800x500.jpg",
                DifficultyId = Guid.Parse("777C4644-A5F7-42A5-A086-44ECD5ECE1CE"),
                RegionId = Guid.Parse("DA1D1365-EE7E-43F5-95F4-90B4EEBAF65C")

            };
            routes.Add(route);



            return routes.ToArray();
        }
    }
}
