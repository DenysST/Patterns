namespace State.States;

public class OrderedState : IState{
    public void GetCurrentState() {
        Console.WriteLine("Product is ordered");
    }

    public void NextState(Product product) {
        product.SetState(new DeliveredState());
    }
}