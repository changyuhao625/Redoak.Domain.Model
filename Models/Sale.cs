using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Redoak.Domain.Model.Models
{
    public class Sale
    {
        public int SaleId { get; set; }
        public string SaleName { get; set; }
    }
}
