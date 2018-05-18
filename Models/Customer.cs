using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Redoak.Domain.Model.Models
{
    public class Customer
    {
        [Key]
        [Column(TypeName = "int")]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string Name { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string ContactPerson { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Address { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string ContactEmail { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string ContactPhone { get; set; }

        public int RegionId { get; set; }
        public virtual Region Region { get; set; }
    }
}
