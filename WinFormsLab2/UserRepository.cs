namespace WinFormsLab2;

public class UserRepository : IUserRepository
{
    public List<IUser> _users { get; set; } = new List<IUser>();
     
    public UserRepository(string filePath)
    {
        LoadUsers(filePath);
    }
    

    public void LoadUsers(string filePath)
    {
        User currentUser = null;

        foreach (var line in File.ReadAllLines(filePath))
        {
            var trimmed = line.Trim();

            if (trimmed.StartsWith("#"))
            {
                var parts = trimmed.Substring(1).Split(' ');
                if (parts.Length == 2)
                {
                    currentUser = new User ( parts[0],parts[1]);
                    _users.Add(currentUser);
                }
            }
            else if (currentUser != null && !string.IsNullOrWhiteSpace(trimmed))
            {
                var parts = trimmed.Split(' ');
                if (parts.Length == 2 && int.TryParse(parts[1], out int status))
                {
                    currentUser.Access[parts[0]] = status;
                }
            }
        }
    }

    public IUser Authenticate(string name, string password)
    {
        return _users.FirstOrDefault(u => u.Name == name && u.Password == password);
    }

    public HashSet<string> GetAllMenuItems()
    {
        var allItems = new HashSet<string>();
        foreach (var user in _users)
        {
            foreach (var item in user.Access.Keys)
            {
                allItems.Add(item);
            }
        }
        return allItems;
    }
}