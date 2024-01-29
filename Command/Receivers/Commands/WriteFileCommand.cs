namespace Command.Receivers.Commands;

public class WriteFileCommand : ICommand {
    private readonly IFileSystemReceiver _fileSystem;

    public WriteFileCommand(IFileSystemReceiver fileSystem) {
        _fileSystem = fileSystem;
    }

    public void Execute() {
        _fileSystem.WriteFile();
    }
}