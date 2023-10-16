using HWmain;

namespace HMmainTests
{
    public class SimpleCheckTests
    {
        private SimpleCheckService service;

        [SetUp]
        public void Setup()
        {
            service = new SimpleCheckService();
        }

        [Test]
        [TestCase(1)]
        [TestCase(3)]
        [TestCase(5)]
        public void CheckNumberIsOdd(int input)
        {
            Assert.IsTrue(service.IsOddNumber(input));
        }

        [Test]
        [TestCase(2)]
        [TestCase(4)]
        [TestCase(6)]
        public void CheckNumberIsEven(int input)
        {
            Assert.IsFalse(service.IsOddNumber(input));
        }

        [Test]
        [TestCase(25)]
        [TestCase(50)]
        [TestCase(100)]
        public void CheckNumberInRangeFrom25To100(int input)
        {
            Assert.IsTrue(service.IsNumberInRange(input));
        }

        [Test]
        [TestCase(24)]
        [TestCase(-50)]
        [TestCase(101)]
        public void CheckNumberNotInRangeFrom25To100(int input)
        {
            Assert.IsFalse(service.IsNumberInRange(input));
        }
    }
}