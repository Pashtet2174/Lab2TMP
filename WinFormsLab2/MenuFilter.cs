namespace WinFormsLab2;

public static class MenuFilter
{
    public static List<MenuItem> FilterMenuForUser(List<MenuItem> menu, User user)
    {
        List<MenuItem> Filter(List<MenuItem> items)
        {
            var result = new List<MenuItem>();

            foreach (var item in items)
            {
                int status = 0;
                if (user.Access.TryGetValue(item.Title, out int s))
                    status = s;

                if (status == 2)
                    continue; // Не виден — пропускаем

                var copy = new MenuItem
                {
                    Title = item.Title,
                    Handler = item.Handler,
                    Children = Filter(item.Children)
                };

                result.Add(copy);
            }

            return result;
        }

        return Filter(menu);
    }
}