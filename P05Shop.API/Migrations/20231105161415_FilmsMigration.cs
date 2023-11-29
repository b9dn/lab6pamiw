using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace P05Shop.API.Migrations
{
    /// <inheritdoc />
    public partial class FilmsMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Films",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Barcode = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Films", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "Id", "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 1, "2", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 684.749356917454m, new DateTime(2022, 11, 24, 20, 43, 45, 338, DateTimeKind.Local).AddTicks(7225), "id" },
                    { 2, "9", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 422.47245453972m, new DateTime(2023, 10, 13, 14, 18, 23, 926, DateTimeKind.Local).AddTicks(8307), "harum" },
                    { 3, "0", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 167.353470278137m, new DateTime(2023, 9, 27, 9, 41, 12, 447, DateTimeKind.Local).AddTicks(4145), "sint" },
                    { 4, "3", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 191.892937769598m, new DateTime(2023, 10, 8, 2, 57, 13, 168, DateTimeKind.Local).AddTicks(2196), "architecto" },
                    { 5, "6", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 924.811805119185m, new DateTime(2022, 12, 15, 18, 13, 5, 493, DateTimeKind.Local).AddTicks(3640), "vero" },
                    { 6, "9", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 711.89268854302m, new DateTime(2023, 8, 26, 0, 46, 30, 434, DateTimeKind.Local).AddTicks(5049), "beatae" },
                    { 7, "5", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 947.7514453138m, new DateTime(2023, 7, 27, 21, 33, 58, 645, DateTimeKind.Local).AddTicks(7417), "eos" },
                    { 8, "7", "The Football Is Good For Training And Recreational Purposes", 22.1707296390881m, new DateTime(2023, 6, 18, 4, 51, 10, 639, DateTimeKind.Local).AddTicks(2606), "quidem" },
                    { 9, "0", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 746.682940297147m, new DateTime(2022, 11, 6, 13, 20, 46, 274, DateTimeKind.Local).AddTicks(6009), "laboriosam" },
                    { 10, "0", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 213.803320546077m, new DateTime(2023, 11, 2, 12, 1, 29, 733, DateTimeKind.Local).AddTicks(8351), "id" },
                    { 11, "2", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 86.1426076619619m, new DateTime(2023, 3, 31, 14, 30, 1, 481, DateTimeKind.Local).AddTicks(4005), "atque" },
                    { 12, "2", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 759.985418102232m, new DateTime(2023, 6, 7, 7, 12, 44, 986, DateTimeKind.Local).AddTicks(1615), "dolorum" },
                    { 13, "3", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 538.52330437001m, new DateTime(2023, 3, 31, 23, 53, 5, 451, DateTimeKind.Local).AddTicks(4650), "eaque" },
                    { 14, "5", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 57.2601207887102m, new DateTime(2022, 12, 4, 22, 39, 20, 471, DateTimeKind.Local).AddTicks(4034), "illum" },
                    { 15, "1", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 495.122995184326m, new DateTime(2023, 3, 12, 0, 11, 3, 114, DateTimeKind.Local).AddTicks(5080), "veritatis" },
                    { 16, "8", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 223.045942151475m, new DateTime(2022, 11, 17, 21, 24, 11, 344, DateTimeKind.Local).AddTicks(1476), "vero" },
                    { 17, "0", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 476.815506478686m, new DateTime(2023, 3, 16, 20, 31, 21, 374, DateTimeKind.Local).AddTicks(2981), "et" },
                    { 18, "5", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 733.06374986659m, new DateTime(2023, 9, 28, 17, 31, 7, 713, DateTimeKind.Local).AddTicks(4970), "maxime" },
                    { 19, "9", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 254.120942065549m, new DateTime(2023, 7, 10, 15, 53, 51, 126, DateTimeKind.Local).AddTicks(9696), "eum" },
                    { 20, "9", "The Football Is Good For Training And Recreational Purposes", 475.062068794883m, new DateTime(2023, 7, 26, 21, 45, 1, 132, DateTimeKind.Local).AddTicks(1099), "ut" },
                    { 21, "9", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 970.636928829196m, new DateTime(2023, 3, 17, 22, 9, 10, 817, DateTimeKind.Local).AddTicks(9537), "asperiores" },
                    { 22, "2", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 375.314507679695m, new DateTime(2022, 12, 26, 13, 51, 0, 675, DateTimeKind.Local).AddTicks(9846), "corrupti" },
                    { 23, "5", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 751.959149548299m, new DateTime(2023, 4, 22, 9, 20, 32, 583, DateTimeKind.Local).AddTicks(3944), "facere" },
                    { 24, "1", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 155.456089345951m, new DateTime(2023, 10, 1, 10, 55, 55, 625, DateTimeKind.Local).AddTicks(2204), "aut" },
                    { 25, "6", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 768.439640581347m, new DateTime(2023, 9, 23, 19, 52, 53, 851, DateTimeKind.Local).AddTicks(8555), "sint" },
                    { 26, "1", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 985.158759732339m, new DateTime(2023, 1, 14, 14, 54, 18, 843, DateTimeKind.Local).AddTicks(7717), "voluptates" },
                    { 27, "6", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 639.781882750234m, new DateTime(2023, 8, 10, 12, 31, 25, 84, DateTimeKind.Local).AddTicks(3608), "velit" },
                    { 28, "8", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 677.955690698212m, new DateTime(2023, 10, 5, 1, 3, 2, 931, DateTimeKind.Local).AddTicks(9058), "commodi" },
                    { 29, "6", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 376.795993395986m, new DateTime(2023, 8, 20, 16, 11, 12, 645, DateTimeKind.Local).AddTicks(5122), "voluptas" },
                    { 30, "5", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 943.967606426202m, new DateTime(2023, 10, 17, 22, 30, 10, 476, DateTimeKind.Local).AddTicks(869), "fugit" },
                    { 31, "1", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 64.2255390939422m, new DateTime(2023, 5, 2, 2, 54, 18, 235, DateTimeKind.Local).AddTicks(5616), "dolores" },
                    { 32, "2", "The Football Is Good For Training And Recreational Purposes", 742.460550793195m, new DateTime(2023, 3, 9, 0, 43, 50, 616, DateTimeKind.Local).AddTicks(5014), "enim" },
                    { 33, "6", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 297.553123664368m, new DateTime(2023, 5, 29, 13, 36, 9, 503, DateTimeKind.Local).AddTicks(3024), "ut" },
                    { 34, "5", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 147.49753606296m, new DateTime(2023, 7, 9, 14, 4, 29, 956, DateTimeKind.Local).AddTicks(6856), "sint" },
                    { 35, "8", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 89.1345175188661m, new DateTime(2023, 5, 24, 7, 44, 40, 345, DateTimeKind.Local).AddTicks(1086), "distinctio" },
                    { 36, "2", "The Football Is Good For Training And Recreational Purposes", 816.517572267688m, new DateTime(2023, 8, 25, 14, 57, 44, 470, DateTimeKind.Local).AddTicks(8913), "corrupti" },
                    { 37, "5", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 72.624582859047m, new DateTime(2023, 10, 4, 20, 21, 57, 952, DateTimeKind.Local).AddTicks(7936), "ipsum" },
                    { 38, "6", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 29.9763303217368m, new DateTime(2023, 6, 22, 22, 51, 7, 364, DateTimeKind.Local).AddTicks(6486), "quod" },
                    { 39, "8", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 800.322248479501m, new DateTime(2023, 7, 31, 11, 48, 37, 225, DateTimeKind.Local).AddTicks(4624), "culpa" },
                    { 40, "0", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 615.200972841215m, new DateTime(2023, 9, 12, 16, 53, 12, 264, DateTimeKind.Local).AddTicks(9125), "ut" },
                    { 41, "1", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 928.988735241344m, new DateTime(2023, 1, 25, 11, 13, 54, 90, DateTimeKind.Local).AddTicks(2764), "exercitationem" },
                    { 42, "3", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 388.689203849383m, new DateTime(2023, 7, 15, 6, 16, 16, 195, DateTimeKind.Local).AddTicks(7029), "et" },
                    { 43, "1", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 502.611870216025m, new DateTime(2023, 4, 21, 4, 6, 46, 716, DateTimeKind.Local).AddTicks(174), "qui" },
                    { 44, "9", "The Football Is Good For Training And Recreational Purposes", 645.556666344198m, new DateTime(2023, 7, 1, 22, 28, 36, 283, DateTimeKind.Local).AddTicks(5606), "ratione" },
                    { 45, "3", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 619.502076236299m, new DateTime(2023, 9, 24, 16, 57, 42, 836, DateTimeKind.Local).AddTicks(4222), "facere" },
                    { 46, "9", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 424.687753792707m, new DateTime(2023, 8, 3, 8, 48, 38, 254, DateTimeKind.Local).AddTicks(6432), "consectetur" },
                    { 47, "4", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 310.46256466278m, new DateTime(2023, 2, 5, 13, 8, 56, 198, DateTimeKind.Local).AddTicks(4262), "delectus" },
                    { 48, "5", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 241.00351070706m, new DateTime(2023, 2, 12, 18, 45, 35, 33, DateTimeKind.Local).AddTicks(3972), "reprehenderit" },
                    { 49, "2", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 538.22909000061m, new DateTime(2023, 10, 23, 6, 56, 42, 421, DateTimeKind.Local).AddTicks(3517), "est" },
                    { 50, "5", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 531.093987403947m, new DateTime(2023, 5, 28, 7, 33, 24, 825, DateTimeKind.Local).AddTicks(4626), "voluptatem" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReleaseDate",
                value: new DateTime(2023, 3, 19, 22, 34, 14, 735, DateTimeKind.Local).AddTicks(5145));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReleaseDate",
                value: new DateTime(2023, 9, 29, 19, 12, 48, 371, DateTimeKind.Local).AddTicks(7290));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ReleaseDate",
                value: new DateTime(2023, 1, 18, 14, 6, 31, 644, DateTimeKind.Local).AddTicks(9294));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "ReleaseDate",
                value: new DateTime(2023, 8, 20, 2, 20, 2, 4, DateTimeKind.Local).AddTicks(666));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "ReleaseDate",
                value: new DateTime(2023, 2, 20, 3, 38, 13, 733, DateTimeKind.Local).AddTicks(6842));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "ReleaseDate",
                value: new DateTime(2023, 9, 3, 15, 25, 46, 843, DateTimeKind.Local).AddTicks(4161));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "ReleaseDate",
                value: new DateTime(2023, 4, 4, 14, 37, 59, 253, DateTimeKind.Local).AddTicks(4208));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "ReleaseDate",
                value: new DateTime(2023, 6, 28, 5, 52, 26, 941, DateTimeKind.Local).AddTicks(6428));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "ReleaseDate",
                value: new DateTime(2022, 12, 17, 21, 51, 42, 398, DateTimeKind.Local).AddTicks(3892));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "ReleaseDate",
                value: new DateTime(2023, 10, 9, 13, 33, 51, 859, DateTimeKind.Local).AddTicks(6543));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "ReleaseDate",
                value: new DateTime(2023, 8, 8, 6, 47, 56, 1, DateTimeKind.Local).AddTicks(3703));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "ReleaseDate",
                value: new DateTime(2023, 8, 16, 11, 19, 52, 775, DateTimeKind.Local).AddTicks(2405));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "ReleaseDate",
                value: new DateTime(2023, 7, 16, 16, 33, 21, 694, DateTimeKind.Local).AddTicks(8407));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "ReleaseDate",
                value: new DateTime(2023, 1, 10, 5, 46, 0, 182, DateTimeKind.Local).AddTicks(4714));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "ReleaseDate",
                value: new DateTime(2023, 7, 31, 22, 51, 53, 212, DateTimeKind.Local).AddTicks(1857));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "ReleaseDate",
                value: new DateTime(2022, 11, 18, 14, 46, 41, 679, DateTimeKind.Local).AddTicks(706));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "ReleaseDate",
                value: new DateTime(2023, 6, 28, 5, 8, 13, 257, DateTimeKind.Local).AddTicks(187));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "ReleaseDate",
                value: new DateTime(2023, 6, 25, 6, 50, 54, 616, DateTimeKind.Local).AddTicks(3236));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "ReleaseDate",
                value: new DateTime(2022, 11, 18, 18, 8, 54, 195, DateTimeKind.Local).AddTicks(6605));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "ReleaseDate",
                value: new DateTime(2023, 4, 11, 19, 39, 38, 677, DateTimeKind.Local).AddTicks(9846));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "ReleaseDate",
                value: new DateTime(2023, 6, 20, 7, 2, 32, 866, DateTimeKind.Local).AddTicks(2219));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "ReleaseDate",
                value: new DateTime(2023, 1, 31, 2, 29, 55, 135, DateTimeKind.Local).AddTicks(9934));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "ReleaseDate",
                value: new DateTime(2023, 6, 1, 20, 20, 2, 454, DateTimeKind.Local).AddTicks(3497));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "ReleaseDate",
                value: new DateTime(2023, 7, 3, 12, 56, 21, 683, DateTimeKind.Local).AddTicks(6661));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "ReleaseDate",
                value: new DateTime(2023, 7, 19, 14, 25, 13, 247, DateTimeKind.Local).AddTicks(3106));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "ReleaseDate",
                value: new DateTime(2023, 5, 14, 8, 1, 33, 370, DateTimeKind.Local).AddTicks(8394));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "ReleaseDate",
                value: new DateTime(2023, 2, 2, 20, 5, 9, 366, DateTimeKind.Local).AddTicks(9966));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "ReleaseDate",
                value: new DateTime(2023, 4, 27, 22, 31, 4, 478, DateTimeKind.Local).AddTicks(5185));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "ReleaseDate",
                value: new DateTime(2023, 7, 21, 9, 1, 58, 471, DateTimeKind.Local).AddTicks(6490));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "ReleaseDate",
                value: new DateTime(2022, 11, 15, 9, 57, 21, 687, DateTimeKind.Local).AddTicks(8274));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "ReleaseDate",
                value: new DateTime(2023, 10, 11, 8, 23, 10, 884, DateTimeKind.Local).AddTicks(6429));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "ReleaseDate",
                value: new DateTime(2023, 7, 22, 4, 10, 36, 823, DateTimeKind.Local).AddTicks(6857));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "ReleaseDate",
                value: new DateTime(2023, 4, 29, 4, 39, 38, 74, DateTimeKind.Local).AddTicks(2767));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "ReleaseDate",
                value: new DateTime(2022, 11, 25, 21, 55, 25, 913, DateTimeKind.Local).AddTicks(361));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "ReleaseDate",
                value: new DateTime(2022, 12, 14, 2, 47, 43, 908, DateTimeKind.Local).AddTicks(36));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "ReleaseDate",
                value: new DateTime(2023, 1, 2, 21, 21, 41, 441, DateTimeKind.Local).AddTicks(1830));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                column: "ReleaseDate",
                value: new DateTime(2023, 3, 31, 12, 54, 54, 836, DateTimeKind.Local).AddTicks(9989));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "ReleaseDate",
                value: new DateTime(2023, 1, 10, 10, 56, 35, 156, DateTimeKind.Local).AddTicks(1360));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                column: "ReleaseDate",
                value: new DateTime(2023, 4, 6, 18, 34, 49, 715, DateTimeKind.Local).AddTicks(6506));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                column: "ReleaseDate",
                value: new DateTime(2023, 6, 24, 15, 21, 6, 339, DateTimeKind.Local).AddTicks(4295));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                column: "ReleaseDate",
                value: new DateTime(2023, 8, 6, 22, 26, 28, 487, DateTimeKind.Local).AddTicks(6344));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                column: "ReleaseDate",
                value: new DateTime(2023, 7, 29, 9, 37, 27, 917, DateTimeKind.Local).AddTicks(1653));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                column: "ReleaseDate",
                value: new DateTime(2023, 1, 21, 1, 23, 41, 473, DateTimeKind.Local).AddTicks(629));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                column: "ReleaseDate",
                value: new DateTime(2023, 1, 24, 23, 4, 6, 631, DateTimeKind.Local).AddTicks(8256));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                column: "ReleaseDate",
                value: new DateTime(2023, 1, 2, 19, 10, 29, 701, DateTimeKind.Local).AddTicks(9773));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                column: "ReleaseDate",
                value: new DateTime(2023, 5, 7, 23, 52, 41, 261, DateTimeKind.Local).AddTicks(3306));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                column: "ReleaseDate",
                value: new DateTime(2023, 1, 10, 18, 52, 15, 563, DateTimeKind.Local).AddTicks(6448));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                column: "ReleaseDate",
                value: new DateTime(2023, 2, 22, 15, 44, 32, 989, DateTimeKind.Local).AddTicks(6082));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                column: "ReleaseDate",
                value: new DateTime(2023, 4, 7, 20, 26, 36, 591, DateTimeKind.Local).AddTicks(5288));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                column: "ReleaseDate",
                value: new DateTime(2023, 8, 25, 9, 35, 35, 771, DateTimeKind.Local).AddTicks(3966));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Films");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 18, 15, 16, 56, 509, DateTimeKind.Local).AddTicks(3637));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReleaseDate",
                value: new DateTime(2023, 4, 30, 11, 55, 30, 145, DateTimeKind.Local).AddTicks(5509));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ReleaseDate",
                value: new DateTime(2022, 8, 19, 6, 49, 13, 418, DateTimeKind.Local).AddTicks(7493));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "ReleaseDate",
                value: new DateTime(2023, 3, 20, 19, 2, 43, 777, DateTimeKind.Local).AddTicks(8854));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "ReleaseDate",
                value: new DateTime(2022, 9, 20, 20, 20, 55, 507, DateTimeKind.Local).AddTicks(5017));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "ReleaseDate",
                value: new DateTime(2023, 4, 4, 8, 8, 28, 617, DateTimeKind.Local).AddTicks(2314));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "ReleaseDate",
                value: new DateTime(2022, 11, 3, 7, 20, 41, 27, DateTimeKind.Local).AddTicks(2350));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "ReleaseDate",
                value: new DateTime(2023, 1, 26, 22, 35, 8, 715, DateTimeKind.Local).AddTicks(4556));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "ReleaseDate",
                value: new DateTime(2022, 7, 18, 14, 34, 24, 172, DateTimeKind.Local).AddTicks(2009));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "ReleaseDate",
                value: new DateTime(2023, 5, 10, 6, 16, 33, 633, DateTimeKind.Local).AddTicks(4650));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "ReleaseDate",
                value: new DateTime(2023, 3, 8, 23, 30, 37, 775, DateTimeKind.Local).AddTicks(1797));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "ReleaseDate",
                value: new DateTime(2023, 3, 17, 4, 2, 34, 549, DateTimeKind.Local).AddTicks(485));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "ReleaseDate",
                value: new DateTime(2023, 2, 14, 9, 16, 3, 468, DateTimeKind.Local).AddTicks(6471));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "ReleaseDate",
                value: new DateTime(2022, 8, 10, 22, 28, 41, 956, DateTimeKind.Local).AddTicks(2766));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "ReleaseDate",
                value: new DateTime(2023, 3, 1, 15, 34, 34, 985, DateTimeKind.Local).AddTicks(9896));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "ReleaseDate",
                value: new DateTime(2022, 6, 19, 7, 29, 23, 452, DateTimeKind.Local).AddTicks(8735));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "ReleaseDate",
                value: new DateTime(2023, 1, 26, 21, 50, 55, 30, DateTimeKind.Local).AddTicks(8205));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "ReleaseDate",
                value: new DateTime(2023, 1, 23, 23, 33, 36, 390, DateTimeKind.Local).AddTicks(1241));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "ReleaseDate",
                value: new DateTime(2022, 6, 19, 10, 51, 35, 969, DateTimeKind.Local).AddTicks(4599));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "ReleaseDate",
                value: new DateTime(2022, 11, 10, 12, 22, 20, 451, DateTimeKind.Local).AddTicks(7829));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "ReleaseDate",
                value: new DateTime(2023, 1, 18, 23, 45, 14, 640, DateTimeKind.Local).AddTicks(190));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "ReleaseDate",
                value: new DateTime(2022, 8, 31, 19, 12, 36, 909, DateTimeKind.Local).AddTicks(7892));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "ReleaseDate",
                value: new DateTime(2022, 12, 31, 13, 2, 44, 228, DateTimeKind.Local).AddTicks(1440));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "ReleaseDate",
                value: new DateTime(2023, 2, 1, 5, 39, 3, 457, DateTimeKind.Local).AddTicks(4592));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "ReleaseDate",
                value: new DateTime(2023, 2, 17, 7, 7, 55, 21, DateTimeKind.Local).AddTicks(1026));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "ReleaseDate",
                value: new DateTime(2022, 12, 13, 0, 44, 15, 144, DateTimeKind.Local).AddTicks(6304));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "ReleaseDate",
                value: new DateTime(2022, 9, 3, 12, 47, 51, 140, DateTimeKind.Local).AddTicks(7861));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "ReleaseDate",
                value: new DateTime(2022, 11, 26, 15, 13, 46, 252, DateTimeKind.Local).AddTicks(3068));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "ReleaseDate",
                value: new DateTime(2023, 2, 19, 1, 44, 40, 245, DateTimeKind.Local).AddTicks(4357));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "ReleaseDate",
                value: new DateTime(2022, 6, 16, 2, 40, 3, 461, DateTimeKind.Local).AddTicks(6127));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "ReleaseDate",
                value: new DateTime(2023, 5, 12, 1, 5, 52, 658, DateTimeKind.Local).AddTicks(4267));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "ReleaseDate",
                value: new DateTime(2023, 2, 19, 20, 53, 18, 597, DateTimeKind.Local).AddTicks(4683));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "ReleaseDate",
                value: new DateTime(2022, 11, 27, 21, 22, 19, 848, DateTimeKind.Local).AddTicks(574));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "ReleaseDate",
                value: new DateTime(2022, 6, 26, 14, 38, 7, 686, DateTimeKind.Local).AddTicks(8156));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "ReleaseDate",
                value: new DateTime(2022, 7, 14, 19, 30, 25, 681, DateTimeKind.Local).AddTicks(7818));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "ReleaseDate",
                value: new DateTime(2022, 8, 3, 14, 4, 23, 214, DateTimeKind.Local).AddTicks(9787));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 30, 5, 37, 36, 610, DateTimeKind.Local).AddTicks(7975));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "ReleaseDate",
                value: new DateTime(2022, 8, 11, 3, 39, 16, 929, DateTimeKind.Local).AddTicks(9338));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                column: "ReleaseDate",
                value: new DateTime(2022, 11, 5, 11, 17, 31, 489, DateTimeKind.Local).AddTicks(4472));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                column: "ReleaseDate",
                value: new DateTime(2023, 1, 23, 8, 3, 48, 113, DateTimeKind.Local).AddTicks(2250));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                column: "ReleaseDate",
                value: new DateTime(2023, 3, 7, 15, 9, 10, 261, DateTimeKind.Local).AddTicks(4287));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                column: "ReleaseDate",
                value: new DateTime(2023, 2, 27, 2, 20, 9, 690, DateTimeKind.Local).AddTicks(9584));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                column: "ReleaseDate",
                value: new DateTime(2022, 8, 21, 18, 6, 23, 246, DateTimeKind.Local).AddTicks(8547));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                column: "ReleaseDate",
                value: new DateTime(2022, 8, 25, 15, 46, 48, 405, DateTimeKind.Local).AddTicks(6162));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                column: "ReleaseDate",
                value: new DateTime(2022, 8, 3, 11, 53, 11, 475, DateTimeKind.Local).AddTicks(7666));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                column: "ReleaseDate",
                value: new DateTime(2022, 12, 6, 16, 35, 23, 35, DateTimeKind.Local).AddTicks(1204));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                column: "ReleaseDate",
                value: new DateTime(2022, 8, 11, 11, 34, 57, 337, DateTimeKind.Local).AddTicks(4333));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                column: "ReleaseDate",
                value: new DateTime(2022, 9, 23, 8, 27, 14, 763, DateTimeKind.Local).AddTicks(3956));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                column: "ReleaseDate",
                value: new DateTime(2022, 11, 6, 13, 9, 18, 365, DateTimeKind.Local).AddTicks(3151));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                column: "ReleaseDate",
                value: new DateTime(2023, 3, 26, 2, 18, 17, 545, DateTimeKind.Local).AddTicks(1817));
        }
    }
}
