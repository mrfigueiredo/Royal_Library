using Royal_Library_Matheus_Figueiredo.Server.src.DataAccess.Repository;
using Royal_Library_Matheus_Figueiredo.Server.src.DataAccess.Utils;
using Royal_Library_Matheus_Figueiredo.Server.src.Entities;
using System.Linq;

namespace Royal_Library_Matheus_Figueiredo.Server.src.BusinessLogic
{
    public class BLBooks : IBLBooks
    {
        private IBookRepository _repository;

        public BLBooks(IBookRepository bookRepository)
        {
            _repository = bookRepository;
        }

        public Task<bool> AddBook(BookDTO entity)
        {
            return _repository.Add(entity.FromBookDTO());
        }

        public async Task<IEnumerable<BookDTO>> GetAllBooks()
        {
            var books = await _repository.All();

            return books.Select(book => book.ToBookDTO()).ToList();
        }

        public async Task<bool> DeleteBook(int id)
        {
            return await _repository.Delete(id);
        }

        public async Task<IEnumerable<BookDTO>> GetByAuthor(string author)
        {
            var books = await _repository.GetByAuthor(author);

            return books.Select(book => book.ToBookDTO()).ToList();
        }

        public async Task<IEnumerable<BookDTO>> GetByCategory(string category)
        {
            var books = await _repository.GetByCategory(category);

            return books.Select(book => book.ToBookDTO()).ToList();
        }

        public async Task<BookDTO> GetBookById(int id)
        {
            var book = await _repository.GetById(id);

            return book.ToBookDTO();
        }

        public async Task<BookDTO> GetByISBN(string ISBN)
        {
            var book = await _repository.GetByISBN(ISBN);

            return book.ToBookDTO();
        }

        public async Task<BookDTO> GetByTitle(string title)
        {
            var book = await _repository.GetByTitle(title);

            return book.ToBookDTO();
        }

        public async Task<IEnumerable<BookDTO>> GetByType(string type)
        {
            var books = await _repository.GetByType(type);

            return books.Select(book => book.ToBookDTO()).ToList();
        }

        public async Task<bool> UpdateBook(BookDTO entity)
        {
            return await _repository.Update(entity.FromBookDTO());
        }
    }
}
