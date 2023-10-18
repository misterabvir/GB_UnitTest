using System.Diagnostics.CodeAnalysis;

namespace BookApp;

public class BookModelComparer : IEqualityComparer<BookModel>
{
    public bool Equals(BookModel? x, BookModel? y)
    =>
        x != null &&
        y != null &&
        x.BookId == y.BookId &&
        x.Title == y.Title &&
        x.Author == y.Author;

    public int GetHashCode([DisallowNull] BookModel obj) => obj.BookId.GetHashCode();   
}
