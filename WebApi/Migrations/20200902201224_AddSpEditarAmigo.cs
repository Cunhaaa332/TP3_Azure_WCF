using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi.Migrations
{
    public partial class AddSpEditarAmigo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                CREATE PROCEDURE [dbo].[EditarAmigo]
	                @id int,
                    @Nome nvarchar(max),
	                @Sobrenome nvarchar(max),
	                @Email nvarchar(max),
	                @Telefone nvarchar(max),
	                @Aniversario datetime2(7)
                AS
                    UPDATE AMIGO SET 
                    Nome = @Nome,
                    Sobrenome = @Sobrenome,
                    Email = @Email,
                    Telefone = @Telefone,
                    Aniversario = @Aniversario
                    Where id = @id
                RETURN 0
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                DROP PROCEDURE [dbo].[EditarAmigo]
            ");
        }
    }
}
