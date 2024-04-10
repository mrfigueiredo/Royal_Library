namespace Royal_Library_Matheus_Figueiredo.Server.src.Entities
{
    public class LibraryEventDTO
    {
        public string Endpoint { get; set; }
            
        public DateTime RequestTime { get; set; }

        public object Data { get; set; }
    }
}
