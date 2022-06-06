using API.Data.Model;
using API.Data.Repositories.BookRepository;
using MediatR;

namespace API.Application.BookApplication.GetBookById
{
    public class GetBookByRequestHandler : IRequestHandler<GetBookByIdRequest, Book>
    {
        private IBookRepository _bookRepository;

        public GetBookByRequestHandler(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public Task<Book> Handle(GetBookByIdRequest request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_bookRepository.GetBookById(request.BookId));
        }
    }
}
