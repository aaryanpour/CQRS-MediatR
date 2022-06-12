using API.Application.BookApplication.GetBook;
using API.Application.BookApplication.MakeBook;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CQRSBookController : ControllerBase
    {
        private readonly IGetBookQueryHandler _getBookQueryHandler;
        private readonly IMakeBookCommandHandler _makeBookCommandHandler;

        public CQRSBookController(IGetBookQueryHandler getBookQueryHandler, IMakeBookCommandHandler makeBookCommandHandler)
        {
            _getBookQueryHandler = getBookQueryHandler;
            _makeBookCommandHandler = makeBookCommandHandler;
        }

        [HttpGet("GetBook")]
        public IActionResult GetBook() => Ok(_getBookQueryHandler.GetBook());

        [HttpPost("MakeBook")]
        public IActionResult MakeBook() => Ok(_makeBookCommandHandler.MakeBook());
    }
}
