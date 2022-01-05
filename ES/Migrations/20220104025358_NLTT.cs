using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ES.Migrations
{
    public partial class NLTT : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SoLieu",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MT_HT = table.Column<int>(type: "int", nullable: false),
                    MT_CSLN = table.Column<int>(type: "int", nullable: false),
                    MT_TK = table.Column<int>(type: "int", nullable: false),
                    MT_SLN = table.Column<int>(type: "int", nullable: false),
                    G_HT = table.Column<int>(type: "int", nullable: false),
                    G_CSLN = table.Column<int>(type: "int", nullable: false),
                    G_TK = table.Column<int>(type: "int", nullable: false),
                    G_SLN = table.Column<int>(type: "int", nullable: false),
                    SK_HT = table.Column<int>(type: "int", nullable: false),
                    SK_CSLN = table.Column<int>(type: "int", nullable: false),
                    SK_TK = table.Column<int>(type: "int", nullable: false),
                    SK_SLN = table.Column<int>(type: "int", nullable: false),
                    T_HT = table.Column<int>(type: "int", nullable: false),
                    T_CSLN = table.Column<int>(type: "int", nullable: false),
                    T_TK = table.Column<int>(type: "int", nullable: false),
                    T_SLN = table.Column<int>(type: "int", nullable: false),
                    ThoiGian = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SoLieu", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SoLieu");
        }
    }
}
