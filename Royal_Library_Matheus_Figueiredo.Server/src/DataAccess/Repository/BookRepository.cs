using Microsoft.EntityFrameworkCore;
using Royal_Library_Matheus_Figueiredo.Server.src.DataAccess.Models;
using System.Linq;

namespace Royal_Library_Matheus_Figueiredo.Server.src.DataAccess.Repository
{
    public class BookRepository : GenericRepository<Book>, IBookRepository
    {

        public BookRepository(DataContext context) : base(context)
        {
            _context = context;
            dbSet = _context.Set<Book>();
        }

        public async Task<IEnumerable<Book>> GetByAuthor(string author)
        {
            return await _context.Books.Where(x => (x.first_name + " " + x.last_name) == author).ToListAsync();
        }

        public async Task<IEnumerable<Book>> GetByCategory(string category)
        {
            return await _context.Books.Where(x => x.category == category).ToListAsync();
        }

        public async Task<Book> GetByISBN(string ISBN)
        {
            return await _context.Books.FirstAsync(x => x.isbn == ISBN);
        }

        public async Task<Book> GetByTitle(string title)
        {
            return await _context.Books.FirstAsync(x => x.title == title);
        }

        public async Task<IEnumerable<Book>> GetByType(string type)
        {
            return await _context.Books.Where(x => x.type == type).ToListAsync();
        }
    }
}
