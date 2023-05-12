namespace ants_dotnet;
public class Ant {
    public int _id;
    public string name;
    private Queue<Message> messages_received;

    public Ant(int _id, string name) {
        this._id = _id;
        this.name = name;
        messages_received = new Queue<Message>();
    }

    public override string ToString()
    {
        return String.Format("{0} ({1})", name, _id);
    }
}
