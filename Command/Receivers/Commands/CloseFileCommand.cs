namespace Command.Receivers.Commands;

public class CloseFileCommand : ICommand {
    private readonly IFileSystemReceiver _fileSystem;

    public CloseFileCommand(IFileSystemReceiver fileSystem) {
        _fileSystem = fileSystem;
    }

    public void Execute() {
        _fileSystem.CloseFile();
    }
}