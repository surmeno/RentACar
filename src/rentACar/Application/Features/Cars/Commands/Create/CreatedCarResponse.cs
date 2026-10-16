using NArchitecture.Core.Application.Responses;

namespace Application.Features.Cars.Commands.Create;

public class CreatedCarResponse : IResponse
{
    public Guid Id { get; set; }
    public string BrandName { get; set; }
}