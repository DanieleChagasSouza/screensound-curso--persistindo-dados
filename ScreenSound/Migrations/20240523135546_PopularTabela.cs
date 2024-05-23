using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScreenSound.Migrations
{
    /// <inheritdoc />
    public partial class PopularTabela : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("Artistas", 
                new string[] {"Nome", "Bio", "FotoPerfil"},
                new object[] {"Aline Barros", "É uma cantora, compositora, multi-instrumentista, escritora, empresária, pastora e apresentadora brasileira.",
                    "https://akamai.sscdn.co/uploadfile/letras/fotos/c/5/7/0/c570bc6a39ef159ca86eab7868fe1d55-tb_140.jpg" });

            migrationBuilder.InsertData("Artistas", new string[] { "Nome", "Bio", "FotoPerfil" },
                new object[] { "Eyshila Oliveira", "É uma cantora, pastora, escritora e compositora brasileira de música gospel.",
                    "https://akamai.sscdn.co/uploadfile/letras/fotos/1/4/f/e/14fee894c507846bf24ee5cac1a596db-tb_140.jpg" });

            migrationBuilder.InsertData("Artistas", new string[] { "Nome", "Bio", "FotoPerfil" },
                new object[] { "Damares Alves", "Mais conhecida apenas como Damares, é uma cantora e compositora brasileira de música cristã contemporânea ligada ao movimento pentecostal.",
                "https://akamai.sscdn.co/uploadfile/letras/fotos/2/3/b/9/23b985739895483a6369b6ddf22b230b-tb_140.jpg"});

            migrationBuilder.InsertData("Artistas", new string[] { "Nome", "Bio", "FotoPerfil" },
                new object[] { "Anderson Ricardo Freire", "É um cantor e compositor brasileiro, conhecido como intérprete de música cristã contemporânea para uma série de artistas.",
                    "https://akamai.sscdn.co/uploadfile/letras/fotos/a/4/2/7/a427f81f2a19e8beaf94d98b12559ded-tb_140.jpg"});
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Artistas");
        }
    }
}
