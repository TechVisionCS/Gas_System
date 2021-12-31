using Microsoft.EntityFrameworkCore.Migrations;

namespace PMS.Migrations
{
    public partial class adkflasdf : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "wms_category_tbl",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Description", "Name", "Status", "UpdatedAt", "UserId", "UserName" },
                values: new object[,]
                {
                    { 1L, null, null, "Liquefied petroleum gas (LPG, LP gas, or condensate), is a flammable mixture of hydrocarbon gases, most commonly propane, butane, and propylene. However, the latter two typically comprise 5% or less of the mixture.", "Liquefied petroleum gas LPG", 1, null, null, "System Defined" },
                    { 2L, null, null, "Syngas, or synthesis gas, is a fuel gas mixture consisting primarily of hydrogen, carbon monoxide, and very often some carbon dioxide. Syngas can be produced from many sources, including natural gas, coal, biomass, or virtually any hydrocarbon feedstock, by reaction with steam (steam reforming), carbon dioxide (dry reforming) or oxygen (partial oxidation).", "Syngas", 1, null, null, "System Defined" },
                    { 3L, null, null, "Natural gas is colorless and odorless, and explosive, so a sulfur-smell (similar to rotten eggs) is usually added for early detection of leaks", "Natural gas", 1, null, null, "System Defined" },
                    { 4L, null, null, "Propane (/ˈproʊpeɪn/) is a three-carbon alkane with the molecular formula C3H8. It is a gas at standard temperature and pressure, but compressible to a transportable liquid.", "Propane", 1, null, null, "System Defined" },
                    { 5L, null, null, "A gas stove is a stove that is fuelled by combustible gas such as syngas, natural gas, propane, butane, liquefied petroleum gas or other flammable gas.", "Gas stove", 1, null, null, "System Defined" },
                    { 6L, null, null, "Butane is a gas at room temperature and atmospheric pressure. Butane is a highly flammable, colorless, easily liquefied gas that quickly vaporizes at room temperature.", "Butane", 1, null, null, "System Defined" }
                });

            migrationBuilder.InsertData(
                table: "wms_country_tbl",
                columns: new[] { "Id", "Code", "CreatedAt", "DeletedAt", "Name", "UpdatedAt", "UserId", "UserName" },
                values: new object[,]
                {
                    { 5L, "IR", null, null, "Iran", null, null, "System_Populated" },
                    { 4L, "TUR", null, null, "Turkey", null, null, "System_Populated" },
                    { 3L, "IND", null, null, "India", null, null, "System_Populated" },
                    { 2L, "PK", null, null, "Pakistan", null, null, "System_Populated" },
                    { 1L, "AFN", null, null, "Afghanistan", null, null, "System_Populated" }
                });

            migrationBuilder.InsertData(
                table: "wms_manufacturer_tbl",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Description", "Name", "Status", "UpdatedAt", "UserId", "UserName" },
                values: new object[,]
                {
                    { 12L, null, null, "", "HI-Tek Manufacturing (Pvt) Ltd", 1, null, null, "System_Populated" },
                    { 11L, null, null, "", "ExpoMughal International", 1, null, null, "System_Populated" },
                    { 10L, null, null, "", "Engineering solution international", 1, null, null, "System_Populated" },
                    { 9L, null, null, "", "Country Autogas", 1, null, null, "System_Populated" },
                    { 8L, null, null, "", "Burhan Gas Company", 1, null, null, "System_Populated" },
                    { 7L, null, null, "", "Bashir gas pvt limited", 1, null, null, "System_Populated" },
                    { 2L, null, null, "China Petroleum and Chemical Corporation, also known as Sinopec, is the second-largest company behind US retailer Walmart and ", "Sinopec", 1, null, null, "System_Populated" },
                    { 5L, null, null, "Eneos Holdings is a Japanese petroleum and metals conglomerate and the fifth-largest oil and gas company in Asia by revenue.The Tokyo - headquartered firm brought in $75.9bn at the end of the 2019 - 20 fiscal year and recorded a $1.7bn loss across the same period.", "Eneos Holdings ", 1, null, null, "System_Populated" },
                    { 4L, null, null, "Saudi Aramco is the state-owned oil company of the Kingdom of Saudi Arabia and is the third-largest oil and gas company in Asia and the fourth-largest in the world by revenue.", " Saudi Aramco", 1, null, null, "System_Populated" },
                    { 3L, null, null, "China National Petroleum is the state-owned parent company of PetroChina – the country’s second-largest oil producer.", "China National Petroleum", 1, null, null, "System_Populated" },
                    { 13L, null, null, "", "Pak Engineering and Automation", 1, null, null, "System_Populated" },
                    { 1L, null, null, "Turkey", "2A Muhendislik San. - Tur ", 1, null, null, "System_Populated" },
                    { 6L, null, null, "", "Adeel Industry(Shan Gas)", 1, null, null, "System_Populated" },
                    { 14L, null, null, "", "Engineering solution international", 1, null, null, "System_Populated" }
                });

            migrationBuilder.InsertData(
                table: "wms_province_tbl",
                columns: new[] { "Id", "CountryCode", "CountryId", "CountryName", "CreatedAt", "DeletedAt", "Name", "UpdatedAt", "UserId", "UserName" },
                values: new object[,]
                {
                    { 1L, "AFN", 1L, "Afghanistan", null, null, "Badakhshan", null, null, "System_Populated" },
                    { 94L, "TUR", 4L, "Turkey", null, null, "Diyarbakır", null, null, "System_Populated" },
                    { 93L, "TUR", 4L, "Turkey", null, null, "Denizli", null, null, "System_Populated" },
                    { 92L, "TUR", 4L, "Turkey", null, null, "Çorum", null, null, "System_Populated" },
                    { 91L, "TUR", 4L, "Turkey", null, null, "Çankırı", null, null, "System_Populated" },
                    { 90L, "TUR", 4L, "Turkey", null, null, "Çanakkale", null, null, "System_Populated" },
                    { 88L, "TUR", 4L, "Turkey", null, null, "Bursa", null, null, "System_Populated" },
                    { 87L, "TUR", 4L, "Turkey", null, null, "Burdur", null, null, "System_Populated" },
                    { 86L, "TUR", 4L, "Turkey", null, null, "Bolu", null, null, "System_Populated" },
                    { 85L, "TUR", 4L, "Turkey", null, null, "Bitlis", null, null, "System_Populated" },
                    { 84L, "TUR", 4L, "Turkey", null, null, "Bingöl", null, null, "System_Populated" },
                    { 83L, "TUR", 4L, "Turkey", null, null, "Bilecik", null, null, "System_Populated" },
                    { 82L, "TUR", 4L, "Turkey", null, null, "Bayburt", null, null, "System_Populated" },
                    { 81L, "TUR", 4L, "Turkey", null, null, "Batman", null, null, "System_Populated" },
                    { 95L, "TUR", 4L, "Turkey", null, null, "Düzce", null, null, "System_Populated" },
                    { 80L, "TUR", 4L, "Turkey", null, null, "Bartın", null, null, "System_Populated" },
                    { 78L, "TUR", 4L, "Turkey", null, null, "Aydın", null, null, "System_Populated" },
                    { 77L, "TUR", 4L, "Turkey", null, null, "Artvin", null, null, "System_Populated" },
                    { 76L, "TUR", 4L, "Turkey", null, null, "Ardahan", null, null, "System_Populated" },
                    { 75L, "TUR", 4L, "Turkey", null, null, "Antalya", null, null, "System_Populated" },
                    { 74L, "TUR", 4L, "Turkey", null, null, "Ankara", null, null, "System_Populated" },
                    { 73L, "TUR", 4L, "Turkey", null, null, "Amasya", null, null, "System_Populated" },
                    { 72L, "TUR", 4L, "Turkey", null, null, "Aksaray", null, null, "System_Populated" },
                    { 71L, "TUR", 4L, "Turkey", null, null, "Ağri", null, null, "System_Populated" },
                    { 70L, "TUR", 4L, "Turkey", null, null, "Afyonkarahisar", null, null, "System_Populated" },
                    { 69L, "TUR", 4L, "Turkey", null, null, "Adıyaman", null, null, "System_Populated" },
                    { 68L, "TUR", 4L, "Turkey", null, null, "Adana", null, null, "System_Populated" },
                    { 67L, "IND", 3L, "India", null, null, "Uttarakhand", null, null, "System_Populated" },
                    { 66L, "IND", 3L, "India", null, null, "Uttar Pradesh", null, null, "System_Populated" },
                    { 79L, "TUR", 4L, "Turkey", null, null, "Balıkesir", null, null, "System_Populated" },
                    { 65L, "IND", 3L, "India", null, null, "Tripura", null, null, "System_Populated" },
                    { 96L, "IR", 5L, "Iran", null, null, "Alborz", null, null, "System_Populated" },
                    { 98L, "IR", 5L, "Iran", null, null, "Razavi Khorasan", null, null, "System_Populated" },
                    { 125L, "IR", 5L, "Iran", null, null, "Markazi", null, null, "System_Populated" },
                    { 124L, "IR", 5L, "Iran", null, null, "Qazvin", null, null, "System_Populated" },
                    { 123L, "IR", 5L, "Iran", null, null, "Gilan", null, null, "System_Populated" },
                    { 122L, "IR", 5L, "Iran", null, null, "Ardabil", null, null, "System_Populated" },
                    { 121L, "IR", 5L, "Iran", null, null, "Zanjan", null, null, "System_Populated" },
                    { 120L, "IR", 5L, "Iran", null, null, "East Azarbaijan", null, null, "System_Populated" },
                    { 119L, "IR", 5L, "Iran", null, null, "West Azarbaijan", null, null, "System_Populated" },
                    { 118L, "IR", 5L, "Iran", null, null, "Kurdistan", null, null, "System_Populated" },
                    { 117L, "IR", 5L, "Iran", null, null, "Hamadan", null, null, "System_Populated" },
                    { 128L, "IR", 5L, "Iran", null, null, "Kermanshah", null, null, "System_Populated" },
                    { 116L, "IR", 5L, "Iran", null, null, "Ilam", null, null, "System_Populated" },
                    { 115L, "IR", 5L, "Iran", null, null, "Lorestan", null, null, "System_Populated" },
                    { 114L, "IR", 5L, "Iran", null, null, "Khuzestan", null, null, "System_Populated" },
                    { 97L, "IR", 5L, "Iran", null, null, "South Khorasan", null, null, "System_Populated" },
                    { 113L, "IR", 5L, "Iran", null, null, "Chahar Mahaal", null, null, "System_Populated" },
                    { 111L, "IR", 5L, "Iran", null, null, "Kohkiluyeh", null, null, "System_Populated" },
                    { 110L, "IR", 5L, "Iran", null, null, "Buyer Ahmad", null, null, "System_Populated" },
                    { 109L, "IR", 5L, "Iran", null, null, "Bushehr", null, null, "System_Populated" },
                    { 108L, "IR", 5L, "Iran", null, null, "Fars", null, null, "System_Populated" },
                    { 107L, "IR", 5L, "Iran", null, null, "Hormozgan", null, null, "System_Populated" },
                    { 106L, "IR", 5L, "Iran", null, null, "Sistan-Baluchistan", null, null, "System_Populated" },
                    { 105L, "IR", 5L, "Iran", null, null, "Kerman", null, null, "System_Populated" },
                    { 104L, "IR", 5L, "Iran", null, null, "Yazd", null, null, "System_Populated" },
                    { 103L, "IR", 5L, "Iran", null, null, "Esfahan", null, null, "System_Populated" },
                    { 102L, "IR", 5L, "Iran", null, null, "Semnan", null, null, "System_Populated" },
                    { 101L, "IR", 5L, "Iran", null, null, "Mazandaran", null, null, "System_Populated" },
                    { 100L, "IR", 5L, "Iran", null, null, "Golestan", null, null, "System_Populated" },
                    { 99L, "IR", 5L, "Iran", null, null, "North Khorasan", null, null, "System_Populated" },
                    { 112L, "IR", 5L, "Iran", null, null, "Bakhtiari", null, null, "System_Populated" },
                    { 126L, "IR", 5L, "Iran", null, null, "Qom", null, null, "System_Populated" },
                    { 64L, "IND", 3L, "India", null, null, "Telangana", null, null, "System_Populated" },
                    { 62L, "IND", 3L, "India", null, null, "Tamil Nadu", null, null, "System_Populated" },
                    { 29L, "AFN", 1L, "Afghanistan", null, null, "Parwan", null, null, "System_Populated" },
                    { 28L, "AFN", 1L, "Afghanistan", null, null, "Panjshir", null, null, "System_Populated" },
                    { 27L, "AFN", 1L, "Afghanistan", null, null, "Paktika", null, null, "System_Populated" },
                    { 26L, "AFN", 1L, "Afghanistan", null, null, "Paktia", null, null, "System_Populated" },
                    { 25L, "AFN", 1L, "Afghanistan", null, null, "Urozgan", null, null, "System_Populated" },
                    { 24L, "AFN", 1L, "Afghanistan", null, null, "Nuristan", null, null, "System_Populated" },
                    { 23L, "AFN", 1L, "Afghanistan", null, null, "Nimruz", null, null, "System_Populated" },
                    { 22L, "AFN", 1L, "Afghanistan", null, null, "Nangarhar", null, null, "System_Populated" },
                    { 21L, "AFN", 1L, "Afghanistan", null, null, "Logar", null, null, "System_Populated" },
                    { 20L, "AFN", 1L, "Afghanistan", null, null, "Laghman", null, null, "System_Populated" },
                    { 19L, "AFN", 1L, "Afghanistan", null, null, "Kunduz", null, null, "System_Populated" },
                    { 18L, "AFN", 1L, "Afghanistan", null, null, "Kunar", null, null, "System_Populated" },
                    { 17L, "AFN", 1L, "Afghanistan", null, null, "Khost", null, null, "System_Populated" },
                    { 30L, "AFN", 1L, "Afghanistan", null, null, "Samangan", null, null, "System_Populated" },
                    { 16L, "AFN", 1L, "Afghanistan", null, null, "Kapisa", null, null, "System_Populated" },
                    { 14L, "AFN", 1L, "Afghanistan", null, null, "Kabul", null, null, "System_Populated" },
                    { 13L, "AFN", 1L, "Afghanistan", null, null, "Jowzjan", null, null, "System_Populated" },
                    { 12L, "AFN", 1L, "Afghanistan", null, null, "Herat", null, null, "System_Populated" },
                    { 11L, "AFN", 1L, "Afghanistan", null, null, "Helmand", null, null, "System_Populated" },
                    { 10L, "AFN", 1L, "Afghanistan", null, null, "Ghor", null, null, "System_Populated" },
                    { 9L, "AFN", 1L, "Afghanistan", null, null, "Ghazni", null, null, "System_Populated" },
                    { 8L, "AFN", 1L, "Afghanistan", null, null, "Faryab", null, null, "System_Populated" },
                    { 7L, "AFN", 1L, "Afghanistan", null, null, "Farah", null, null, "System_Populated" },
                    { 6L, "AFN", 1L, "Afghanistan", null, null, "Daykundi", null, null, "System_Populated" },
                    { 5L, "AFN", 1L, "Afghanistan", null, null, "Bamyan", null, null, "System_Populated" },
                    { 4L, "AFN", 1L, "Afghanistan", null, null, "Balkh", null, null, "System_Populated" },
                    { 3L, "AFN", 1L, "Afghanistan", null, null, "Baghlan", null, null, "System_Populated" },
                    { 2L, "AFN", 1L, "Afghanistan", null, null, "Badghis", null, null, "System_Populated" },
                    { 15L, "AFN", 1L, "Afghanistan", null, null, "Kandahar", null, null, "System_Populated" },
                    { 63L, "IND", 3L, "India", null, null, "Telangana", null, null, "System_Populated" },
                    { 31L, "AFN", 1L, "Afghanistan", null, null, "Sar-e Pol", null, null, "System_Populated" },
                    { 33L, "AFN", 1L, "Afghanistan", null, null, "Wardak", null, null, "System_Populated" },
                    { 61L, "IND", 3L, "India", null, null, "Sikkim", null, null, "System_Populated" },
                    { 60L, "IND", 3L, "India", null, null, "Rajasthan", null, null, "System_Populated" },
                    { 59L, "IND", 3L, "India", null, null, "Punjab", null, null, "System_Populated" },
                    { 58L, "IND", 3L, "India", null, null, "Odisha", null, null, "System_Populated" },
                    { 57L, "IND", 3L, "India", null, null, "Nagaland", null, null, "System_Populated" },
                    { 56L, "IND", 3L, "India", null, null, "Mizoram", null, null, "System_Populated" },
                    { 55L, "IND", 3L, "India", null, null, "Meghalaya", null, null, "System_Populated" },
                    { 54L, "IND", 3L, "India", null, null, "Manipur", null, null, "System_Populated" },
                    { 53L, "IND", 3L, "India", null, null, "Maharashtra", null, null, "System_Populated" },
                    { 52L, "IND", 3L, "India", null, null, "Madhya Pradesh", null, null, "System_Populated" },
                    { 51L, "IND", 3L, "India", null, null, "Kerala", null, null, "System_Populated" },
                    { 50L, "IND", 3L, "India", null, null, "Karnataka", null, null, "System_Populated" },
                    { 49L, "IND", 3L, "India", null, null, "Jharkhand", null, null, "System_Populated" },
                    { 32L, "AFN", 1L, "Afghanistan", null, null, "Takhar", null, null, "System_Populated" },
                    { 48L, "IND", 3L, "India", null, null, "Himachal Pradesh", null, null, "System_Populated" },
                    { 46L, "IND", 3L, "India", null, null, "Gujarat", null, null, "System_Populated" },
                    { 45L, "IND", 3L, "India", null, null, "Goa", null, null, "System_Populated" },
                    { 44L, "IND", 3L, "India", null, null, "Chhattisgarh", null, null, "System_Populated" },
                    { 43L, "IND", 3L, "India", null, null, "Bihar", null, null, "System_Populated" },
                    { 42L, "IND", 3L, "India", null, null, "Assam", null, null, "System_Populated" },
                    { 41L, "IND", 3L, "India", null, null, "Arunachal Pradesh", null, null, "System_Populated" },
                    { 40L, "IND", 3L, "India", null, null, "Andhra Pradesh", null, null, "System_Populated" },
                    { 39L, "PK", 2L, "Pakistan", null, null, "Peshawar", null, null, "System_Populated" },
                    { 38L, "PK", 2L, "Pakistan", null, null, "Sohawa", null, null, "System_Populated" },
                    { 37L, "PK", 2L, "Pakistan", null, null, "Jehlum", null, null, "System_Populated" },
                    { 36L, "PK", 2L, "Pakistan", null, null, "RawalPindi", null, null, "System_Populated" },
                    { 35L, "PK", 2L, "Pakistan", null, null, "Punjab", null, null, "System_Populated" },
                    { 34L, "AFN", 1L, "Afghanistan", null, null, "Zabul", null, null, "System_Populated" },
                    { 47L, "IND", 3L, "India", null, null, "Haryana", null, null, "System_Populated" },
                    { 127L, "IR", 5L, "Iran", null, null, "Tehran", null, null, "System_Populated" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "wms_category_tbl",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "wms_category_tbl",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "wms_category_tbl",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "wms_category_tbl",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "wms_category_tbl",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "wms_category_tbl",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "wms_manufacturer_tbl",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 40L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 41L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 42L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 43L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 44L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 45L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 46L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 47L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 48L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 49L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 50L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 51L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 52L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 53L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 54L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 55L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 56L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 57L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 58L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 59L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 60L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 61L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 62L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 63L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 64L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 65L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 66L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 67L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 68L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 69L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 70L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 71L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 72L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 73L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 74L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 75L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 76L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 77L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 78L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 79L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 80L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 81L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 82L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 83L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 84L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 85L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 86L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 87L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 88L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 90L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 91L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 92L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 93L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 94L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 95L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 96L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 97L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 98L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 99L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 100L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 101L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 102L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 103L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 104L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 105L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 106L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 107L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 108L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 109L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 110L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 111L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 112L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 113L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 114L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 115L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 116L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 117L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 118L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 119L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 120L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 121L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 122L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 123L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 124L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 125L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 126L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 127L);

            migrationBuilder.DeleteData(
                table: "wms_province_tbl",
                keyColumn: "Id",
                keyValue: 128L);

            migrationBuilder.DeleteData(
                table: "wms_country_tbl",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "wms_country_tbl",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "wms_country_tbl",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "wms_country_tbl",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "wms_country_tbl",
                keyColumn: "Id",
                keyValue: 5L);
        }
    }
}
