using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Redoak.Domain.Model.Models
{
    public class Quotation
    {
        [Key]
        [Column(TypeName = "int")]
        public int GoodsSpecId { get; set; }
        [Key]
        [Column(TypeName = "datetime")]
        public DateTime ProposeDate { get; set; }
        [Column(TypeName = "money")]
        public double Price { get; set; }
        [Column(TypeName = "varchar(10)")]
        public string UpdateUser { get; set; }

        public virtual GoodsSpec Spec { get; set; }
    }
}
