using API.Application.BookApplication.GetBookById;
using API.Data.Model;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BookController : ControllerBase
{
    private IMediator _mediator;

    public BookController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("GetBook")]
    public async Task<IActionResult> GetBookById(long id)
    {
        Book book = await _mediator.Send(new GetBookByIdRequest { BookId = id });

        if (book == null)
            return NotFound();

        return Ok(book);
    }
}
