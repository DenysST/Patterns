namespace ChainOfResponsibility.Handlers;

public class ValidPasswordHandler : Handler {
    private readonly Database _database;

    public ValidPasswordHandler(Database database) {
        _database = database;
    }

    public override bool Handle(string username, string password) {
        if (!_database.IsValidUser(username)) {
            Console.WriteLine("This username is not registered");
            return false;
        }
        
        return HandleNext(username, password);
    }
}