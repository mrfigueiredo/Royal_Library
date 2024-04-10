using Royal_Library_Matheus_Figueiredo.Server.src.DataAccess.Models;
using Royal_Library_Matheus_Figueiredo.Server.src.DataAccess.Repository;
using Royal_Library_Matheus_Figueiredo.Server.src.Entities;

namespace Royal_Library_Matheus_Figueiredo.Server.src.BusinessLogic
{
    public interface IBLBooks
    {
        Task<IEnumerable<BookDTO>> GetAllBooks(string endpoint);

        Task<bool> AddBook(BookDTO entity, string endpoint);

        Task<bool> DeleteBook(int id, string endpoint);

        Task<bool> UpdateBook(BookDTO entity, string endpoint);

        Task<IEnumerable<BookDTO>> GetByAuthor(string author, string endpoint);

        Task<IEnumerable<BookDTO>> GetByCategory(string Category, string endpoint);

        Task<BookDTO> GetBookById(int id, string endpoint);

        Task<BookDTO> GetByISBN(string ISBN, string endpoint);

        Task<BookDTO> GetByTitle(string title, string endpoint);

        Task<IEnumerable<BookDTO>> GetByType(string type, string endpoint);
    }
}
