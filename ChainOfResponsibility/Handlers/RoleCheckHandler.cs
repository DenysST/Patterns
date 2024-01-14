namespace ChainOfResponsibility.Handlers;

public class RoleCheckHandler : Handler {
    public override bool Handle(string username, string password) {
        if ("admin_username".Equals(username)) {
            Console.WriteLine("Loading Admin Page");
            return true;
        }
        Console.WriteLine("Loading default page...");
        return HandleNext(username, password);
    }
}