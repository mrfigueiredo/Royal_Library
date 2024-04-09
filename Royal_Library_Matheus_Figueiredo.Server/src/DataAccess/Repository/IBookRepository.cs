using Royal_Library_Matheus_Figueiredo.Server.src.DataAccess.Models;

namespace Royal_Library_Matheus_Figueiredo.Server.src.DataAccess.Repository
{
    public interface IBookRepository : IGenericRepository<Book>
    {
        Task<Book> GetByTitle(string title);
        Task<IEnumerable<Book>> GetByAuthor(string author);
        Task<Book> GetByISBN(string ISBN);
        Task<IEnumerable<Book>> GetByType(string type);
        Task<IEnumerable<Book>> GetByCategory(string category);

    }
}
