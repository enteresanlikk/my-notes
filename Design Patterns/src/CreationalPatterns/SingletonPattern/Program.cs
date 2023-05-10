using SingletonPattern.Repositories;

var users = await UserRepository.Instance.GetUsers();

Console.WriteLine(users.Count);

foreach (var user in users)
{
    Console.WriteLine(user.ToString());
}