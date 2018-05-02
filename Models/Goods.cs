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
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public DateTime DateCreate { get; set; }
        public DateTime DateUpdate { get; set; }
        public string UpdateUser { get; set; }
        public ICollection<GoodsSpec> GoodsSpecs { get; set; }
        public GoodsCategory Category { get; set; }
    }
}