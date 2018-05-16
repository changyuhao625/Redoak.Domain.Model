using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Redoak.Domain.Model.Models
{
    public class Goods
    {
        public Goods()
        {
            GoodsSpecs = new HashSet<GoodsSpec>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GoodsId { get; set; }
        public string GoodsName { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UpdateUser { get; set; }
        public ICollection<GoodsSpec> GoodsSpecs { get; set; }

        [ForeignKey("GoodsCategoryId")]
        public string GoodsCategoryId { get; set; }
        public GoodsCategory Category { get; set; }
    }
}