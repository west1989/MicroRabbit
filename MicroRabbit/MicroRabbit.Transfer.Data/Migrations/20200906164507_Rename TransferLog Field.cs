using Microsoft.EntityFrameworkCore.Migrations;

namespace MicroRabbit.Transfer.Data.Migrations
{
    public partial class RenameTransferLogField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TRansferAmount",
                table: "TransferLogs",
                newName: "TransferAmount");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TransferAmount",
                table: "TransferLogs",
                newName: "TRansferAmount");
        }
    }
}
