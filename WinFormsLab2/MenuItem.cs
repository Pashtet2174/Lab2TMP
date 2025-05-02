namespace WinFormsLab2;

public class MenuItem
{
    public string Title { get; set; }
    public string Handler { get; set; } // Может быть null
    public List<MenuItem> Children { get; set; } = new List<MenuItem>();
}