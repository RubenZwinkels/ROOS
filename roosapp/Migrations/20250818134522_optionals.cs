using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace roosapp.Migrations
{
    /// <inheritdoc />
    public partial class optionals : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Places_placeId",
                table: "Transactions");

            migrationBuilder.AlterColumn<Guid>(
                name: "placeId",
                table: "Transactions",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "TEXT");

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Places_placeId",
                table: "Transactions",
                column: "placeId",
                principalTable: "Places",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Places_placeId",
                table: "Transactions");

            migrationBuilder.AlterColumn<Guid>(
                name: "placeId",
                table: "Transactions",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Places_placeId",
                table: "Transactions",
                column: "placeId",
                principalTable: "Places",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
