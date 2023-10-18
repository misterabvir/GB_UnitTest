namespace BookApp;

public class BookModel
{
    public BookModel(int bookId)
    {
        this.BookId = bookId;
    }

    public BookModel(int bookId, string title, string author)
    {
        this.BookId = bookId;
        this.Title = title;
        this.Author = author;
    }

    public int BookId { get; set; }
    public string? Title { get; set; }
    public string? Author { get; set; }
}
