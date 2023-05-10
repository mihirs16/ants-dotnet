namespace ants_dotnet;
class Program
{
    static void Main(string[] args)
    {   
        User sample_user_1 = new User(1, "user1");
        User sample_user_2 = new User(2, "user2");
        Message sample_message = new Message(sample_user_1, sample_user_2, "Hello World!");
        Console.WriteLine(sample_message.ToString());
    }
}