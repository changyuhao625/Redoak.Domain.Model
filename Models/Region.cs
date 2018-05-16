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
        public int RegionId { get; set; }
        public string RegionName { get; set; }
        public string ParentRegion { get; set; }
        public string UpdateUser { get; set; }
        public DateTime UpdateDate { get; set; }
        public ICollection<Customer> Customers { get; set; }
    }    
}