namespace bookStoreRecord
{
    internal class Program
    {
        public record Bookstore(int ID, string Title, string Author, double Price);
        static void Main(string[] args)
        {
            Bookstore b0 = new(0, "30-Second Einstein", "Brian Clegg", 9.99);
            Console.WriteLine(b0);
            Bookstore b1 = new(1, "The Hobbit", "J.R.R. Tolkien", 10.99);
            Console.WriteLine(b1);
            Bookstore b2 = new(2, "All The Wrong Questions: Who Could That Be at This Hour?", "Lemony Snicket", 7.00);
            Console.WriteLine(b2);
        }
    }
}
