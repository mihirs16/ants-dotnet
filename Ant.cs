using Bogus;

namespace ants_dotnet;
public class Ant {
    public int _id;
    public string name;
    public readonly Queen queen;
    private readonly Random randomGenerator;

    public Ant(Queen queen, string name) {
        this.name = name;
        this.queen = queen;
        this.randomGenerator = new Random();
        
        Console.WriteLine($"Spawned {this}");
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
        Faker faker = new Faker();
        queen.sendMessage(new Message(this, receiverAnt, faker.Lorem.Sentence(5)));

        Behaviour();
    }

    public override string ToString() => $"{this.name}";   
}
