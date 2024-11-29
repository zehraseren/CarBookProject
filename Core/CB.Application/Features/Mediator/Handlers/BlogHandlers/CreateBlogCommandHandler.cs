using MediatR;
using CB.Domain.Entities;
using CB.Application.Interfaces;
using CB.Application.Features.Mediator.Commands.BlogCommands;

namespace CB.Application.Features.Mediator.Handlers.BlogHandlers
{
    public class CreateBlogCommandHandler : IRequestHandler<CreateBlogCommand>
    {
        public readonly IRepository<Blog> _repository;

        public CreateBlogCommandHandler(IRepository<Blog> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateBlogCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Blog
            {
                Title = request.Title,
                AuthorId = request.AuthorId,
                CoverImageUrl = request.CoverImageUrl,
                CreatedDate = request.CreatedDate,
                CategoryId = request.CategoryId,
            });
        }
    }
}
