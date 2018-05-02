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

        public string Name { get; set; }
        public DateTime DateCreate { get; set; }
        public DateTime DateUpdate { get; set; }
        public DateTime UpdateUser { get; set; }
        public ICollection<Goods> Goods { get; set; }
    }
}