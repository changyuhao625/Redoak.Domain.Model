using System;
using KendoGridBinder;

namespace Redoak.Domain.Model.Dto
{
    public class StockQueryDto : KendoGridBaseRequest
    {
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }

        public string Name { get; set; }

        public int CategoryId { get; set; }

        public int Id { get; set; }
    }
}