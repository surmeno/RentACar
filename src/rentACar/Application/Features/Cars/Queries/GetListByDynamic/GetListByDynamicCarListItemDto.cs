using NArchitecture.Core.Application.Dtos;

namespace Application.Features.Cars.Queries.GetListByDynamic;

public class GetListByDynamicCarListItemDto : IDto
{
    public string BrandName { get; set; }
}
