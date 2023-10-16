using System.Collections;

namespace UserManager;

public class UserAuthenticationRepository : IEnumerable<UserModel>
{
    private List<UserModel> users = [];
    public int Count => users.Count;


    public void AddUser(UserModel user)
    {
        if (user.IsAuthenticate)
            users.Add(user);
    }


    public void LogoutNotAdminUsers()
    {
        users = users.Where(user => user.LogoutIfNotAdmin()).ToList();
    }


    public IEnumerator<UserModel> GetEnumerator() => users.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => users.GetEnumerator();
}
