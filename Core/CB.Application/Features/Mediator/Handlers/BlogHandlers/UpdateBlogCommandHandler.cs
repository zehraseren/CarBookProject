using MediatR;
using CB.Domain.Entities;
using CB.Application.Interfaces;
using CB.Application.Features.Mediator.Commands.BlogCommands;

namespace CB.Application.Features.Mediator.Handlers.BlogHandlers
{
    public class UpdateBlogCommandHandler : IRequestHandler<UpdateBlogCommand>
    {
        private readonly IRepository<Blog> _repository;

        public UpdateBlogCommandHandler(IRepository<Blog> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateBlogCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.BlogId);
            value.Title = request.Title;
            value.AuthorId = request.AuthorId;
            value.CoverImageUrl = request.CoverImageUrl;
            value.CreatedDate = request.CreatedDate;
            value.CategoryId = request.CategoryId;
            await _repository.UpdateAsync(value);
        }
    }
}
