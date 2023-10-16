namespace UserManager
{
    public class UserModel(string login, string password, bool isAdmin)
    {
        public string Login => login;
        public string Password => password;
        public bool IsAdmin  => isAdmin;
        public bool IsAuthenticate { get; private set; } = false;

        public bool Authentication(string login, string password) 
            => IsAuthenticate = login == Login && password == Password;
        
        public bool LogoutIfNotAdmin() => IsAuthenticate = IsAuthenticate && IsAdmin;
    }
}
