// See https://aka.ms/new-console-template for more information

using Bridge;

internal class Program {
    public static void Main(string[] args) {
        Shape circle = new Circle(new PaperRenderer());
        Shape square = new Square(new ScreenRenderer());
        
        circle.Draw();
        square.Draw();
    }
}