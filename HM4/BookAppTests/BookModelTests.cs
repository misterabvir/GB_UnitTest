using BookApp;

namespace BookAppTests;

public class BookModelTests
{
    [Test]
    [TestCase(1, "title1", "author1")]
    [TestCase(2, "title2", "author3")]
    [TestCase(3, "title2", "author3")]
    public void TestBookModelCreateWithFullConstructorSuccesfull(int id, string title, string author)
    {
        BookModel actual = new(id, title, author);
        Assert.That(actual, Is.Not.Null);
        Assert.Multiple(() =>
        {
            Assert.That(actual.BookId, Is.EqualTo(id));
            Assert.That(actual.Title, Is.EqualTo(title));
            Assert.That(actual.Author, Is.EqualTo(author));
        });
    }

    [Test]
    [TestCase(1)]
    [TestCase(2)]
    [TestCase(3)]
    public void TestBookModelCreateWithSimpleConstructorSuccesfull(int id)
    {
        BookModel actual = new(id);
        Assert.That(actual, Is.Not.Null);
        Assert.Multiple(() =>
        {
            Assert.That(actual.BookId, Is.EqualTo(id));
            Assert.That(actual.Title, Is.Null);
            Assert.That(actual.Author, Is.Null);
        });
    }

    [Test]
    [TestCase(1, "title1", "author1", 11, "title11", "author11")]
    [TestCase(2, "title2", "author2", 22, "title22", "author22")]
    [TestCase(3, "title3", "author3", 33, "title33", "author33")]
    public void TestBookModelCreateSuccesfull(
        int id,
        string title,
        string author,
        int newId,
        string newTitle,
        string newAuthor)
    {
        BookModel actual = new(id, title, author);

        actual.BookId = newId;
        actual.Title = newTitle;
        actual.Author = newAuthor;

        Assert.Multiple(() =>
        {
            Assert.That(actual.BookId, Is.EqualTo(newId));
            Assert.That(actual.Title, Is.EqualTo(newTitle));
            Assert.That(actual.Author, Is.EqualTo(newAuthor));
        });
    }
}
