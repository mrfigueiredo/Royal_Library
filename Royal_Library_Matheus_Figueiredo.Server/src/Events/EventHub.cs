using Royal_Library_Matheus_Figueiredo.Server.src.Entities;

namespace Royal_Library_Matheus_Figueiredo.Server.src.Events
{
    public class EventHub : BackgroundService
    {
        private readonly ILogger<EventHub> _logger;
        public EventHub(ILogger<EventHub> logger)
        {
            _logger = logger;

        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            EventManager.Instance.OnEventPublishedEvent += e_OnEventPublished;
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("EventMessageHub running at: {time}", DateTimeOffset.Now);

            }
        }

        static void e_OnEventPublished(object sender, LibraryEventArgs e)
        {
            switch (e.MessageTopic)
            {
                case "royalLibraryPublicAPI":
                    var data = (LibraryEventDTO)e.Data;
                    break;
                default:
                    break;
            };
        }
    }
}
