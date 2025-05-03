namespace UserLib;

public class User : IUser
{
    public string Name { get; set; }
    public string Password { get; set; }
    public Dictionary<string, int> Access { get; set; } = new();

    public User(string name, string password)
    {
        Name = name;
        Password = password;
    }
}