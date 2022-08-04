namespace NadavBookstore
{
    public class ArbitraryFilters
    {
        public static void ApplyFilters(List<Book> books)
        {
            PeterFilter(books);
        }

        private static void PeterFilter(List<Book> books)
        {
            books.RemoveAll(b => b.Author.Contains("Peter"));
        }
    }
}
