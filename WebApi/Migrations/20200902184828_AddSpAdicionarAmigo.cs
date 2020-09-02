using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi.Migrations
{
    public partial class AddSpAdicionarAmigo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                CREATE PROCEDURE [dbo].[AdicionarAmigo]
	                @Nome nvarchar(max),
	                @Sobrenome nvarchar(max),
	                @Email nvarchar(max),
	                @Telefone nvarchar(max),
	                @Aniversario datetime2(7)
                AS
	                INSERT INTO [dbo].[Amigo] ([Nome], [Sobrenome], [Email], [Telefone], [Aniversario]) 
	                VALUES (@Nome, @Sobrenome, @Email, @Telefone, @Aniversario)
                RETURN 0
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                DROP PROCEDURE [dbo].[AdicionarAmigo]
            ");
        }
    }
}
