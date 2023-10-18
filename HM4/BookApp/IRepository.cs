namespace BookApp;

public interface IRepository<out T> where T : class
{
    T? Get(int id);
    IEnumerable<T> Get();
}
