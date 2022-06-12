using API.Data.Model;

namespace API.Application.BookApplication.GetBook
{
    public interface IGetBookQueryHandler
    {
        IQueryable<Book> GetBook();
    }
}
