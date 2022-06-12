using API.Data.Model;

namespace API.Application.BookApplication.MakeBook
{
    public interface IMakeBookCommandHandler
    {
        MakeBookResponse MakeBook();
    }
}
