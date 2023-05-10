using SingletonPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern.Repositories;

public class UserRepository
{
    private static UserRepository _instance = null;
    public static UserRepository Instance => _instance ??= new UserRepository();
    private new List<User> Users { get; set; }

    private UserRepository()
    {
        Task.Delay(1000).GetAwaiter().GetResult();

        Users = new List<User>()
        {
            new("Bilal", 24),
            new("Demir", 22),
            new("Ahmet", 45)
        };
    }

    public int Count => Users.Count;
    public async Task<List<User>> GetUsers() => Users;
}
