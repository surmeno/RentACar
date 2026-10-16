using NArchitecture.Core.Application.Responses;

namespace Application.Features.Cars.Queries.GetById;

public class GetByIdCarResponse : IResponse
{
    public Guid Id { get; set; }
    public string BrandName { get; set; }
}