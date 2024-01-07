namespace State.States;

public class ReceivedState : IState{
    public void GetCurrentState() {
        Console.WriteLine("Product is received");
    }

    public void NextState(Product product) {
        Console.WriteLine("Product is already received by client");
    }
}