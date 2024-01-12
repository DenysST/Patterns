namespace Bridge;

public interface IRenderer
{
    void Render(string shape);
}


public class ScreenRenderer : IRenderer
{
    public void Render(string shape)
    {
        Console.WriteLine($"Rendering {shape} on Screen");
    }
}

public class PaperRenderer : IRenderer
{
    public void Render(string shape)
    {
        Console.WriteLine($"Printing {shape} on Paper");
    }
}