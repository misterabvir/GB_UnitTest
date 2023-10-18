using BookApp;
using Moq;

namespace BookAppTests;

public class BookServiceTests
{
    private Mock<IRepository<BookModel>> repository;


    [SetUp]
    public void SetUp()
    {
        
        repository = new Mock<IRepository<BookModel>>();
    }

    [Test]
    public void TestGetById()
    {
        BookModel expected = FakeDataBase.Database.GetRandom();
        repository.Setup(method => method.Get(expected.BookId)).Returns(expected);

        BookService service = new(repository.Object);
        BookModel? actual = service.Get(expected.BookId);

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
        repository.Setup(method => method.Get()).Returns(expected);

        BookService service = new(repository.Object);
        IEnumerable<BookModel> actual = service.Get();
        
        Assert.Multiple(() =>
        {
            Assert.That(actual.Intersect(expected, new BookModelComparer()).Any(), Is.True);
            Assert.That(expected.Intersect(actual, new BookModelComparer()).Any(), Is.True);
        });
    }
}
