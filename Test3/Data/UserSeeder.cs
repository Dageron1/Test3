using System.Text.Json;
using Test3.Entities;

namespace Test3.Data;

public static class UserSeeder
{
    public static async Task<List<User>> LoadUsersFromJsonAsync(string filePath)
    {
        if (!File.Exists(filePath))
            throw new FileNotFoundException("User JSON file not found", filePath);

        using var stream = File.OpenRead(filePath);
        var users = await JsonSerializer.DeserializeAsync<List<User>>(stream, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        });

        return users ?? new List<User>();
    }
}
