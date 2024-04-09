using System.ComponentModel.DataAnnotations;

namespace Royal_Library_Matheus_Figueiredo.Server.src.DataAccess.Models
{
    public class Book
    {
        [Key]
        public int book_id { get; set; }
        public string title { get; set; } = string.Empty;
        public string first_name { get; set; } = string.Empty;
        public string last_name { get; set; } = string.Empty;
        public int total_copies { get; set; }
        public int copies_in_use { get; set; }
        public string type { get; set; } = string.Empty;
        public string isbn { get; set; } = string.Empty;
        public string category { get; set; } = string.Empty;


    }
}
