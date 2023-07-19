// Алгоритм отправляет рекламу пользователям, которые не оформили подписку
class User
{
    public string Login { get; set; }
    public string Name { get; set; }
    public bool IsPremium { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        // Создание списка пользователей с примером данных
        List<User> users = new List<User>
        {
            new User { Login = "user1", Name = "Гарри", IsPremium = true },
            new User { Login = "user2", Name = "Рон", IsPremium = false }, 
            new User { Login = "user3", Name = "Гермиона", IsPremium = true },
            new User { Login = "user4", Name = "Уизли", IsPremium = false }
        };

        // Перебор пользователей в списке
        foreach (var user in users)
        {
            // Вызов метода для приветствия пользователя
            GreetUser(user);

            // Проверка наличия премиум-подписки у пользователя
            if (!user.IsPremium)
            {
                // Вызов метода для показа рекламы
                ShowAds();
            }
        }
    }

    // Метод для приветствия пользователя по имени
    static void GreetUser(User user)
    {
        Console.WriteLine($"Привет, {user.Name}!");
    }

    // Метод для показа рекламы
    static void ShowAds()
    {
        Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
        Thread.Sleep(1000);

        Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
        Thread.Sleep(2000);

        Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
        Thread.Sleep(3000);
    }
}
