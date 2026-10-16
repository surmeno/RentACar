using NArchitecture.Core.Application.Responses;

namespace Application.Features.Cars.Commands.Update;

public class UpdatedCarResponse : IResponse
{
    public Guid Id { get; set; }
    public string BrandName { get; set; }
}