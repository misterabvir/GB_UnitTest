using UserManager;

namespace UserManagerTests
{
    public class UserModelTests
    {
        [Test]
        public void TestUserModelNotAdminCreation()
        {
            UserModel user = new UserModel("login", "password", false);

            Assert.IsNotNull(user);
            Assert.IsFalse(user.IsAdmin);
            Assert.IsFalse(user.IsAuthenticate);

            user.Authentication("login", "password");
            Assert.IsTrue(user.IsAuthenticate);
            user.LogoutIfNotAdmin();
            Assert.IsFalse(user.IsAuthenticate);
        }

        [Test]
        public void TestUserModelAdminCreation()
        {
            UserModel user = new UserModel("login", "password", true);

            Assert.IsNotNull(user);
            Assert.IsTrue(user.IsAdmin);
            Assert.IsFalse(user.IsAuthenticate);

            user.Authentication("login", "password");
            Assert.IsTrue(user.IsAuthenticate);
            user.LogoutIfNotAdmin();
            Assert.IsTrue(user.IsAuthenticate);
        }


        [Test]
        public void TestUserModelNotAuthenticateNotAdminCreation()
        {
            UserModel user = new UserModel("login", "password", false);

            Assert.IsNotNull(user);
            Assert.IsFalse(user.IsAdmin);
            Assert.IsFalse(user.IsAuthenticate);
            user.Authentication("login", "wrongpassword");
            Assert.IsFalse(user.IsAuthenticate);
        }

        [Test]
        public void TestUserModelNotAuthenticateAdminCreation()
        {
            UserModel user = new UserModel("login", "password", true);

            Assert.IsNotNull(user);
            Assert.IsTrue(user.IsAdmin);
            Assert.IsFalse(user.IsAuthenticate);
            user.Authentication("login", "wrongpassword");
            Assert.IsFalse(user.IsAuthenticate);
        }
    }
}