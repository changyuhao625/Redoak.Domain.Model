using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Redoak.Domain.Model.Models
{
    public class SalesOrder
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity) ]
        public int SalesOrderId { get; set; }
        public int Quantity { get; set; }
        public int UnitPrice { get; set; }
        public int TotalPrice { get; set; }
        public string Note { get; set; }

        [ForeignKey("SaleId")]
        public int SaleId { get; set; }
        public Sale Sale { get; set; }
        [ForeignKey("CustomerId")]
        public int CustomerId  { get; set; }
        public Customer Customer { get; set; }
        [ForeignKey("GoodsSpecId")]
        public int GoodsSpecId { get; set; }
        public GoodsSpec GoodsSpec { get; set; }
    }
}
