using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Redoak.Domain.Model.Models
{
    public class GoodsSpec
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateCreate { get; set; }
        public DateTime DateUpdate { get; set; }
        public DateTime UpdateUser { get; set; }

        public Goods Goods { get; set; }
    }
}