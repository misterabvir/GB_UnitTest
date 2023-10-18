using BookApp;

namespace BookAppTests;

public class BookComparerTests
{
    BookModelComparer comparer;
    
    [SetUp]
    public void SetUp()
    {
        comparer = new BookModelComparer();
    }

    [Test]
    public void CheckEqualMethod()
    {
        Assert.Multiple(() =>
        {
            Assert.That(comparer.Equals(new BookModel(1, "1", "1"), new BookModel(1, "1", "1")), Is.True);
            Assert.That(comparer.Equals(new BookModel(1, "1", "1"), new BookModel(2, "1", "1")), Is.False);
            Assert.That(comparer.Equals(new BookModel(1, "1", "1"), new BookModel(1, "2", "1")), Is.False);
            Assert.That(comparer.Equals(new BookModel(1, "1", "1"), new BookModel(1, "1", "2")), Is.False);
            Assert.That(comparer.Equals(null, new BookModel(1, "1", "1")), Is.False);
            Assert.That(comparer.Equals(new BookModel(1, "1", "1"), null), Is.False);
        });
    }

    [Test]
    public void CheckHashMethod()
    {
        BookModel book = new(6, "1", "1");
        Assert.That(comparer.GetHashCode(book), Is.EqualTo(book.BookId.GetHashCode()));
    }
}
