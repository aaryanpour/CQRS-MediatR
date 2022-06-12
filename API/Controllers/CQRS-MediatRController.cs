using API.Application.BookApplication.CQRS_MediatR.GetBook;
using API.Application.BookApplication.CQRS_MediatR.MakeBook;
using API.Data.Model;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CQRS_MediatRController : ControllerBase
    {
        private IMediator _mediator;
        public CQRS_MediatRController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("GetBook")]
        public async Task<IActionResult> GetBook()
        {
            Book book = await _mediator.Send(new GetBookQuery { });

            if (book == null)
                return NotFound();

            return Ok(book);
        }

        [HttpPost("MakeBook")]
        public async Task<IActionResult> MakeBook()
        {
            MakeBookResponse book = await _mediator.Send(new MakeBookCommand { });

            if (book == null)
                return NotFound();

            return Ok(book);
        }

    }
}
