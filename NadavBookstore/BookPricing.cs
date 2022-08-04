namespace NadavBookstore
{
    public class BookPricing
    {
        public static void AdjustPricing(List<Book> books)
        {
            RoundPriceUp(books);
        }

        private static void RoundPriceUp(List<Book> books)
        {
            books.ForEach(b => b.Price = Math.Ceiling(b.Price));
        }
    }
}
