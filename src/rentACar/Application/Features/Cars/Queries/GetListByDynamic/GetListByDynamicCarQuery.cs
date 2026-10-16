using Application.Features.Cars.Constants;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using NArchitecture.Core.Application.Pipelines.Caching;
using NArchitecture.Core.Application.Pipelines.Logging;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;
using NArchitecture.Core.Persistence.Dynamic;
using NArchitecture.Core.Persistence.Paging;

namespace Application.Features.Cars.Queries.GetListByDynamic;

public class GetListByDynamicCarQuery : IRequest<GetListResponse<GetListByDynamicCarListItemDto>>
{
    public PageRequest PageRequest { get; set; }
    public DynamicQuery Dynamic { get; set; }

    
    

    public class GetListByDynamicCarQueryHandler : IRequestHandler<GetListByDynamicCarQuery, GetListResponse<GetListByDynamicCarListItemDto>>
    {
        private readonly ICarRepository _carRepository;
        private readonly IMapper _mapper;

        public GetListByDynamicCarQueryHandler(ICarRepository carRepository, IMapper mapper)
        {
            _carRepository = carRepository;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicCarListItemDto>> Handle(GetListByDynamicCarQuery request, CancellationToken cancellationToken)
        {
            IPaginate<Car> cars = await _carRepository.GetListByDynamicAsync(
                dynamic: request.Dynamic,
                index: request.PageRequest.PageIndex,
                size: request.PageRequest.PageSize,
                cancellationToken: cancellationToken
            );

            GetListResponse<GetListByDynamicCarListItemDto> response = _mapper.Map<GetListResponse<GetListByDynamicCarListItemDto>>(cars);
            return response;
        }
    }
}
