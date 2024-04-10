namespace Royal_Library_Matheus_Figueiredo.Server.src.Events
{
    public class LibraryEventArgs : EventArgs
    {
        public string MessageTopic { get; set; }
        public object Data { get; set; }
    }
}
