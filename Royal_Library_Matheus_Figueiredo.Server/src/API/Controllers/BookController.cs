
using Microsoft.AspNetCore.Mvc;
using Royal_Library_Matheus_Figueiredo.Server.src.Entities;
using Royal_Library_Matheus_Figueiredo.Server.src.BusinessLogic;


namespace Royal_Library_Matheus_Figueiredo.Server.src.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly IBLBooks _blBooks;

        public BooksController(IBLBooks booksService)
        {
            _blBooks = booksService;
        }


        [HttpPost]
        public async Task<IActionResult> CreateBook([FromBody]BookDTO book) // 
        {
            if (ModelState.IsValid)
            {

                try
                {
                    await _blBooks.AddBook(book, HttpContext.Request.Path);
                    return CreatedAtAction(nameof(GetBookById), new { id = book.Id }, book);
                }
                catch (Exception e)
                {
                    return new JsonResult("Something went wrong") { StatusCode = 500 };
                }
            }

            return new JsonResult("Something went wrong") { StatusCode = 500 };
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetBookById(int id)
        {
            var book = await _blBooks.GetBookById(id, HttpContext.Request.Path);
            if (book == null)
            {
                return NotFound(new { status = 404, msg = "Book not found", date = DateTime.UtcNow });
            }
            return Ok(book);
        }


        [HttpGet]
        public async Task<IActionResult> GetAllBooks()
        {
            var books = await _blBooks.GetAllBooks(HttpContext.Request.Path);
            if (books == null)
            {
                return NotFound(new { status = 404, msg = "No books not found", date = DateTime.UtcNow });
            }
            return Ok(books);
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBook(int id, [FromBody]BookDTO book)
        {
            if (id != book.Id)
            {
                return BadRequest();
            }

            try
            {
                await _blBooks.UpdateBook(book, HttpContext.Request.Path);
                return NoContent();
            }
            catch (Exception ex)
            {
                return NotFound(new { status = 404, msg = ex.Message, date = DateTime.UtcNow });
            }

        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBook(int id)
        {
            var book = await _blBooks.GetBookById(id, HttpContext.Request.Path);
            if (book == null)
            {
                return NotFound();
            }

            try
            {
                await _blBooks.DeleteBook(id, HttpContext.Request.Path);
                return NoContent();
            }
            catch (Exception ex)
            {
                return new JsonResult("Something went wrong") { StatusCode = 500 };
            }

        }

        [HttpGet("author/{author}")]
        public async Task<IActionResult> GetBookByAuthor(string author)
        {
            var book = await _blBooks.GetByAuthor(author, HttpContext.Request.Path);
            if (book == null)
            {
                return NotFound(new { status = 404, msg = "Book not found", date = DateTime.UtcNow });
            }
            return Ok(book);
        }

        [HttpGet("category/{category}")]
        public async Task<IActionResult> GetBookByCategory(string category)
        {
            var book = await _blBooks.GetByCategory(category, HttpContext.Request.Path);
            if (book == null)
            {
                return NotFound(new { status = 404, msg = "Book not found", date = DateTime.UtcNow });
            }
            return Ok(book);
        }

        [HttpGet("isbn/{isbn}")]
        public async Task<IActionResult> GetBookByISBN(string isbn)
        {
            var book = await _blBooks.GetByISBN(isbn, HttpContext.Request.Path);
            if (book == null)
            {
                return NotFound(new { status = 404, msg = "Book not found", date = DateTime.UtcNow });
            }
            return Ok(book);
        }

        [HttpGet("title/{title}")]
        public async Task<IActionResult> GetBookByTitle(string title)
        {
            var book = await _blBooks.GetByTitle(title, HttpContext.Request.Path);
            if (book == null)
            {
                return NotFound(new { status = 404, msg = "Book not found", date = DateTime.UtcNow });
            }
            return Ok(book);
        }

        [HttpGet("type/{type}")]
        public async Task<IActionResult> GetBookByType(string type)
        {
            var book = await _blBooks.GetByType(type, HttpContext.Request.Path);
            
            if (book == null)
            {
                return NotFound(new { status = 404, msg = "Book not found", date = DateTime.UtcNow });
            }
            return Ok(book);
        }
    }

}
