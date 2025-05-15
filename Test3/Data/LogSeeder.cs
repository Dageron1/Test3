using System.Text.Json;
using Test3.Entities;

namespace Test3.Data;

public static class LogSeeder
{
    public static async Task<List<UserLog>> LoadLogsFromJsonAsync(string filePath)
    {
        if (!File.Exists(filePath))
            throw new FileNotFoundException("UserLogs JSON file not found", filePath);

        using var stream = File.OpenRead(filePath);
        var logs = await JsonSerializer.DeserializeAsync<List<UserLog>>(stream, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        });

        return logs ?? new List<UserLog>();
    }
}
