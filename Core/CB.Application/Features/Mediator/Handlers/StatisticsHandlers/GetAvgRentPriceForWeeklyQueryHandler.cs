﻿using MediatR;
using CB.Application.Interfaces.StaticticsInterfaces;
using CB.Application.Features.Mediator.Queries.StatisticsQueries;
using CB.Application.Features.Mediator.Results.StatisticsResults;

namespace CB.Application.Features.Mediator.Handlers.StatisticsHandlers
{
    public class GetAvgRentPriceForWeeklyQueryHandler : IRequestHandler<GetAvgRentPriceForWeeklyQuery, GetAvgRentPriceForWeeklyQueryResult>
    {
        private readonly IStaticticsRepository _repository;

        public GetAvgRentPriceForWeeklyQueryHandler(IStaticticsRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetAvgRentPriceForWeeklyQueryResult> Handle(GetAvgRentPriceForWeeklyQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetAvgRentPriceForWeekly();
            return new GetAvgRentPriceForWeeklyQueryResult
            {
                AvgRentPriceForWeekly = value,
            };
        }
    }
}