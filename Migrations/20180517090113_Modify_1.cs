using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Redoak.Domain.Model.Migrations
{
    public partial class Modify_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Goods_GoodsCategory_CategoryId",
                table: "Goods");

            migrationBuilder.DropForeignKey(
                name: "FK_GoodsSpec_Goods_GoodsId",
                table: "GoodsSpec");

            migrationBuilder.DropIndex(
                name: "GoodsSpecId",
                table: "GoodsSpec");

            migrationBuilder.DropIndex(
                name: "GoodsCategoryId",
                table: "GoodsCategory");

            migrationBuilder.DropIndex(
                name: "GoodsId",
                table: "Goods");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "GoodsSpec");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "GoodsCategory");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Goods");

            migrationBuilder.RenameColumn(
                name: "DateUpdate",
                table: "GoodsSpec",
                newName: "UpdateDate");

            migrationBuilder.RenameColumn(
                name: "DateCreate",
                table: "GoodsSpec",
                newName: "CreateDate");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "GoodsSpec",
                newName: "GoodsSpecId");

            migrationBuilder.RenameColumn(
                name: "DateUpdate",
                table: "GoodsCategory",
                newName: "UpdateDate");

            migrationBuilder.RenameColumn(
                name: "DateCreate",
                table: "GoodsCategory",
                newName: "CreateDate");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "GoodsCategory",
                newName: "GoodsCategoryId");

            migrationBuilder.RenameColumn(
                name: "DateUpdate",
                table: "Goods",
                newName: "UpdateDate");

            migrationBuilder.RenameColumn(
                name: "DateCreate",
                table: "Goods",
                newName: "CreateDate");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Goods",
                newName: "GoodsCategoryId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Goods",
                newName: "GoodsId");

            migrationBuilder.RenameIndex(
                name: "IX_Goods_CategoryId",
                table: "Goods",
                newName: "IX_Goods_GoodsCategoryId");

            migrationBuilder.AlterColumn<string>(
                name: "UpdateUser",
                table: "GoodsSpec",
                type: "nvarchar(10)",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<int>(
                name: "GoodsId",
                table: "GoodsSpec",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GoodsSpecName",
                table: "GoodsSpec",
                type: "nvarchar(20)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdateUser",
                table: "GoodsCategory",
                type: "nvarchar(10)",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AddColumn<string>(
                name: "GoodsCategoryName",
                table: "GoodsCategory",
                type: "nvarchar(20)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "GoodsCategory",
                type: "nvarchar(400)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ParentCategoryId",
                table: "GoodsCategory",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "UpdateUser",
                table: "Goods",
                type: "nvarchar(10)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GoodsName",
                table: "Goods",
                type: "nvarchar(20)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Purchase",
                columns: table => new
                {
                    PurchaseId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PurchaseName = table.Column<string>(type: "nvarchar(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Purchase", x => x.PurchaseId);
                });

            migrationBuilder.CreateTable(
                name: "Quotation",
                columns: table => new
                {
                    GoodsSpecId = table.Column<int>(type: "int", nullable: false),
                    ProposeDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Price = table.Column<double>(type: "money", nullable: false),
                    UpdateUser = table.Column<string>(type: "varchar(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quotation", x => new { x.GoodsSpecId, x.ProposeDate });
                    table.ForeignKey(
                        name: "FK_Quotation_GoodsSpec_GoodsSpecId",
                        column: x => x.GoodsSpecId,
                        principalTable: "GoodsSpec",
                        principalColumn: "GoodsSpecId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Region",
                columns: table => new
                {
                    RegionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ParentRegionId = table.Column<int>(type: "int", nullable: false),
                    RegionName = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdateUser = table.Column<string>(type: "varchar(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Region", x => x.RegionId);
                });

            migrationBuilder.CreateTable(
                name: "Sale",
                columns: table => new
                {
                    SaleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SaleName = table.Column<string>(type: "nvarchar(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sale", x => x.SaleId);
                });

            migrationBuilder.CreateTable(
                name: "Supplier",
                columns: table => new
                {
                    SupplierId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    ContactEmail = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    ContactPerson = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    ContactPhone = table.Column<string>(type: "varchar(20)", nullable: true),
                    SupplierName = table.Column<string>(type: "nvarchar(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supplier", x => x.SupplierId);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    ContactEmail = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    ContactPerson = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    ContactPhone = table.Column<string>(type: "varchar(20)", nullable: true),
                    CustomerName = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    RegionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CustomerId);
                    table.ForeignKey(
                        name: "FK_Customer_Region_RegionId",
                        column: x => x.RegionId,
                        principalTable: "Region",
                        principalColumn: "RegionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseOrder",
                columns: table => new
                {
                    PurchaseOrderId = table.Column<string>(nullable: false),
                    GoodsSpecId = table.Column<int>(nullable: false),
                    Note = table.Column<string>(type: "nvarchar(400)", nullable: true),
                    PurchaseId = table.Column<int>(nullable: false),
                    Quantity = table.Column<double>(type: "decimal", nullable: false),
                    SupplierId = table.Column<int>(nullable: false),
                    TotalPrice = table.Column<double>(type: "money", nullable: false),
                    UnitPrice = table.Column<double>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseOrder", x => x.PurchaseOrderId);
                    table.ForeignKey(
                        name: "FK_PurchaseOrder_GoodsSpec_GoodsSpecId",
                        column: x => x.GoodsSpecId,
                        principalTable: "GoodsSpec",
                        principalColumn: "GoodsSpecId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PurchaseOrder_Purchase_PurchaseId",
                        column: x => x.PurchaseId,
                        principalTable: "Purchase",
                        principalColumn: "PurchaseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PurchaseOrder_Supplier_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Supplier",
                        principalColumn: "SupplierId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SalesOrder",
                columns: table => new
                {
                    SalesOrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CustomerId = table.Column<int>(nullable: false),
                    GoodsSpecId = table.Column<int>(nullable: false),
                    Note = table.Column<string>(type: "nvarchar(400)", nullable: true),
                    Quantity = table.Column<double>(type: "decimal", nullable: false),
                    SaleId = table.Column<int>(nullable: false),
                    TotalPrice = table.Column<double>(type: "money", nullable: false),
                    UnitPrice = table.Column<double>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesOrder", x => x.SalesOrderId);
                    table.ForeignKey(
                        name: "FK_SalesOrder_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SalesOrder_GoodsSpec_GoodsSpecId",
                        column: x => x.GoodsSpecId,
                        principalTable: "GoodsSpec",
                        principalColumn: "GoodsSpecId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SalesOrder_Sale_SaleId",
                        column: x => x.SaleId,
                        principalTable: "Sale",
                        principalColumn: "SaleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customer_RegionId",
                table: "Customer",
                column: "RegionId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrder_GoodsSpecId",
                table: "PurchaseOrder",
                column: "GoodsSpecId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrder_PurchaseId",
                table: "PurchaseOrder",
                column: "PurchaseId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrder_SupplierId",
                table: "PurchaseOrder",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrder_CustomerId",
                table: "SalesOrder",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrder_GoodsSpecId",
                table: "SalesOrder",
                column: "GoodsSpecId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrder_SaleId",
                table: "SalesOrder",
                column: "SaleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Goods_GoodsCategory_GoodsCategoryId",
                table: "Goods",
                column: "GoodsCategoryId",
                principalTable: "GoodsCategory",
                principalColumn: "GoodsCategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GoodsSpec_Goods_GoodsId",
                table: "GoodsSpec",
                column: "GoodsId",
                principalTable: "Goods",
                principalColumn: "GoodsId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Goods_GoodsCategory_GoodsCategoryId",
                table: "Goods");

            migrationBuilder.DropForeignKey(
                name: "FK_GoodsSpec_Goods_GoodsId",
                table: "GoodsSpec");

            migrationBuilder.DropTable(
                name: "PurchaseOrder");

            migrationBuilder.DropTable(
                name: "Quotation");

            migrationBuilder.DropTable(
                name: "SalesOrder");

            migrationBuilder.DropTable(
                name: "Purchase");

            migrationBuilder.DropTable(
                name: "Supplier");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Sale");

            migrationBuilder.DropTable(
                name: "Region");

            migrationBuilder.DropColumn(
                name: "GoodsSpecName",
                table: "GoodsSpec");

            migrationBuilder.DropColumn(
                name: "GoodsCategoryName",
                table: "GoodsCategory");

            migrationBuilder.DropColumn(
                name: "Note",
                table: "GoodsCategory");

            migrationBuilder.DropColumn(
                name: "ParentCategoryId",
                table: "GoodsCategory");

            migrationBuilder.DropColumn(
                name: "GoodsName",
                table: "Goods");

            migrationBuilder.RenameColumn(
                name: "UpdateDate",
                table: "GoodsSpec",
                newName: "DateUpdate");

            migrationBuilder.RenameColumn(
                name: "CreateDate",
                table: "GoodsSpec",
                newName: "DateCreate");

            migrationBuilder.RenameColumn(
                name: "GoodsSpecId",
                table: "GoodsSpec",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "UpdateDate",
                table: "GoodsCategory",
                newName: "DateUpdate");

            migrationBuilder.RenameColumn(
                name: "CreateDate",
                table: "GoodsCategory",
                newName: "DateCreate");

            migrationBuilder.RenameColumn(
                name: "GoodsCategoryId",
                table: "GoodsCategory",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "UpdateDate",
                table: "Goods",
                newName: "DateUpdate");

            migrationBuilder.RenameColumn(
                name: "GoodsCategoryId",
                table: "Goods",
                newName: "CategoryId");

            migrationBuilder.RenameColumn(
                name: "CreateDate",
                table: "Goods",
                newName: "DateCreate");

            migrationBuilder.RenameColumn(
                name: "GoodsId",
                table: "Goods",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Goods_GoodsCategoryId",
                table: "Goods",
                newName: "IX_Goods_CategoryId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateUser",
                table: "GoodsSpec",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "GoodsId",
                table: "GoodsSpec",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "GoodsSpec",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateUser",
                table: "GoodsCategory",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "GoodsCategory",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdateUser",
                table: "Goods",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Goods",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "GoodsSpecId",
                table: "GoodsSpec",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "GoodsCategoryId",
                table: "GoodsCategory",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "GoodsId",
                table: "Goods",
                column: "Id",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Goods_GoodsCategory_CategoryId",
                table: "Goods",
                column: "CategoryId",
                principalTable: "GoodsCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GoodsSpec_Goods_GoodsId",
                table: "GoodsSpec",
                column: "GoodsId",
                principalTable: "Goods",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
