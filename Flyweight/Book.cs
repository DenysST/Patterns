namespace Flyweight;

public class Book {
    public string Name { get; }

    public double Price { get; }

    public BookType BookType { get; }

    public Book(string name, double price, BookType bookType) {
        Name = name;
        Price = price;
        BookType = bookType;
    }

    public override string ToString() {
        return $"Book: {Name}, Price: {Price}, BookType: {BookType}";
    }
}