using NArchitecture.Core.Application.Dtos;

namespace Application.Features.Cars.Queries.GetList;

public class GetListCarListItemDto : IDto
{
    public Guid Id { get; set; }
    public string BrandName { get; set; }
}