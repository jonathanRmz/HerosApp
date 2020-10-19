using Microsoft.EntityFrameworkCore.Migrations;

namespace HerosApp.Migrations
{
    public partial class AddDefaultValues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO \"Heros\" (\"Id\", \"Name\", \"Age\", \"City\", \"Rating\", \"UrlPhoto\") VALUES (1, 'Maria-Jose Madrid', 32, 'Nayarit, MX', 0.0, 'https://randomuser.me/api/portraits/men/22.jpg')");
            migrationBuilder.Sql("INSERT INTO \"Heros\" (\"Id\", \"Name\", \"Age\", \"City\", \"Rating\", \"UrlPhoto\") VALUES (3, 'Jose Pablo Bueno', 36, 'Colima, MX', 0.0, 'https://randomuser.me/api/portraits/men/24.jpg')");
            migrationBuilder.Sql("INSERT INTO \"Heros\" (\"Id\", \"Name\", \"Age\", \"City\", \"Rating\", \"UrlPhoto\") VALUES (4, 'Marcelino Agudo', 39, 'Guerrero, MX', 0.0, 'https://randomuser.me/api/portraits/men/25.jpg')");
            migrationBuilder.Sql("INSERT INTO \"Heros\" (\"Id\", \"Name\", \"Age\", \"City\", \"Rating\", \"UrlPhoto\") VALUES (5, 'Roman Yuste', 29, 'Acapulco, MX', 0.0, 'https://randomuser.me/api/portraits/men/26.jpg')");
            migrationBuilder.Sql("INSERT INTO \"Heros\" (\"Id\", \"Name\", \"Age\", \"City\", \"Rating\", \"UrlPhoto\") VALUES (6, 'Alberto Cebrian', 27, 'CDMX, MX', 0.0, 'https://randomuser.me/api/portraits/men/27.jpg')");
            migrationBuilder.Sql("INSERT INTO \"Heros\" (\"Id\", \"Name\", \"Age\", \"City\", \"Rating\", \"UrlPhoto\") VALUES (2, 'Luciano Villalba', 34, 'Jalisco, MX', 0.0, 'https://randomuser.me/api/portraits/men/23.jpg')");
            migrationBuilder.Sql("INSERT INTO \"Heros\" (\"Id\", \"Name\", \"Age\", \"City\", \"Rating\", \"UrlPhoto\") VALUES (7, 'Hassan Guirado', 33, 'Aguascalientes, MX', 0.0, 'https://randomuser.me/api/portraits/men/28.jpg')");
            migrationBuilder.Sql("INSERT INTO \"Heros\" (\"Id\", \"Name\", \"Age\", \"City\", \"Rating\", \"UrlPhoto\") VALUES (8, 'Oscar Zamorano', 30, 'Michoacán, MX', 0.0, 'https://randomuser.me/api/portraits/men/29.jpg')");
            migrationBuilder.Sql("INSERT INTO \"Heros\" (\"Id\", \"Name\", \"Age\", \"City\", \"Rating\", \"UrlPhoto\") VALUES (9, 'Abel Arellano', 31, 'Quintana Roo, MX', 0.0, 'https://randomuser.me/api/portraits/men/21.jpg')");
            migrationBuilder.Sql("INSERT INTO \"Heros\" (\"Id\", \"Name\", \"Age\", \"City\", \"Rating\", \"UrlPhoto\") VALUES (10, 'Gustavo Mañas', 32, 'Yucatán, MX', 0.0, 'https://randomuser.me/api/portraits/men/20.jpg')");

            migrationBuilder.Sql("INSERT INTO \"Scores\" (\"Id\", \"HeroId\", \"UserName\", \"Rating\", \"Date\") VALUES (1, 1, 'Jose Domingo Puig', 5, '10/10/2020')");
            migrationBuilder.Sql("INSERT INTO \"Scores\" (\"Id\", \"HeroId\", \"UserName\", \"Rating\", \"Date\") VALUES (2, 1, 'Bruno Amoros', 3, '10/10/2020')");
            migrationBuilder.Sql("INSERT INTO \"Scores\" (\"Id\", \"HeroId\", \"UserName\", \"Rating\", \"Date\") VALUES (3, 1, 'Luis Francisco Arellano', 4, '10/10/2020')");
            migrationBuilder.Sql("INSERT INTO \"Scores\" (\"Id\", \"HeroId\", \"UserName\", \"Rating\", \"Date\") VALUES (4, 2, 'Tomas Perez', 5, '10/10/2020')");
            migrationBuilder.Sql("INSERT INTO \"Scores\" (\"Id\", \"HeroId\", \"UserName\", \"Rating\", \"Date\") VALUES (5, 2, 'Juan Ignacio Borja', 3, '10/10/2020')");
            migrationBuilder.Sql("INSERT INTO \"Scores\" (\"Id\", \"HeroId\", \"UserName\", \"Rating\", \"Date\") VALUES (6, 3, 'Fernando Jose Tejedor', 3, '10/10/2020')");
            migrationBuilder.Sql("INSERT INTO \"Scores\" (\"Id\", \"HeroId\", \"UserName\", \"Rating\", \"Date\") VALUES (7, 3, 'Jose Antonio Romero', 4, '10/10/2020')");
            migrationBuilder.Sql("INSERT INTO \"Scores\" (\"Id\", \"HeroId\", \"UserName\", \"Rating\", \"Date\") VALUES (8, 3, 'Francisco Javier Arribas', 3, '10/10/2020')");
            migrationBuilder.Sql("INSERT INTO \"Scores\" (\"Id\", \"HeroId\", \"UserName\", \"Rating\", \"Date\") VALUES (9, 3, 'Jacinto del Campo', 5, '10/10/2020')");
            migrationBuilder.Sql("INSERT INTO \"Scores\" (\"Id\", \"HeroId\", \"UserName\", \"Rating\", \"Date\") VALUES (10, 4, 'Ayman Olivares', 3, '10/10/2020')");
            migrationBuilder.Sql("INSERT INTO \"Scores\" (\"Id\", \"HeroId\", \"UserName\", \"Rating\", \"Date\") VALUES (11, 5, 'Francisco Luis Bolaños', 3, '10/10/2020')");
            migrationBuilder.Sql("INSERT INTO \"Scores\" (\"Id\", \"HeroId\", \"UserName\", \"Rating\", \"Date\") VALUES (12, 5, 'Luis Alfonso Tomas', 5, '10/10/2020')");
            migrationBuilder.Sql("INSERT INTO \"Scores\" (\"Id\", \"HeroId\", \"UserName\", \"Rating\", \"Date\") VALUES (13, 5, 'Pablo Jose Soto', 3, '10/10/2020')");
            migrationBuilder.Sql("INSERT INTO \"Scores\" (\"Id\", \"HeroId\", \"UserName\", \"Rating\", \"Date\") VALUES (14, 5, 'Leandro De-La-Fuente', 4, '10/10/2020')");
            migrationBuilder.Sql("INSERT INTO \"Scores\" (\"Id\", \"HeroId\", \"UserName\", \"Rating\", \"Date\") VALUES (15, 5, 'Biel Zhang', 5, '10/10/2020')");
            migrationBuilder.Sql("INSERT INTO \"Scores\" (\"Id\", \"HeroId\", \"UserName\", \"Rating\", \"Date\") VALUES (16, 6, 'Jose Domingo Puig', 4, '10/10/2020')");
            migrationBuilder.Sql("INSERT INTO \"Scores\" (\"Id\", \"HeroId\", \"UserName\", \"Rating\", \"Date\") VALUES (17, 6, 'Bruno Amoros', 4, '10/10/2020')");
            migrationBuilder.Sql("INSERT INTO \"Scores\" (\"Id\", \"HeroId\", \"UserName\", \"Rating\", \"Date\") VALUES (18, 6, 'Luis Francisco Arellano', 5, '10/10/2020')");
            migrationBuilder.Sql("INSERT INTO \"Scores\" (\"Id\", \"HeroId\", \"UserName\", \"Rating\", \"Date\") VALUES (19, 7, 'Tomas Perez', 2, '10/10/2020')");
            migrationBuilder.Sql("INSERT INTO \"Scores\" (\"Id\", \"HeroId\", \"UserName\", \"Rating\", \"Date\") VALUES (20, 7, 'Juan Ignacio Borja', 3, '10/10/2020')");
            migrationBuilder.Sql("INSERT INTO \"Scores\" (\"Id\", \"HeroId\", \"UserName\", \"Rating\", \"Date\") VALUES (21, 8, 'Fernando Jose Tejedor', 5, '10/10/2020')");
            migrationBuilder.Sql("INSERT INTO \"Scores\" (\"Id\", \"HeroId\", \"UserName\", \"Rating\", \"Date\") VALUES (22, 8, 'Jose Antonio Romero', 3, '10/10/2020')");
            migrationBuilder.Sql("INSERT INTO \"Scores\" (\"Id\", \"HeroId\", \"UserName\", \"Rating\", \"Date\") VALUES (23, 8, 'Francisco Javier Arribas', 4, '10/10/2020')");
            migrationBuilder.Sql("INSERT INTO \"Scores\" (\"Id\", \"HeroId\", \"UserName\", \"Rating\", \"Date\") VALUES (24, 8, 'Jacinto del Campo', 5, '10/10/2020')");
            migrationBuilder.Sql("INSERT INTO \"Scores\" (\"Id\", \"HeroId\", \"UserName\", \"Rating\", \"Date\") VALUES (25, 9, 'Ayman Olivares', 4, '10/10/2020')");
            migrationBuilder.Sql("INSERT INTO \"Scores\" (\"Id\", \"HeroId\", \"UserName\", \"Rating\", \"Date\") VALUES (26, 10, 'Francisco Luis Bolaños', 1, '10/10/2020')");
            migrationBuilder.Sql("INSERT INTO \"Scores\" (\"Id\", \"HeroId\", \"UserName\", \"Rating\", \"Date\") VALUES (27, 10, 'Luis Alfonso Tomas', 3, '10/10/2020')");
            migrationBuilder.Sql("INSERT INTO \"Scores\" (\"Id\", \"HeroId\", \"UserName\", \"Rating\", \"Date\") VALUES (28, 10, 'Pablo Jose Soto', 3, '10/10/2020')");
            migrationBuilder.Sql("INSERT INTO \"Scores\" (\"Id\", \"HeroId\", \"UserName\", \"Rating\", \"Date\") VALUES (29, 10, 'Leandro De-La-Fuente', 2, '10/10/2020')");
            migrationBuilder.Sql("INSERT INTO \"Scores\" (\"Id\", \"HeroId\", \"UserName\", \"Rating\", \"Date\") VALUES (30, 10, 'Biel Zhang', 5, '10/10/2020')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM \"Scores\" WHERE \"HeroId\" = 1");
            migrationBuilder.Sql("DELETE FROM \"Heros\" WHERE \"Id\" = 1");

            migrationBuilder.Sql("DELETE FROM \"Scores\" WHERE \"HeroId\" = 2");
            migrationBuilder.Sql("DELETE FROM \"Heros\" WHERE \"Id\" = 2");

            migrationBuilder.Sql("DELETE FROM \"Scores\" WHERE \"HeroId\" = 3");
            migrationBuilder.Sql("DELETE FROM \"Heros\" WHERE \"Id\" = 3");

            migrationBuilder.Sql("DELETE FROM \"Scores\" WHERE \"HeroId\" = 4");
            migrationBuilder.Sql("DELETE FROM \"Heros\" WHERE \"Id\" = 4");

            migrationBuilder.Sql("DELETE FROM \"Scores\" WHERE \"HeroId\" = 5");
            migrationBuilder.Sql("DELETE FROM \"Heros\" WHERE \"Id\" = 5");

            migrationBuilder.Sql("DELETE FROM \"Scores\" WHERE \"HeroId\" = 6");
            migrationBuilder.Sql("DELETE FROM \"Heros\" WHERE \"Id\" = 6");

            migrationBuilder.Sql("DELETE FROM \"Scores\" WHERE \"HeroId\" = 7");
            migrationBuilder.Sql("DELETE FROM \"Heros\" WHERE \"Id\" = 7");

            migrationBuilder.Sql("DELETE FROM \"Scores\" WHERE \"HeroId\" = 8");
            migrationBuilder.Sql("DELETE FROM \"Heros\" WHERE \"Id\" = 8");

            migrationBuilder.Sql("DELETE FROM \"Scores\" WHERE \"HeroId\" = 9");
            migrationBuilder.Sql("DELETE FROM \"Heros\" WHERE \"Id\" = 9");

            migrationBuilder.Sql("DELETE FROM \"Scores\" WHERE \"HeroId\" = 10");
            migrationBuilder.Sql("DELETE FROM \"Heros\" WHERE \"Id\" = 10");
        }
    }
}
