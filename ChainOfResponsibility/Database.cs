namespace ChainOfResponsibility;

public class Database {
    private readonly Dictionary<string, string> _users = new() {
        { "admin_username", "admin_password" },
        { "user_username", "user_password" }
    };

    public bool IsValidUser(string username) {
        return _users.ContainsKey(username);
    }
    
    public bool IsPasswordValid(string username, string password) {
        return _users[username].Equals(password);
    }
}