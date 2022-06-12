using API.Data.Model;
using MediatR;

namespace API.Application.BookApplication.CQRS_MediatR.MakeBook
{
    public class MakeBookCommandHandler : IRequestHandler<MakeBookCommand, MakeBookResponse>
    {
        public Task<MakeBookResponse> Handle(MakeBookCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
