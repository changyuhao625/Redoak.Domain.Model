using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Redoak.Domain.Model.Migrations
{
    public partial class Modify_RenameProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SupplierName",
                table: "Supplier",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "SupplierId",
                table: "Supplier",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "SalesOrderId",
                table: "SalesOrder",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "SaleName",
                table: "Sale",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "SaleId",
                table: "Sale",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "RegionName",
                table: "Region",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "RegionId",
                table: "Region",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "PurchaseOrderId",
                table: "PurchaseOrder",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "PurchaseName",
                table: "Purchase",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "PurchaseId",
                table: "Purchase",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "GoodsSpecName",
                table: "GoodsSpec",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "GoodsSpecId",
                table: "GoodsSpec",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "GoodsCategoryName",
                table: "GoodsCategory",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "GoodsCategoryId",
                table: "GoodsCategory",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "GoodsName",
                table: "Goods",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "GoodsId",
                table: "Goods",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "CustomerName",
                table: "Customer",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Customer",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Supplier",
                newName: "SupplierName");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Supplier",
                newName: "SupplierId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "SalesOrder",
                newName: "SalesOrderId");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Sale",
                newName: "SaleName");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Sale",
                newName: "SaleId");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Region",
                newName: "RegionName");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Region",
                newName: "RegionId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "PurchaseOrder",
                newName: "PurchaseOrderId");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Purchase",
                newName: "PurchaseName");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Purchase",
                newName: "PurchaseId");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "GoodsSpec",
                newName: "GoodsSpecName");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "GoodsSpec",
                newName: "GoodsSpecId");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "GoodsCategory",
                newName: "GoodsCategoryName");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "GoodsCategory",
                newName: "GoodsCategoryId");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Goods",
                newName: "GoodsName");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Goods",
                newName: "GoodsId");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Customer",
                newName: "CustomerName");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Customer",
                newName: "CustomerId");
        }
    }
}
