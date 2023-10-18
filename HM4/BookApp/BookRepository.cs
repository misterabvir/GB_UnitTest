namespace BookApp;

public class BookRepository : IRepository<BookModel>
{
    public BookModel? Get(int id) => FakeDataBase.Database.FirstOrDefault(book => book.BookId == id);
    public IEnumerable<BookModel> Get() => FakeDataBase.Database;
}
