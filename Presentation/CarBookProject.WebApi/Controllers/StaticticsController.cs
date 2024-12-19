using MediatR;
using Microsoft.AspNetCore.Mvc;
using CB.Application.Features.Mediator.Queries.StatisticsQueries;

namespace CB.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaticticsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StaticticsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("GetCarCount")]
        public async Task<IActionResult> GetCarCount()
        {
            var values = await _mediator.Send(new GetCarCountQuery());
            return Ok(values);
        }

        [HttpGet("GetBlogCount")]
        public async Task<IActionResult> GetBlogCount()
        {
            var values = await _mediator.Send(new GetBlogCountQuery());
            return Ok(values);
        }

        [HttpGet("GetLocationCount")]
        public async Task<IActionResult> GetLocationCount()
        {
            var values = await _mediator.Send(new GetLocationCountQuery());
            return Ok(values);
        }

        [HttpGet("GetAuthorCount")]
        public async Task<IActionResult> GetAuthorCount()
        {
            var values = await _mediator.Send(new GetAuthorCountQuery());
            return Ok(values);
        }

        [HttpGet("GetBrandCount")]
        public async Task<IActionResult> GetBrandCount()
        {
            var values = await _mediator.Send(new GetBrandCountQuery());
            return Ok(values);
        }

        [HttpGet("GetAvgRentPriceForDaily")]
        public async Task<IActionResult> GetAvgRentPriceForDaily()
        {
            var values = await _mediator.Send(new GetAvgRentPriceForDailyQuery());
            return Ok(values);
        }

        [HttpGet("GetAvgRentPriceForWeekly")]
        public async Task<IActionResult> GetAvgRentPriceForWeekly()
        {
            var values = await _mediator.Send(new GetAvgRentPriceForWeeklyQuery());
            return Ok(values);
        }

        [HttpGet("GetAvgRentPriceForMonthly")]
        public async Task<IActionResult> GetAvgRentPriceForMonthly()
        {
            var values = await _mediator.Send(new GetAvgRentPriceForMonthlyQuery());
            return Ok(values);
        }

        [HttpGet("GetCarCountByTransmissionIsAuto")]
        public async Task<IActionResult> GetCarCountByTransmissionIsAuto()
        {
            var values = await _mediator.Send(new GetCarCountByTransmissionIsAutoQuery());
            return Ok(values);
        }

        [HttpGet("GetBrandNameByMaxCarCount")]
        public async Task<IActionResult> GetBrandNameByMaxCarCount()
        {
            var values = await _mediator.Send(new GetBrandNameByMaxCarCountQuery());
            return Ok(values);
        }

        [HttpGet("GetBlogTitleByMaxBlogComment")]
        public async Task<IActionResult> GetBlogTitleByMaxBlogComment()
        {
            var values = await _mediator.Send(new GetBlogTitleByMaxBlogCommentQuery());
            return Ok(values);
        }

        [HttpGet("GetCarCountByMileageLessThan10000")]
        public async Task<IActionResult> GetCarCountByMileageLessThan10000()
        {
            var values = await _mediator.Send(new GetCarCountByMileageLessThan10000Query());
            return Ok(values);
        }

        [HttpGet("GetCountByFuelGasolineOrDiesel")]
        public async Task<IActionResult> GetCountByFuelGasolineOrDiesel()
        {
            var values = await _mediator.Send(new GetCountByFuelGasolineOrDieselQuery());
            return Ok(values);
        }

        [HttpGet("GetCountByFuelElectric")]
        public async Task<IActionResult> GetCountByFuelElectric()
        {
            var values = await _mediator.Send(new GetCountByFuelElectricQuery());
            return Ok(values);
        }

        [HttpGet("GetCarBrandAndModelByRentPriceForDailyMax")]
        public async Task<IActionResult> GetCarBrandAndModelByRentPriceForDailyMax()
        {
            var values = await _mediator.Send(new GetCarBrandAndModelByRentPriceForDailyMaxQuery());
            return Ok(values);
        }

        [HttpGet("GetCarBrandAndModelByRentPriceForDailyMin")]
        public async Task<IActionResult> GetCarBrandAndModelByRentPriceForDailyMin()
        {
            var values = await _mediator.Send(new GetCarBrandAndModelByRentPriceForDailyMinQuery());
            return Ok(values);
        }
    }
}
