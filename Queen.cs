namespace ants_dotnet;
class Queen {
    static void Main(string[] args) {
        int num_ants = 0;
        try {
            num_ants = int.Parse(args[0]);
        }
        catch {
            Console.WriteLine("Usage: ./ants-dotnet <num_ants>");
            return;
        }

        Console.WriteLine("Spawning {0} ants...", num_ants);
        List<Ant> ants = new List<Ant>();
        for (int i = 0; i < num_ants; i++) {
            ants.Add(new Ant(i, String.Format("name_{0}", i)));
        }

        foreach (var ant in ants) {
            Console.WriteLine(ant);
        }

    }
}
