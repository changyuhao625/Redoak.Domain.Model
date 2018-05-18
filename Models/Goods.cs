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
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        [Column(TypeName = "nvarchar(10)")]
        public string UpdateUser { get; set; }
        public virtual ICollection<GoodsSpec> GoodsSpecs { get; set; }

        public int GoodsCategoryId { get; set; }
        public virtual GoodsCategory Category { get; set; }
    }
}
