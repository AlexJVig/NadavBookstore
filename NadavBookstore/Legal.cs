namespace NadavBookstore
{
    public class Legal
    {
        public static void FilterByIsraeliLaw(List<Book> books)
        {
            RemoveBySabbathObservance(books);
        }

        private static void RemoveBySabbathObservance(List<Book> books)
        {
            books.RemoveAll(b => b.PublishDate.DayOfWeek == DayOfWeek.Saturday);
        }

        public Legal()
        {
        }
    }
}
