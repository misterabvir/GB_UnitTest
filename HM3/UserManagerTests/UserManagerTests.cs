using UserManager;

namespace UserManagerTests
{
    public class UserManagerTests
    {
        UserAuthenticationRepository repository;

        [SetUp]
        public void Setup()
        {
            repository = new UserAuthenticationRepository();
        }


        [Test]
        public void TestAddNotAdminAthenticatedUser()
        {
            UserModel user = new("login", "password", false);
            user.Authentication("login", "password");
            int countBefore = repository.Count;
            repository.AddUser(user);
            int countAfter = repository.Count;
            Assert.That(countAfter, Is.EqualTo(countBefore + 1));
        }

        [Test]
        public void TestAddNotAdminNotAthenticatedUser()
        {
            UserModel user = new("login", "password", false);
            int countBefore = repository.Count;
            repository.AddUser(user);
            int countAfter = repository.Count;
            Assert.That(countAfter, Is.EqualTo(countBefore));
        }

        [Test]
        public void TestLogoutNotAdminUsers()
        {
            Enumerable
                .Range(1, 1000)
                .Select(index => new UserModel(
                        $"login_{index}",
                        $"password_{index}",
                        index % Random.Shared.Next(3, 5) == 0
                    ))
                .ToList()
                .ForEach(user =>
                {
                    user.Authentication(user.Login, user.Password);
                    repository.AddUser(user);
                });

            Assert.That(repository, Has.Count.EqualTo(1000));
            repository.LogoutNotAdminUsers();

            repository
                .ToList()
                .ForEach(user =>
                {
                    Assert.Multiple(() =>
                    {
                        Assert.That(user.IsAdmin, Is.True);
                        Assert.That(user.IsAuthenticate, Is.True);
                    });
                });

        }

    }
}