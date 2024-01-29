using Command.Receivers.Commands;

namespace Command;

public class FileInvoker {
    private readonly ICommand _command;

    public FileInvoker(ICommand command) {
        _command = command;
    }
    public void ExecuteCommand() {
        _command.Execute();
    }
}