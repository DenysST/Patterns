using State.States;

namespace State;

public class Product {
    private String _name;
    private IState _state;

    public Product(String name) {
        _name = name;
        _state = new OrderedState();
    }

    public IState GetState() {
        return _state;
    }

    public void SetState(IState newState) {
        _state = newState;
    }
}