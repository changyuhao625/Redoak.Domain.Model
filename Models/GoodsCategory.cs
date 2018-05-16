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
        public int GoodsCategoryId { get; set; }
        public string GoodsCategoryName { get; set; }
        public string ParentCategoryId { get; set; }
        public string Note { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UpdateUser { get; set; }

        public ICollection<Goods> Goods { get; set; }
    }
}