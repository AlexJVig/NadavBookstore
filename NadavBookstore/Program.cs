using NadavBookstore;

var books = Data.GetBooks();
Legal.FilterByIsraeliLaw(books);
ArbitraryFilters.ApplyFilters(books);
Console.WriteLine(books);
