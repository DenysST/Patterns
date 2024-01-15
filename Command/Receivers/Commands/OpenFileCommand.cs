namespace Command.Receivers.Commands;

public class OpenFileCommand : ICommand {
    private readonly IFileSystemReceiver _fileSystem;

    public OpenFileCommand(IFileSystemReceiver fileSystem) {
        _fileSystem = fileSystem;
    }

    public void Execute() {
        _fileSystem.OpenFile();
    }
}