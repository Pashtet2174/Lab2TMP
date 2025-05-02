namespace WinFormsLab2;

public interface IUser
{
    string Name { get; }
    string Password { get; }
    Dictionary<string, int> Access { get; set; }
}