using ants_dotnet;
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
        
        Console.WriteLine("---------------------------");
        Console.WriteLine("Spawning a queen...");
        Console.WriteLine("---------------------------");
        Queen queen = new Queen(numAnts, numMessages);

        Console.WriteLine("\n---------------------------");
        Console.WriteLine("Displaying stats...");
        Console.WriteLine("---------------------------");
        queen.displayStats();
    }
}
