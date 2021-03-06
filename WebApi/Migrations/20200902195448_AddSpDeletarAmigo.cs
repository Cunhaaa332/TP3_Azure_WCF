﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi.Migrations
{
    public partial class AddSpDeletarAmigo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@" 
                CREATE PROCEDURE [dbo].[DeletarAmigo]
	                @id int
                AS
	                delete from amigo where id = @id
                RETURN 0                
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@" 
                DROP PROCEDURE [dbo].[DeletarAmigo]
            ");
        }
    }
}
