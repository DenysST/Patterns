using Flyweight;

internal class Program {
    private static readonly int BookTypes = 2;
    private static readonly int BooksToInsert = 100000;
    
    public static void Main(string[] args) {
        Store store = new();
        for (int i = 0; i < BooksToInsert / BookTypes; i++) {
            store.StoreBook(GetRandomName(), GetRandomPrice(), "Action", "Test distributor", "other");
            store.StoreBook(GetRandomName(), GetRandomPrice(), "Fantasy", "Test distributor2", "other2");
        }
        
        store.DisplayBooks();

    }
    
    private static String GetRandomName() {
        List<String> books = new List<string> {"book_1", "book_2", "book_3", "book_4", "book_5", "book_6", "book_7", "book_8", "book_9", "book_10"};
        return books[new Random().Next(books.Count)];
    }

    private static double GetRandomPrice() {
        return new Random().NextDouble();
    }
}