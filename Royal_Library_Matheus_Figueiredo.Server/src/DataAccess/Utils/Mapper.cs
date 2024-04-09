using Royal_Library_Matheus_Figueiredo.Server.src.DataAccess.Models;
using Royal_Library_Matheus_Figueiredo.Server.src.Entities;

namespace Royal_Library_Matheus_Figueiredo.Server.src.DataAccess.Utils
{
    public static class BookMapper
    {

            public static BookDTO ToBookDTO(this Book book)
            {
                return new BookDTO
                {
                    Id = book.book_id,
                    title = book.title,
                    type = book.type,
                    author = book.first_name + " " + book.last_name,
                    category = book.category,
                    isbn = book.isbn,
                    copies_in_use = book.copies_in_use,
                    total_copies = book.total_copies
                };
            }

            public static Book FromBookDTO(this BookDTO bookDTO)
            {
                string[] name_split = bookDTO.author.Split();
                return new Book
                {
                    book_id = bookDTO.Id,
                    title = bookDTO.title,
                    type = bookDTO.type,
                    first_name = name_split[0],
                    last_name = name_split[1],
                    category = bookDTO.category,
                    isbn = bookDTO.isbn,
                    copies_in_use = bookDTO.copies_in_use,
                    total_copies = bookDTO.total_copies
                };
            }
        
    }
}
