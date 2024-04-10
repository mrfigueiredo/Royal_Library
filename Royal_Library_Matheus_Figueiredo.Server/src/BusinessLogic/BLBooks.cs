using Royal_Library_Matheus_Figueiredo.Server.src.DataAccess.Repository;
using Royal_Library_Matheus_Figueiredo.Server.src.DataAccess.Utils;
using Royal_Library_Matheus_Figueiredo.Server.src.Entities;
using Royal_Library_Matheus_Figueiredo.Server.src.Events;
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

        public Task<bool> AddBook(BookDTO entity, string endpoint)
        {

            var eventDto = new LibraryEventDTO
            {
                Endpoint = endpoint,
                RequestTime = DateTime.UtcNow,
                Data = entity
            };

            EventManager.Instance.PublishEvent("royalLibraryPublicAPI", eventDto);

            return _repository.Add(entity.FromBookDTO());
        }

        public async Task<IEnumerable<BookDTO>> GetAllBooks(string endpoint)
        {

            var books = await _repository.All();
            
            var eventDto = new LibraryEventDTO
            {
                Endpoint = endpoint,
                RequestTime = DateTime.UtcNow,
                Data = books
            };

            EventManager.Instance.PublishEvent("royalLibraryPublicAPI", eventDto);

            return books.Select(book => book.ToBookDTO()).ToList();
        }

        public async Task<bool> DeleteBook(int id, string endpoint)
        {
            var eventDto = new LibraryEventDTO
            {
                Endpoint = endpoint,
                RequestTime = DateTime.UtcNow,
                Data = id
            };

            EventManager.Instance.PublishEvent("royalLibraryPublicAPI", eventDto);
            return await _repository.Delete(id);
        }

        public async Task<IEnumerable<BookDTO>> GetByAuthor(string author, string endpoint)
        {
            var books = await _repository.GetByAuthor(author);

            var eventDto = new LibraryEventDTO
            {
                Endpoint = endpoint,
                RequestTime = DateTime.UtcNow,
                Data = books
            };

            EventManager.Instance.PublishEvent("royalLibraryPublicAPI", eventDto);

            return books.Select(book => book.ToBookDTO()).ToList();
        }

        public async Task<IEnumerable<BookDTO>> GetByCategory(string category, string endpoint)
        {
            var books = await _repository.GetByCategory(category);

            var eventDto = new LibraryEventDTO
            {
                Endpoint = endpoint,
                RequestTime = DateTime.UtcNow,
                Data = books
            };

            EventManager.Instance.PublishEvent("royalLibraryPublicAPI", eventDto);

            return books.Select(book => book.ToBookDTO()).ToList();
        }

        public async Task<BookDTO> GetBookById(int id, string endpoint)
        {
            var book = await _repository.GetById(id);

            var eventDto = new LibraryEventDTO
            {
                Endpoint = endpoint,
                RequestTime = DateTime.UtcNow,
                Data = book
            };

            EventManager.Instance.PublishEvent("royalLibraryPublicAPI", eventDto);

            return book.ToBookDTO();
        }

        public async Task<BookDTO> GetByISBN(string ISBN, string endpoint)
        {
            var book = await _repository.GetByISBN(ISBN);

            var eventDto = new LibraryEventDTO
            {
                Endpoint = endpoint,
                RequestTime = DateTime.UtcNow,
                Data = book
            };

            EventManager.Instance.PublishEvent("royalLibraryPublicAPI", eventDto);

            return book.ToBookDTO();
        }

        public async Task<BookDTO> GetByTitle(string title, string endpoint)
        {
            var book = await _repository.GetByTitle(title);

            var eventDto = new LibraryEventDTO
            {
                Endpoint = endpoint,
                RequestTime = DateTime.UtcNow,
                Data = book
            };

            EventManager.Instance.PublishEvent("royalLibraryPublicAPI", eventDto);

            return book.ToBookDTO();
        }

        public async Task<IEnumerable<BookDTO>> GetByType(string type, string endpoint)
        {
            var books = await _repository.GetByType(type);

            var eventDto = new LibraryEventDTO
            {
                Endpoint = endpoint,
                RequestTime = DateTime.UtcNow,
                Data = books
            };

            EventManager.Instance.PublishEvent("royalLibraryPublicAPI", eventDto);

            return books.Select(book => book.ToBookDTO()).ToList();
        }

        public async Task<bool> UpdateBook(BookDTO entity, string endpoint)
        {
            var eventDto = new LibraryEventDTO
            {
                Endpoint = endpoint,
                RequestTime = DateTime.UtcNow,
                Data = entity
            };

            EventManager.Instance.PublishEvent("royalLibraryPublicAPI", eventDto);

            return await _repository.Update(entity.FromBookDTO());
        }

    }
}
