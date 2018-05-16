using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Redoak.Domain.Model.Models
{
    public class Quotation
    {
        [Key]
        [ForeignKey("GoodsSpecId")]
        public int GoodsSpecId { get; set; }
        [Key]
        public DateTime ProposeDate { get; set; }
        public double Price { get; set; }
        public string UpdateUser { get; set; }

        public GoodsSpec GoodsSpec { get; set; }
    }
}
