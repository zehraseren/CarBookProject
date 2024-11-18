using CB.Domain.Entities;
using CB.Application.Interfaces;
using CB.Application.Features.CQRS.Queries.ContactQueries;
using CB.Application.Features.CQRS.Results.ContactResults;

namespace CB.Application.Features.CQRS.Handlers.ContactHandlers
{
    public class GetContactByIdQueryHandler
    {
        private readonly IRepository<Contact> _repository;

        public GetContactByIdQueryHandler(IRepository<Contact> repository)
        {
            _repository = repository;
        }

        public async Task<GetContactByIdQueryResult> Handle(GetContactByIdQuery query)
        {
            var value = await _repository.GetByIdAsync(query.Id);
            return new GetContactByIdQueryResult
            {
                ContactId = value.ContactId,
                Name = value.Name
            };
        }
    }
}
