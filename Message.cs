namespace ants_dotnet;
public class Message {
    public Ant sender;
    public Ant receiver;
    public string message;

    public Message(Ant sender, Ant receiver, string message) {
        this.sender = sender;
        this.receiver = receiver;
        this.message = message;
    }

    override public string ToString() {
        return $"From: {sender.name}\nTo: {receiver.name}\nMessage: {message}";
    }
}
