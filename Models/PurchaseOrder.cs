using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Redoak.Domain.Model.Models
{
    public class PurchaseOrder
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string PurchaseOrderId { get; set; }
        public int Quantity { get; set; }
        public int UnitPrice { get; set; }
        public int TotalPrice { get; set; }
        public string Note { get; set; }

        [ForeignKey("PurchaseId")]
        public int PurchaseId { get; set; }
        public Purchase Purchase { get; set; }
        [ForeignKey("SupplierId")]
        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }
        [ForeignKey("GoodsSpecId")]
        public int GoodsSpecId { get; set; }
        public GoodsSpec GoodsSpec { get; set; }
    }
}
