// See https://aka.ms/new-console-template for more information

using ChainOfResponsibility;
using ChainOfResponsibility.Handlers;

internal class Program {
    public static void Main(string[] args) {
        Database database = new Database();
        Handler handler = new UserExistHandler(database);
        handler.SetNextHandler(new ValidPasswordHandler(database))
            ?.SetNextHandler(new RoleCheckHandler());

        AuthService authService = new AuthService(handler);
        
        Console.WriteLine("---------------------------------------");
        Console.WriteLine(authService.Authenticate("username", "password"));
        Console.WriteLine("---------------------------------------");
        Console.WriteLine(authService.Authenticate("user_username", "password"));
        Console.WriteLine("---------------------------------------");
        Console.WriteLine(authService.Authenticate("admin_username", "admin_password"));
        Console.WriteLine("---------------------------------------");
    }
}