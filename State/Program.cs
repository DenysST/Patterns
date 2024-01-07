namespace State;

internal class Program {
    public static void Main(string[] args) {
        Product phone = new Product("iPhone");
        phone.GetState().GetCurrentState();

        phone.GetState().NextState(phone);
        phone.GetState().GetCurrentState();

        phone.GetState().NextState(phone);
        phone.GetState().GetCurrentState();
    }
}