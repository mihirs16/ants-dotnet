namespace ants_dotnet;
public class Message
{
    public User sender;
    public User receiver;
    public string message;

    public Message(User sender, User receiver, string message)
    {
        this.sender = sender;
        this.receiver = receiver;
        this.message = message;
    }

    override public string ToString()
    {
        return $"From: {sender.username}\nTo: {receiver.username}\nMessage: {message}";
    }
}
