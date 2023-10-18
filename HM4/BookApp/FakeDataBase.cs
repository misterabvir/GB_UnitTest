namespace BookApp;

public static class FakeDataBase
{  
    public static IEnumerable<BookModel> Database => database ??= 2.CreateBookModelIenumerable();
    private static IEnumerable<BookModel>? database = null;
}
