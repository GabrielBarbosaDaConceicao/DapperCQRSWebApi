using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DapperWebApi.Migrations
{
    public partial class SeedUsers : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("INSERT INTO Users(Name, Email) VALUES('Gabriel Barbosa Da Conceição', 'gabriel@hotmail.com')");
            mb.Sql("INSERT INTO Users(Name, Email) VALUES('Jose Alcides Da Costa', 'costa@yahoo.com')");
            mb.Sql("INSERT INTO Users(Name, Email) VALUES('Marlene Cristina Rocha', 'mcrocha@gmail.com')");
        }

        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("DELETE FROM Users");
        }
    }
}
