using BookApp;

namespace BookAppTests;

public class BookRepositoryTests
{
    private BookRepository repository;

    [SetUp]
    public void SetUp()
    {
        repository = new BookRepository();
    }


    [Test]
    public void TestGetById()
    {
        BookModel expected = FakeDataBase.Database.GetRandom();
        BookModel? actual = repository.Get(expected.BookId);

        Assert.That(actual, Is.Not.Null);
        Assert.Multiple(() =>
        {
            Assert.That(actual.BookId, Is.EqualTo(expected.BookId));
            Assert.That(actual.Title, Is.EqualTo(expected.Title));
            Assert.That(actual.Author, Is.EqualTo(expected.Author));
        });
    }

    [Test]
    public void TestGetAll()
    {
        IEnumerable<BookModel> expected = FakeDataBase.Database;

        IEnumerable<BookModel> actual = repository.Get();

        Assert.Multiple(() =>
        {
            Assert.That(actual.Intersect(expected, new BookModelComparer()).Any(), Is.True);
            Assert.That(expected.Intersect(actual, new BookModelComparer()).Any(), Is.True);
        });
    }

}
