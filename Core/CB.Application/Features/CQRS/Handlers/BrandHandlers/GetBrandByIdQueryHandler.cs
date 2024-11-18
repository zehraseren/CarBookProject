using CB.Domain.Entities;
using CB.Application.Interfaces;
using CB.Application.Features.CQRS.Results.BrandResults;
using CB.Application.Features.CQRS.Queries.BrandQueries;

namespace CB.Application.Features.CQRS.Handlers.BrandHandlers
{
    public class GetBrandByIdQueryHandler
    {
        private readonly IRepository<Brand> _repository;

        public GetBrandByIdQueryHandler(IRepository<Brand> repository)
        {
            _repository = repository;
        }

        public async Task<GetBrandByIdQueryResult> Handle(GetBrandByIdQuery query)
        {
            var value = await _repository.GetByIdAsync(query.Id);
            return new GetBrandByIdQueryResult
            {
                BrandId = value.BrandId,
                Name = value.Name,
            };
        }
    }
}
