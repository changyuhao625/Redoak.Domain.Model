using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Redoak.Domain.Model.Models
{
    public class Purchase
    {
        public int PurchaseId { get; set; }
        public string PurchaseName { get; set; }
    }
}
