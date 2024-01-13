namespace Flyweight;

public class Store {
    private readonly List<Book> _books = new();

    public void StoreBook(string name, double price, string type, string distributor, string otherData) {
        BookType bookType = BookFactory.GetBookType(type, distributor, otherData);
        _books.Add(new Book(name, price, bookType));
    }

    public void DisplayBooks() {
        _books.ForEach(Console.WriteLine);
    }
}