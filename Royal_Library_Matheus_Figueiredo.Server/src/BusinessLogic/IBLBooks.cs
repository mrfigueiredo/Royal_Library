using Royal_Library_Matheus_Figueiredo.Server.src.DataAccess.Models;
using Royal_Library_Matheus_Figueiredo.Server.src.DataAccess.Repository;
using Royal_Library_Matheus_Figueiredo.Server.src.Entities;

namespace Royal_Library_Matheus_Figueiredo.Server.src.BusinessLogic
{
    public interface IBLBooks
    {
        Task<IEnumerable<BookDTO>> GetAllBooks();

        Task<bool> AddBook(BookDTO entity);

        Task<bool> DeleteBook(int id);

        Task<bool> UpdateBook(BookDTO entity);

        Task<IEnumerable<BookDTO>> GetByAuthor(string author);

        Task<IEnumerable<BookDTO>> GetByCategory(string Category);

        Task<BookDTO> GetBookById(int id);

        Task<BookDTO> GetByISBN(string ISBN);

        Task<BookDTO> GetByTitle(string title);

        Task<IEnumerable<BookDTO>> GetByType(string type);
    }
}
