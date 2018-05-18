using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Redoak.Domain.Model.Models
{
    public class SalesOrder
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column(TypeName = "decimal")]
        public double Quantity { get; set; }
        [Column(TypeName = "money")]
        public double UnitPrice { get; set; }
        [Column(TypeName = "money")]
        public double TotalPrice { get; set; }
        [Column(TypeName = "nvarchar(400)")]
        public string Note { get; set; }

        public int SaleId { get; set; }
        public virtual Sale Sale { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public int GoodsSpecId { get; set; }
        public virtual GoodsSpec Spec { get; set; }
    }
}
