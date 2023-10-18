using BookApp;

namespace BookAppTests;

public class ExtensionTests
{
    [Test]
    public void TestCreateBookModelIenumerable()
    {
        int length = 100;
        IEnumerable<BookModel> books = length.CreateBookModelIenumerable();
        Assert.That(books, Is.Not.Null);
        Assert.That(books.Count(), Is.EqualTo(length));
    }

    [Test]
    public void TestCreateBookModelIenumerableThrow()
    {
        int length = -100;
        Exception exception = Assert.Throws<ArgumentException>(() => length.CreateBookModelIenumerable());
        Assert.That(exception, Is.Not.Null);
        Assert.That(exception.Message, Is.EqualTo("Can't be less than one (Parameter 'count')"));
    }

    [Test]
    public void TestGetRandomInBooks()
    {
        int length = 100;
        IEnumerable<BookModel> books = length.CreateBookModelIenumerable();
        BookModel expected = books.GetRandom();

        BookModel? actual = books.FirstOrDefault(book=>book.BookId == expected.BookId);

        Assert.That(actual, Is.Not.Null);
        Assert.That(actual.Author!, Is.EqualTo(expected.Author!));
        Assert.That(actual.Title!, Is.EqualTo(expected.Title!));
    }
}
