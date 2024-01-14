namespace ChainOfResponsibility.Handlers;

public abstract class Handler {
    private Handler? _next;

    public Handler? SetNextHandler(Handler? next) {
        _next = next;
        return next;
    }

    public abstract bool Handle(string username, string password);

    protected bool HandleNext(string username, string password) {
        if (_next == null) {
            return true;
        }

        return _next.Handle(username, password);
    }
}