namespace BookApp;

public class BookService
    (IRepository<BookModel> repository)
{
    public IEnumerable<BookModel> Get() => repository.Get();
    public BookModel? Get(int id) => repository.Get(id);
}
