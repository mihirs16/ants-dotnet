using System.Collections.Concurrent;

namespace ants_dotnet;
public class Queen {
    public readonly int numAnts;
    public readonly int numMessages;
    public readonly CancellationTokenSource cancellationTokenSource;
    protected Dictionary<int, Ant> ants;
    private BlockingCollection<Message> messages;

    public Queen (int numAnts, int numMessages) {
        this.numAnts = numAnts;
        this.numMessages = numMessages;
        this.ants = new Dictionary<int, Ant>();
        this.messages = new BlockingCollection<Message>(this.numMessages);
        this.cancellationTokenSource = new CancellationTokenSource();

        Console.WriteLine("Spawning {0} ants...", numAnts);
        for (int i = 0; i < numAnts; i++)
            this.ants[i] = new Ant(this, i);

        Console.WriteLine("Starting ants' behaviour...");
        for (int i = 0; i < numAnts; i++)
            new Thread(this.ants[i].Behaviour).Start();

        for (int i = 0; i < numMessages; i++)
            Console.WriteLine(messages.Take());
        
        this.cancellationTokenSource.Cancel();
        return;
    }

    public Ant getAntFromId (int id) => this.ants[id];
    public void sendMessage (Message message) => this.messages.Add(message);
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
    }
}
