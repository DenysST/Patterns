using ChainOfResponsibility.Handlers;

namespace ChainOfResponsibility;

public class AuthService {
    private readonly Handler _handler;
    public AuthService(Handler handler) {
        _handler = handler;
    }
    
    public bool Authenticate(string username, string password) {
        if (_handler.Handle(username, password)) {
            Console.WriteLine("Authorization was successful");
            return true;
        }

        return false;
    }
}