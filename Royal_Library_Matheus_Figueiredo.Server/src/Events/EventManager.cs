namespace Royal_Library_Matheus_Figueiredo.Server.src.Events
{
    public class EventManager
    {
        public event EventHandler<LibraryEventArgs> OnEventPublishedEvent;
        
        private static readonly EventManager _instance = new EventManager();
        static EventManager()
        {

        }
        private EventManager()
        {

        }

        public static EventManager Instance { get { return _instance; } }

        protected virtual void OnEventPublished(LibraryEventArgs e)
        {
            EventHandler<LibraryEventArgs> handler = OnEventPublishedEvent;
            if (handler != null)
            {
                handler(this, e);
                Console.WriteLine(e);
            }
        }

        public void PublishEvent(string messageTopic, object? data)
        {
            LibraryEventArgs args = new LibraryEventArgs();
            args.MessageTopic = messageTopic;
            args.Data = data;
            OnEventPublished(args);
        }
    }
}
