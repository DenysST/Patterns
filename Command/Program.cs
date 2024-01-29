// See https://aka.ms/new-console-template for more information

using Command;
using Command.Receivers;
using Command.Receivers.Commands;

internal class Program {
    public static void Main(string[] args) {
        IFileSystemReceiver receiver = new UnixFileSystemReceiver();
        ICommand command = new OpenFileCommand(receiver);
        FileInvoker invoker = new FileInvoker(command);
        invoker.ExecuteCommand();

        ICommand writeCommand = new WriteFileCommand(receiver);
        FileInvoker writeInvoker = new FileInvoker(writeCommand);
        writeInvoker.ExecuteCommand();
        
        ICommand closeCommand = new CloseFileCommand(receiver);
        FileInvoker closeInvoker = new FileInvoker(closeCommand);
        closeInvoker.ExecuteCommand();
    }
}