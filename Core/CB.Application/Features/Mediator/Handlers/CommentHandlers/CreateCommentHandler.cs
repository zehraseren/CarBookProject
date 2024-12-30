using MediatR;
using CB.Domain.Entities;
using CB.Application.Interfaces;
using CB.Application.Features.Mediator.Commands.CommentCommands;

namespace CB.Application.Features.Mediator.Handlers.CommentHandlers
{
    public class CreateCommentHandler : IRequestHandler<CreateCommentCommand>
    {
        private readonly IRepository<Comment> _repository;

        public CreateCommentHandler(IRepository<Comment> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateCommentCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Comment
            {
                Name = request.Name,
                CreatedDate = DateTime.Parse(DateTime.Now.ToShortDateString()),
                Content = request.Content,
                BlogId = request.BlogId,
                Email = request.Email,
            });
        }
    }
}
