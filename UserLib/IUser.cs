namespace UserLib;

public interface IUser
{
    string Name { get; }
    string Password { get; }
    Dictionary<string, int> Access { get; set; }
}