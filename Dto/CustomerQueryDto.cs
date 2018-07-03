using KendoGridBinder;

namespace Redoak.Domain.Model.Dto
{
    public class CustomerQueryDto : KendoGridBaseRequest
    {
        public string Name { get; set; }
    }
}