namespace ants_dotnet;
public class Ant {
    public int _id;
    public string name;
    public readonly Queen queen;
    private readonly Random randomGenerator;

    public Ant(Queen queen, int _id, string? name = null) {
        this._id = _id;
        this.name = name ?? $"ant_{_id}";
        this.queen = queen;
        this.randomGenerator = new Random();
        
        Console.WriteLine("Spawned {0}", this);
    }

    public void Behaviour() {
        if (queen.cancellationTokenSource.IsCancellationRequested) {
            Console.WriteLine($"{this} is done.");
            return;
        }

        int sleepTimeMultiplier = randomGenerator.Next(11);
        int sleepTime = sleepTimeMultiplier * 100;
        Thread.Sleep(sleepTime);

        int randomId = randomGenerator.Next(queen.numAnts);
        Ant receiverAnt = queen.getAntFromId(randomId);
        queen.sendMessage(new Message(this, receiverAnt, "Hello!"));

        Behaviour();
    }

    public override string ToString() => $"{this.name}";   
}
