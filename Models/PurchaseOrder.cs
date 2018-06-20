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
        public string Id { get; set; }
        [Column(TypeName = "decimal")]
        public double Quantity { get; set; }
        [Column(TypeName = "money")]
        public double UnitPrice { get; set; }
        [Column(TypeName = "money")]
        public double TotalPrice { get; set; }
        [Column(TypeName = "nvarchar(400)")]
        public string Note { get; set; }

        public int PurchaseId { get; set; }
        public virtual Purchase Purchase { get; set; }
        public int SupplierId { get; set; }
        public virtual Supplier Supplier { get; set; }
        public int GoodsSpecId { get; set; }
        public virtual GoodsSpec Spec { get; set; }
    }
}
