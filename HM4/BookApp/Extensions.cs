namespace BookApp;

public static class Extensions
{
    public static IEnumerable<BookModel> CreateBookModelIenumerable(this int count)
            => count <= 1 ?
            throw new ArgumentException("Can't be less than one", nameof(count)) :
            Enumerable.Range(1, count).Select(index => new BookModel(bookId: index, title: $"title{index}", author: $"author{index}"));


    public static BookModel GetRandom(this IEnumerable<BookModel> books)
            => books.Skip(Random.Shared.Next(books.Count())).First();

}