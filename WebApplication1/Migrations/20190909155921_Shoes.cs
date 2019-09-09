using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace TippyToe.Migrations
{
    public partial class Shoes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Color");

            migrationBuilder.DropTable(
                name: "Size");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Shoes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Shoes",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Size",
                table: "Shoes",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Color",
                table: "Shoes");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Shoes");

            migrationBuilder.DropColumn(
                name: "Size",
                table: "Shoes");

            migrationBuilder.CreateTable(
                name: "Color",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ColorName = table.Column<string>(nullable: true),
                    ShoesId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Color", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Color_Shoes_ShoesId",
                        column: x => x.ShoesId,
                        principalTable: "Shoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Size",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ShoesId = table.Column<int>(nullable: true),
                    SizeNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Size", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Size_Shoes_ShoesId",
                        column: x => x.ShoesId,
                        principalTable: "Shoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Age = table.Column<int>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    Username = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Color_ShoesId",
                table: "Color",
                column: "ShoesId");

            migrationBuilder.CreateIndex(
                name: "IX_Size_ShoesId",
                table: "Size",
                column: "ShoesId");
        }
    }
}
