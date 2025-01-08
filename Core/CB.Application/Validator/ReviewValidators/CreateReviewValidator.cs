using FluentValidation;
using CB.Application.Features.Mediator.Commands.ReviewCommands;

namespace CB.Application.Validator.ReviewValidators
{
    public class CreateReviewValidator : AbstractValidator<CreateReviewCommand>
    {
        public CreateReviewValidator()
        {
            RuleFor(x => x.CustomerName)
                .NotEmpty()
                .WithMessage("Lütfen müşteri adını boş geçmeyiniz!")
                .MinimumLength(5)
                .WithMessage("Lütfen en 5 karakter veri girişi yapınız");
            RuleFor(x => x.RatingValue)
                .NotEmpty().
                WithMessage("Lütfen puan değerini boş geçmeyiniz!");
            RuleFor(x => x.Comment)
                .NotEmpty()
                .WithMessage("Lütfen yorum kısmını boş geçmeyiniz")
                .MinimumLength(50)
                .WithMessage("Lütfen yorum kısmına en az 50 karakter veri girişi yapınız")
                .MaximumLength(500)
                .WithMessage("Lütfen yorum kısmına en fazla 500 karakter veri girişi yapınız");
        }
    }
}
