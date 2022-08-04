using NadavBookstore;

var books = Data.GetBooks();
Legal.FilterByIsraeliLaw(books);
Console.WriteLine(books);
