namespace Proxy;

class Program
{
    static void Main(string[] args)
    {
        IDocument authorizedDocument = new DocumentProxy("Secret Content", "AuthorizedUser");
        Console.WriteLine(authorizedDocument.View());
        
        IDocument unauthorizedDocument = new DocumentProxy("Secret Content", "UnknownUser");
        Console.WriteLine(unauthorizedDocument.View()); 
        
        Console.ReadLine();
    }
}