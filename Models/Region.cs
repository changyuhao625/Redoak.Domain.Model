using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Redoak.Domain.Model.Models
{
    public class Region
    {
        public Region()
        {
            Customers = new HashSet<Customer>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string Name { get; set; }
        [Column(TypeName = "int")]
        public int ParentRegionId { get; set; }
        [Column(TypeName = "varchar(10)")]
        public string UpdateUser { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime UpdateDate { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
    }
}