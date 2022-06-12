using API.Data.Model;
using MediatR;

namespace API.Application.BookApplication.CQRS_MediatR.MakeBook
{
    public class MakeBookCommand : IRequest<MakeBookResponse>
    {
    }
}
