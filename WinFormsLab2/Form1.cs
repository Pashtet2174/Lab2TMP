namespace WinFormsLab2;
using UserLib;
public partial class Form1 : Form
{
    private readonly IUser _currentUser;
    private readonly DynamicMenu _menu;

    public Form1(IUser user)
    {
        _currentUser = user;
        _menu = new DynamicMenu();  // Загружаем меню из файла
        
        InitializeComponent();
        InitializeMenu();
    }

    private void InitializeMenu()
    {
        // Фильтруем меню для текущего пользователя
        var filteredMenu = MenuFilter.FilterMenuForUser(_menu.RootItems, _currentUser);
        
        // Создаем MenuStrip
        var mainMenu = new MenuStrip();
        
        foreach (var item in filteredMenu)
        {
            mainMenu.Items.Add(CreateMenuItems(item));
        }

        this.Controls.Add(mainMenu);
    }

    private ToolStripMenuItem CreateMenuItems(MenuItem item)
    {
        var menuItem = new ToolStripMenuItem(item.Title)
        {
            Enabled = IsMenuItemEnabled(item.Title)  // Проверяем доступность
        };

        if (item.Handler != null)
        {
            menuItem.Click += (s, e) => 
                MessageBox.Show($"Выбран пункт: {item.Title}");
        }

        // Рекурсивно добавляем подпункты
        foreach (var child in item.Children)
        {
            menuItem.DropDownItems.Add(CreateMenuItems(child));
        }

        return menuItem;
    }

    private bool IsMenuItemEnabled(string title)
    {
        // Проверяем права доступа
        if (_currentUser.Access.TryGetValue(title, out int status))
        {
            return status == 0;  // 0 - доступен, 1 - виден но недоступен
        }
        return true;  // Если пункта нет в ограничениях - доступен
    }
}