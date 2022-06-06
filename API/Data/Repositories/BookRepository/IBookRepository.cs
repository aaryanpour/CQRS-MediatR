using API.Data.Model;

namespace API.Data.Repositories.BookRepository;

public interface IBookRepository
{
    List<Book> GetAllBooks();
    Book GetBookById(long id);
    bool AddBook(Book book);
}
