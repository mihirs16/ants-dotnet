using System.Collections.Concurrent;
using Bogus;

namespace ants_dotnet;
public class Queen {
    public readonly int numAnts;
    public readonly int numMessages;
    public readonly CancellationTokenSource cancellationTokenSource;
    protected Dictionary<int, Ant> ants;
    private BlockingCollection<Message> buffer;
    private Queue<Message> messages;

    public Queen (int numAnts, int numMessages) {
        this.numAnts = numAnts;
        this.numMessages = numMessages;
        this.ants = new Dictionary<int, Ant>();
        this.buffer = new BlockingCollection<Message>(this.numMessages);
        this.messages = new Queue<Message>(this.numMessages);
        this.cancellationTokenSource = new CancellationTokenSource();

        Console.WriteLine("\n---------------------------");
        Console.WriteLine($"Spawning {numAnts} ants...");
        Console.WriteLine("---------------------------");
        for (int i = 0; i < numAnts; i++) {
            Faker faker = new Faker();
            this.ants[i] = new Ant(this, faker.Person.UserName, i);
        }

        List<Thread> threads = new List<Thread>();
        Console.WriteLine("\n---------------------------");
        Console.WriteLine("Starting ants' behaviour...");
        Console.WriteLine("---------------------------");
        for (int i = 0; i < numAnts; i++) {
            Thread thread = new Thread(this.ants[i].Behaviour);
            threads.Add(thread);
            thread.Start();
        }

        for (int i = 0; i < numMessages; i++) {
            Message eachMessage = buffer.Take();
            Console.WriteLine($"{eachMessage}");
            messages.Enqueue(eachMessage);
        }
        
        this.cancellationTokenSource.Cancel();
        for (int i = 0; i < numAnts; i++) {
            threads[i].Join();
        }
        return;
    }

    public Ant getAntFromId (int id) => this.ants[id];
    public void sendMessage (Message message) => this.buffer.Add(message);
    
    public void displayStats () {
        Console.WriteLine($"Number of ants: {this.numAnts}");
        Console.WriteLine($"Number of messages: {this.messages.Count}");

        IEnumerable<IGrouping<string, Message>> messagesGroupedBySender = 
            from message in this.messages
            group message by message.sender.name into groupedBySender
            select groupedBySender;

        IEnumerable<IGrouping<string, Message>> messagesGroupedByReceiver =
            from message in this.messages
            group message by message.receiver.name into groupedByReceiver
            select groupedByReceiver;

        Console.WriteLine("\n---------------------------");
        Console.WriteLine("Sent Messages");
        Console.WriteLine("---------------------------");
        foreach (var messageGroup in messagesGroupedBySender)
            Console.WriteLine($"{messageGroup.First().sender, -20} | {messageGroup.Count(), -5}");

        Console.WriteLine("\n---------------------------");
        Console.WriteLine("Received Messages");
        Console.WriteLine("---------------------------");
        foreach (var messageGroup in messagesGroupedByReceiver)
            Console.WriteLine($"{messageGroup.First().receiver, -20} | {messageGroup.Count(), -5} ");
    }
}
