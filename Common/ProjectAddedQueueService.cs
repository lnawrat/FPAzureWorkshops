using System.IO;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ServiceBus.Messaging;

namespace Common
{
    public class ProjectAddedQueueService
    {
        private const string QueueName = "projectadded";
        private readonly QueueClient _queueClient;
        private readonly ConstructionsProgressTrackerContext _context;

        public ProjectAddedQueueService(string serviceBusConnectionString)
        {
            _queueClient = QueueClient.CreateFromConnectionString(serviceBusConnectionString, QueueName);
            _context = new ConstructionsProgressTrackerContext();
        }

        public void Register()
        {
            _queueClient.OnMessageAsync(async message =>
            {
                await ProcessMessagesAsync(message);

                await message.CompleteAsync();
            },
            new OnMessageOptions
            {
                MaxConcurrentCalls = 1,
                AutoComplete = false
            });
        }

        private async Task ProcessMessagesAsync(BrokeredMessage message)
        {
            var messageBodyStream = message.GetBody<Stream>();
            string messageBody;
            using (TextReader reader = new StreamReader(messageBodyStream, Encoding.UTF8))
            {
                messageBody = await reader.ReadToEndAsync();
            }

            _context.ConstructionProjects.Add(new ConstructionProject
            {
                Name = messageBody,
                Notes = "From Service Bus message."
            });

            await _context.SaveChangesAsync();
        }
    }
}
