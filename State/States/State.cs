namespace State.States;

public interface IState {
    void GetCurrentState();
    void NextState(Product product);
}