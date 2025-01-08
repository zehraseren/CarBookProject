using MediatR;
using Microsoft.AspNetCore.Mvc;
using CB.Application.Features.Mediator.Commands.ReviewCommands;
using CB.Application.Features.Mediator.Queries.ReviewQueries;

namespace CB.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ReviewsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> ReviewListByCarId(int id)
        {
            var values = await _mediator.Send(new GetReviewByCarIdQuery(id));
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateReview(CreateReviewCommand command)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await _mediator.Send(command);
            return Ok("Ekleme işlemi başarılı");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateReview(UpdateReviewCommand command)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await _mediator.Send(command);
            return Ok("Güncelleme işlemi başarılı");
        }
    }
}
