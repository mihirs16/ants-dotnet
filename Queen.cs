namespace ants_dotnet;
public class Queen {
    public readonly int numAnts;
    protected Dictionary<int, Ant> ants;
    private Queue<Message> messages;

    public Queen (int numAnts) {
        this.numAnts = numAnts;
        this.ants = new Dictionary<int, Ant>();
        this.messages = new Queue<Message>();

        Console.WriteLine("Spawning {0} ants...", numAnts);
        Parallel.For(0, numAnts, i => this.ants[i] = new Ant(this, i));
        Parallel.For(0, numAnts, i => this.ants[i].Behaviour());

        Parallel.ForEach(this.messages, message => {
            Console.WriteLine(message);
        });
    }

    public Ant getAntFromId (int id) {
        Ant result = this.ants[id];
        return result;
    }

    public void sendMessage (Message message) => this.messages.Enqueue(message);
}

class Program {
    static void Main (string[] args) {
        int numAnts = 0;
        try {
            numAnts = int.Parse(args[0]);
        }
        catch {
            Console.WriteLine("Usage: ./ants-dotnet <num_ants>");
            return;
        }
        
        Console.WriteLine("Spawning a queen...");
        Queen queen = new Queen(numAnts);
    }
}
