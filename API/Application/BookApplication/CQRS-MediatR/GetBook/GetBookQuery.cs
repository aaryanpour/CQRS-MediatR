using API.Data.Model;
using MediatR;

namespace API.Application.BookApplication.CQRS_MediatR.GetBook
{
    public class GetBookQuery : IRequest<Book>
    {
    }
}
