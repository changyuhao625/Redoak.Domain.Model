using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Redoak.Domain.Model.Models
{
    public class GoodsSpec
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GoodsSpecId { get; set; }
        public string GoodsSpecName { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UpdateUser { get; set; }

        [ForeignKey("GoodsId")]
        public string GoodsId { get; set; }
        public Goods Goods { get; set; }
    }
}