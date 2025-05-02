namespace WinFormsLab2;

public interface IUserRepository
{
    List<IUser> _users { get; }
    void LoadUsers(string fileName);
    IUser Authenticate(string name, string password);
    HashSet<string> GetAllMenuItems();
}