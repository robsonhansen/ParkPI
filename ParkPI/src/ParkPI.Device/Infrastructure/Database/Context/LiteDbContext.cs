public class LiteDbContext : IDisposable
{
    public readonly LiteDatabase _database;

    public LiteDbContext(string databasePath = "Data/ParkPI.db")
    {
        var fullPath = Path.GetFullPath(databasePath);
        var directory = Path.GetDirectoryName(fullPath);
        if (!Directory.Exists(directory))
            Directory.CreateDirectory(directory);

        _database = new LiteDatabase(fullPath);
    }

    public LiteDatabase Database => _database;

    public void Dispose()
    {
        _database.Dispose();
    }
}