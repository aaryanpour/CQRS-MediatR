using API.Data.Model;
using MediatR;

namespace API.Application.BookApplication.GetBookById;

public class GetBookByIdRequest : IRequest<Book>
{
    public long BookId { get; set; }
}
