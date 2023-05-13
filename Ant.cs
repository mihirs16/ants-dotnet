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
        Thread.Sleep(2000);

        // generate a random user from the queen
        int randomId = randomGenerator.Next(queen.numAnts);

        // get user from queen's directory
        Ant receiverAnt = queen.getAntFromId(randomId);

        // send a message to the user
        queen.sendMessage(new Message(this, receiverAnt, "Hello!"));
    }

    public override string ToString() => String.Format("{0}", name);   
}
