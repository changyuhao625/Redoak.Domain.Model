using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Redoak.Domain.Model.Models
{
    public class GoodsCategory
    {
        public GoodsCategory()
        {
            Goods = new HashSet<Goods>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string Name { get; set; }
        [Column(TypeName = "int")]
        public int ParentCategoryId { get; set; }
        [Column(TypeName = "nvarchar(400)")]
        public string Note { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        [Column(TypeName = "nvarchar(10)")]
        public string UpdateUser { get; set; }

        public virtual ICollection<Goods> Goods { get; set; }
    }
}
