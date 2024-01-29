namespace Bridge;

public abstract class Shape
{
    protected readonly IRenderer Renderer;

    protected Shape(IRenderer renderer)
    {
        Renderer = renderer;
    }

    public abstract void Draw();
}

public class Circle : Shape
{
    public Circle(IRenderer renderer) : base(renderer) { }

    public override void Draw()
    {
        Console.WriteLine("Drawing Circle");
        Renderer.Render("Circle");
    }
}

public class Square : Shape
{
    public Square(IRenderer renderer) : base(renderer) { }

    public override void Draw()
    {
        Console.WriteLine("Drawing Square");
        Renderer.Render("Square");
    }
}