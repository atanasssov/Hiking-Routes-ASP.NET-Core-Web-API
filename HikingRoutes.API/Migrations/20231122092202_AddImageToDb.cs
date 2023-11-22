using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HikingRoutes.API.Migrations
{
    /// <inheritdoc />
    public partial class AddImageToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("9fed6056-25e4-41cc-b5c9-2a0876666ae6"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("a7f416be-0f78-4b45-addd-a1a43762427f"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("b71a2d0d-9a0b-4304-9ba5-1eb32e4138ce"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("0d888ba2-f037-4414-a3da-1ac0c8a36932"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("16f957c9-38f4-412b-9114-3c43a37be938"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("2297cc62-fb63-445f-8d33-ce1e6bde7253"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("50833652-7384-4be5-9443-3a69e97be660"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("652a2535-537b-48bb-b086-27a71ca43e63"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("66af9c30-8a1e-4c81-a287-148ebc2af9f2"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("91778c76-44f2-4ac7-8108-05bedb5372cd"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("bea9e721-0e04-42e6-bc82-5e012855e9ec"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("f0c54f28-6e10-4598-a752-199b5401784b"));

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: new Guid("06f08587-dc1f-426f-86c2-40357d7c139b"));

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: new Guid("7dcd875f-e3c3-4fbb-88c2-9c1a2c1b02dc"));

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: new Guid("832ede53-1886-469a-a547-a82c05caee2a"));

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: new Guid("b1187cee-242a-44df-908f-2f58a77d979c"));

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: new Guid("b303934a-37a1-4963-ba00-ce9b4cbd960a"));

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileExtension = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileSizeInBytes = table.Column<long>(type: "bigint", nullable: false),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Difficulties",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("03c07831-a1b8-4c21-a0fa-9e6863b52d78"), "Hard" },
                    { new Guid("c3a0f1c8-f644-453d-a9c4-d53750520403"), "Easy" },
                    { new Guid("fbb653dd-0c02-4c7a-a277-9846582b0d43"), "Medium" }
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "Code", "Name", "RegionImageUrl" },
                values: new object[,]
                {
                    { new Guid("36e730e3-9fd3-4e26-a3a5-b309f8bc905e"), "SLI", "Sliven", "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0d/Sliven_in_Bulgaria.svg/1024px-Sliven_in_Bulgaria.svg.png" },
                    { new Guid("3991c94d-50b8-46e5-95a9-53d370465e64"), "YAM", "Yambol", "https://upload.wikimedia.org/wikipedia/commons/thumb/0/07/Yambol_in_Bulgaria.svg/1024px-Yambol_in_Bulgaria.svg.png" },
                    { new Guid("77d19644-9d06-4e04-8f6d-58e517be099e"), "SIL", "Silistra", "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c5/Silistra_in_Bulgaria.svg/1024px-Silistra_in_Bulgaria.svg.png" },
                    { new Guid("7a01be64-d17c-4a93-840d-35a3f9628be8"), "VID", "Vidin", "https://upload.wikimedia.org/wikipedia/commons/thumb/0/07/Yambol_in_Bulgaria.svg/1024px-Yambol_in_Bulgaria.svg.png" },
                    { new Guid("84432c3b-5fc4-4221-893f-b6da1f2401ba"), "PLO", "Plovdiv", "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fa/Plovdiv_in_Bulgaria.svg/250px-Plovdiv_in_Bulgaria.svg.png" },
                    { new Guid("92c378ae-a009-425b-bc0b-349d244cfe5a"), "PLE", "Pleven", "https://upload.wikimedia.org/wikipedia/commons/thumb/9/98/Pleven_in_Bulgaria.svg/1024px-Pleven_in_Bulgaria.svg.png" },
                    { new Guid("b773f4db-156c-4e91-8ffd-353b13d76f4d"), "SOF", "Sofia", "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f6/Sofia_%28province%29_in_Bulgaria.svg/1024px-Sofia_%28province%29_in_Bulgaria.svg.png" },
                    { new Guid("b7ab3f98-2aa3-4ba2-81fe-780d35bc99b7"), "BUR", "Burgas", "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b8/Burgas_in_Bulgaria.svg/1024px-Burgas_in_Bulgaria.svg.png" },
                    { new Guid("ca3ab1ea-cebb-48ee-8f37-fde0bdfdba87"), "VAR", "Varna", "https://upload.wikimedia.org/wikipedia/commons/thumb/c/cb/Varna_in_Bulgaria.svg/1024px-Varna_in_Bulgaria.svg.png" }
                });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "Id", "Description", "DifficultyId", "LengthInKm", "Name", "RegionId", "WalkImageUrl" },
                values: new object[,]
                {
                    { new Guid("67d94a05-1e5a-4e18-959a-139e7fa9b5a6"), "копътеката започва над стария квартал \"Варуша\" и се изкачва по североизточните склонове на \"Картала\", като колкото по-високо се качва, толкова гледката към старата част на града става по-панорамна и красива. Оттук пътеката се спуска през местност наречена \"Зелени дол\", за да достигне до красив водопад. След водопада се продължава в подножието на западния скален венец на прохода Дервент, през който река Янтра напуска Търново и се отправя в северна посока към Дунавската равнина, за да се достигне до манастира. Това е добра възможност за разходка сред природата, комбинирана с посещение на Преображенския манастир, чрез която да се разтоварите и заредите с положителни емоции.", new Guid("cfdb74d0-8ef8-43ba-81a5-cc6d5fe36270"), 3.0, "Екопътека до Преображенския манастир", new Guid("f9f73085-0059-4837-85e2-6995d0656b82"), "https://www.bestplacesinbulgaria.com/wp-content/uploads/2017/01/preobrajenski-monastery-stara-planina-mountain-tourist-eco-route-04.jpg" },
                    { new Guid("a5cc779b-eb65-440b-b8be-eef597b4028d"), "Районът се отличава с красива природа и най-вече със страхотна кухня. Отправяме се на път към екопътека „Бяла река”. Ще стигнете и до бивак Бялата река, от който започва и красивата екопътека. Разкриват се уникални гледки от реката и малки водопади. Тук могат да бъдат видени 11 уникални за района растителни вида. В Национален парк Централен балкан също така има и огромно разнообразие от животински видове, сред които: мечки, вълци, диви кози, царски орли и редица други.", new Guid("777c4644-a5f7-42a5-a086-44ecd5ece1ce"), 8.0, "Бяла река", new Guid("da1d1365-ee7e-43f5-95f4-90b4eebaf65c"), "https://trafficnews.bg/data/images/2021_04_28/DSC_0085-800x500.jpg" },
                    { new Guid("bb095271-2688-4d0f-9966-e34e6a0e5b89"), "Този туристически маршрут води началото си от село Сирищник и води до изкачване на най-високия връх на планина Рудини – връх Сирищнишка рудина. Името на екопътека „Поглед към девет планини“, както можете да се досетите, идва от зашеметяващата гледка във всички посоки от вишката, изградена на върха. Указателна табела ще ви насочи накъде какво виждате, но лично според мен се виждат повече от 9 планини. По пътя нагоре ще минете по горска пътека, покрай един малък параклис, по виещо дървено стълбище, ще поставите и своя камък в интересната мозайка „Окото“, след което ще изкачите и връх Сирищнишка рудина. ", new Guid("cfdb74d0-8ef8-43ba-81a5-cc6d5fe36270"), 6.0, "Екопътека „Поглед към девет планини“ ", new Guid("6ed072ff-7d65-4288-851b-0d7669060ce9"), "https://tripsjournal.com/wp-content/uploads/2016/03/po-stylbite-nadolu-300x169.jpg" },
                    { new Guid("fea521ac-df1b-4943-b6b8-9fda31bce2f6"), "Маршрутът е с историческа и биологична насоченост и с продължителност около 2 ч. 30 м.\r\nНачалото на Хайдушката пътека е до Информационно-Посетителския център на парка. По маркирана пътека след около 2 часа се достига до Туристически комплекс Карандила. Поема се на север по асфалтов път и след 30 минути се достига извора Кушбунар, разположен във вековна букова гора, която е обявена за природна забележителност.", new Guid("777c4644-a5f7-42a5-a086-44ecd5ece1ce"), 6.0, "Хайдушка пътека гр.Сливен ", new Guid("81ad011c-60f0-4969-90db-219e3e2a5728"), "https://tripsjournal.com/wp-content/uploads/2016/03/kym-ravninata.jpg" },
                    { new Guid("ffb9035d-3c37-441d-abd8-509d3367d107"), "До екопътеката може да стигнете лесно от Плевен в посока Ловеч, преминавайки през селата Брестовец и Тодорово и Горталово. Освен, че ще се озовете в пълен унисон с природата, в мястото са изградени много барбекюта, беседки и места за отдих.", new Guid("b26b0570-cf97-49a6-a74e-acf6ed6c58d0"), 7.0, "Екопътека Чернелка", new Guid("c94159c3-715c-4ed1-8649-6a28130d5563"), "https://www.360mag.bg/wp-content/uploads/2020/06/%D0%B5%D0%BA%D0%BE%D0%BF%D1%8A%D1%82%D0%B5%D0%BA%D0%B0-%D1%87%D0%B5%D1%80%D0%BD%D0%B5%D0%BB%D0%BA%D0%B0.jpg" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("03c07831-a1b8-4c21-a0fa-9e6863b52d78"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("c3a0f1c8-f644-453d-a9c4-d53750520403"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("fbb653dd-0c02-4c7a-a277-9846582b0d43"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("36e730e3-9fd3-4e26-a3a5-b309f8bc905e"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("3991c94d-50b8-46e5-95a9-53d370465e64"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("77d19644-9d06-4e04-8f6d-58e517be099e"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("7a01be64-d17c-4a93-840d-35a3f9628be8"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("84432c3b-5fc4-4221-893f-b6da1f2401ba"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("92c378ae-a009-425b-bc0b-349d244cfe5a"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("b773f4db-156c-4e91-8ffd-353b13d76f4d"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("b7ab3f98-2aa3-4ba2-81fe-780d35bc99b7"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("ca3ab1ea-cebb-48ee-8f37-fde0bdfdba87"));

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: new Guid("67d94a05-1e5a-4e18-959a-139e7fa9b5a6"));

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: new Guid("a5cc779b-eb65-440b-b8be-eef597b4028d"));

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: new Guid("bb095271-2688-4d0f-9966-e34e6a0e5b89"));

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: new Guid("fea521ac-df1b-4943-b6b8-9fda31bce2f6"));

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: new Guid("ffb9035d-3c37-441d-abd8-509d3367d107"));

            migrationBuilder.InsertData(
                table: "Difficulties",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("9fed6056-25e4-41cc-b5c9-2a0876666ae6"), "Medium" },
                    { new Guid("a7f416be-0f78-4b45-addd-a1a43762427f"), "Easy" },
                    { new Guid("b71a2d0d-9a0b-4304-9ba5-1eb32e4138ce"), "Hard" }
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "Code", "Name", "RegionImageUrl" },
                values: new object[,]
                {
                    { new Guid("0d888ba2-f037-4414-a3da-1ac0c8a36932"), "VID", "Vidin", "https://upload.wikimedia.org/wikipedia/commons/thumb/0/07/Yambol_in_Bulgaria.svg/1024px-Yambol_in_Bulgaria.svg.png" },
                    { new Guid("16f957c9-38f4-412b-9114-3c43a37be938"), "PLE", "Pleven", "https://upload.wikimedia.org/wikipedia/commons/thumb/9/98/Pleven_in_Bulgaria.svg/1024px-Pleven_in_Bulgaria.svg.png" },
                    { new Guid("2297cc62-fb63-445f-8d33-ce1e6bde7253"), "PLO", "Plovdiv", "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fa/Plovdiv_in_Bulgaria.svg/250px-Plovdiv_in_Bulgaria.svg.png" },
                    { new Guid("50833652-7384-4be5-9443-3a69e97be660"), "VAR", "Varna", "https://upload.wikimedia.org/wikipedia/commons/thumb/c/cb/Varna_in_Bulgaria.svg/1024px-Varna_in_Bulgaria.svg.png" },
                    { new Guid("652a2535-537b-48bb-b086-27a71ca43e63"), "BUR", "Burgas", "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b8/Burgas_in_Bulgaria.svg/1024px-Burgas_in_Bulgaria.svg.png" },
                    { new Guid("66af9c30-8a1e-4c81-a287-148ebc2af9f2"), "YAM", "Yambol", "https://upload.wikimedia.org/wikipedia/commons/thumb/0/07/Yambol_in_Bulgaria.svg/1024px-Yambol_in_Bulgaria.svg.png" },
                    { new Guid("91778c76-44f2-4ac7-8108-05bedb5372cd"), "SLI", "Sliven", "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0d/Sliven_in_Bulgaria.svg/1024px-Sliven_in_Bulgaria.svg.png" },
                    { new Guid("bea9e721-0e04-42e6-bc82-5e012855e9ec"), "SOF", "Sofia", "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f6/Sofia_%28province%29_in_Bulgaria.svg/1024px-Sofia_%28province%29_in_Bulgaria.svg.png" },
                    { new Guid("f0c54f28-6e10-4598-a752-199b5401784b"), "SIL", "Silistra", "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c5/Silistra_in_Bulgaria.svg/1024px-Silistra_in_Bulgaria.svg.png" }
                });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "Id", "Description", "DifficultyId", "LengthInKm", "Name", "RegionId", "WalkImageUrl" },
                values: new object[,]
                {
                    { new Guid("06f08587-dc1f-426f-86c2-40357d7c139b"), "копътеката започва над стария квартал \"Варуша\" и се изкачва по североизточните склонове на \"Картала\", като колкото по-високо се качва, толкова гледката към старата част на града става по-панорамна и красива. Оттук пътеката се спуска през местност наречена \"Зелени дол\", за да достигне до красив водопад. След водопада се продължава в подножието на западния скален венец на прохода Дервент, през който река Янтра напуска Търново и се отправя в северна посока към Дунавската равнина, за да се достигне до манастира. Това е добра възможност за разходка сред природата, комбинирана с посещение на Преображенския манастир, чрез която да се разтоварите и заредите с положителни емоции.", new Guid("cfdb74d0-8ef8-43ba-81a5-cc6d5fe36270"), 3.0, "Екопътека до Преображенския манастир", new Guid("f9f73085-0059-4837-85e2-6995d0656b82"), "https://www.bestplacesinbulgaria.com/wp-content/uploads/2017/01/preobrajenski-monastery-stara-planina-mountain-tourist-eco-route-04.jpg" },
                    { new Guid("7dcd875f-e3c3-4fbb-88c2-9c1a2c1b02dc"), "Маршрутът е с историческа и биологична насоченост и с продължителност около 2 ч. 30 м.\r\nНачалото на Хайдушката пътека е до Информационно-Посетителския център на парка. По маркирана пътека след около 2 часа се достига до Туристически комплекс Карандила. Поема се на север по асфалтов път и след 30 минути се достига извора Кушбунар, разположен във вековна букова гора, която е обявена за природна забележителност.", new Guid("777c4644-a5f7-42a5-a086-44ecd5ece1ce"), 6.0, "Хайдушка пътека гр.Сливен ", new Guid("81ad011c-60f0-4969-90db-219e3e2a5728"), "https://tripsjournal.com/wp-content/uploads/2016/03/kym-ravninata.jpg" },
                    { new Guid("832ede53-1886-469a-a547-a82c05caee2a"), "Районът се отличава с красива природа и най-вече със страхотна кухня. Отправяме се на път към екопътека „Бяла река”. Ще стигнете и до бивак Бялата река, от който започва и красивата екопътека. Разкриват се уникални гледки от реката и малки водопади. Тук могат да бъдат видени 11 уникални за района растителни вида. В Национален парк Централен балкан също така има и огромно разнообразие от животински видове, сред които: мечки, вълци, диви кози, царски орли и редица други.", new Guid("777c4644-a5f7-42a5-a086-44ecd5ece1ce"), 8.0, "Бяла река", new Guid("da1d1365-ee7e-43f5-95f4-90b4eebaf65c"), "https://trafficnews.bg/data/images/2021_04_28/DSC_0085-800x500.jpg" },
                    { new Guid("b1187cee-242a-44df-908f-2f58a77d979c"), "До екопътеката може да стигнете лесно от Плевен в посока Ловеч, преминавайки през селата Брестовец и Тодорово и Горталово. Освен, че ще се озовете в пълен унисон с природата, в мястото са изградени много барбекюта, беседки и места за отдих.", new Guid("b26b0570-cf97-49a6-a74e-acf6ed6c58d0"), 7.0, "Екопътека Чернелка", new Guid("c94159c3-715c-4ed1-8649-6a28130d5563"), "https://www.360mag.bg/wp-content/uploads/2020/06/%D0%B5%D0%BA%D0%BE%D0%BF%D1%8A%D1%82%D0%B5%D0%BA%D0%B0-%D1%87%D0%B5%D1%80%D0%BD%D0%B5%D0%BB%D0%BA%D0%B0.jpg" },
                    { new Guid("b303934a-37a1-4963-ba00-ce9b4cbd960a"), "Този туристически маршрут води началото си от село Сирищник и води до изкачване на най-високия връх на планина Рудини – връх Сирищнишка рудина. Името на екопътека „Поглед към девет планини“, както можете да се досетите, идва от зашеметяващата гледка във всички посоки от вишката, изградена на върха. Указателна табела ще ви насочи накъде какво виждате, но лично според мен се виждат повече от 9 планини. По пътя нагоре ще минете по горска пътека, покрай един малък параклис, по виещо дървено стълбище, ще поставите и своя камък в интересната мозайка „Окото“, след което ще изкачите и връх Сирищнишка рудина. ", new Guid("cfdb74d0-8ef8-43ba-81a5-cc6d5fe36270"), 6.0, "Екопътека „Поглед към девет планини“ ", new Guid("6ed072ff-7d65-4288-851b-0d7669060ce9"), "https://tripsjournal.com/wp-content/uploads/2016/03/po-stylbite-nadolu-300x169.jpg" }
                });
        }
    }
}
