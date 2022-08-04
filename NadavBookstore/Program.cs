using NadavBookstore;

var books = Data.GetBooks();
Legal.FilterByIsraeliLaw(books);
ArbitraryFilters.ApplyFilters(books);
BookPricing.AdjustPricing(books);
Data.ExportToCsv(books);
