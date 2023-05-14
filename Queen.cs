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

        Console.WriteLine($"Spawning {numAnts} ants...");
        for (int i = 0; i < numAnts; i++) {
            Faker faker = new Faker();
            this.ants[i] = new Ant(this, faker.Person.UserName);
        }

        List<Thread> threads = new List<Thread>();
        Console.WriteLine("Starting ants' behaviour...");
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
        foreach (var messageGroup in messagesGroupedBySender)
            Console.WriteLine($"{messageGroup.First().sender} sent {messageGroup.Count()} messages.");

        IEnumerable<IGrouping<string, Message>> messagesGroupedByReceiver =
            from message in this.messages
            group message by message.receiver.name into groupedByReceiver
            select groupedByReceiver;
        foreach (var messageGroup in messagesGroupedByReceiver)
            Console.WriteLine($"{messageGroup.First().receiver} received {messageGroup.Count()} messages.");
    }
}

class Program {
    static void Main (string[] args) {
        int numAnts = 0;
        int numMessages = 0;
        try {
            numAnts = int.Parse(args[0]);
            numMessages = int.Parse(args[1]);
        }
        catch {
            Console.WriteLine("Usage: ./ants-dotnet [num_ants] [num_messages]");
            return;
        }
        
        Console.WriteLine("Spawning a queen...");
        Queen queen = new Queen(numAnts, numMessages);

        Console.WriteLine("Displaying stats...");
        queen.displayStats();
    }
}
