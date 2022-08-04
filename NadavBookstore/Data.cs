using System.Text.Json;

namespace NadavBookstore
{
    public class Data
    {
        public static List<Book> GetBooks()
        {
            List<Book> books;

            using (var file = new StreamReader("books.json"))
            {
                string json = file.ReadToEnd();

                try
                {
                    books = JsonSerializer.Deserialize<List<Book>>(json);
                }
                catch (Exception ex)
                {
                    return new List<Book>();
                }
            }

            if (books != null)
                return books;
            else
                return new List<Book>();
        }
    }
}
