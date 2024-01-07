namespace State.States;

public class DeliveredState : IState {
    public void GetCurrentState() {
        Console.WriteLine("Product is Delivered");
    }

    public void NextState(Product product) {
        product.SetState(new ReceivedState());
    }
}