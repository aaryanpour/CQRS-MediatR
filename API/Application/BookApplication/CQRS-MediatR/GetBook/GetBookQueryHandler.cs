using API.Data.Model;
using MediatR;

namespace API.Application.BookApplication.CQRS_MediatR.GetBook
{
    public class GetBookQueryHandler : IRequestHandler<GetBookQuery, Book>
    {
        public Task<Book> Handle(GetBookQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
