namespace Command.Receivers;

public interface IFileSystemReceiver {
    void OpenFile();
    void CloseFile();
    void WriteFile();
}