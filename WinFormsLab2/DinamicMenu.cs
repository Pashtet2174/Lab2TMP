

namespace WinFormsLab2;

public class DynamicMenu
{
    public List<MenuItem> RootItems { get; set; } = new List<MenuItem>();

    public DynamicMenu(string fileName = "menu.txt")
    {
        if (!File.Exists(fileName))
            throw new FileNotFoundException("Файл меню не найден.", fileName);

        LoadMenuFromFile(fileName);
    }

    private void LoadMenuFromFile(string fileName)
    {
        var stack = new Stack<(int level, MenuItem item)>();
        
        foreach (var line in File.ReadLines(fileName))
        {
            var parts = line.Trim().Split(' ', 3, StringSplitOptions.RemoveEmptyEntries);

            if (parts.Length < 2) continue;

            int level = int.Parse(parts[0]);
            string title = parts[1];
            string handler = parts.Length == 3 ? parts[2] : null;

            var newItem = new MenuItem
            {
                Title = title,
                Handler = handler
            };

            while (stack.Count > 0 && stack.Peek().level >= level)
                stack.Pop();

            if (stack.Count == 0)
            {
                RootItems.Add(newItem); // Это корневой пункт
            }
            else
            {
                stack.Peek().item.Children.Add(newItem); // Добавляем в родительский
            }

            stack.Push((level, newItem));
        }
    }
}