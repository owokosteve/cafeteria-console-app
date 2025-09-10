namespace cafeconnect;

public sealed class FileDatabase
{
    private string? FileName { get; }
    private string? FileExtention { get; }
    private string FilePath { get; set; }

    private static FileDatabase? FileInstance = null;

    public static FileDatabase FileDatabaseInstance()
    {
        if (FileInstance == null)
        {
            FileInstance = new FileDatabase();
        }
        return FileInstance;
    }
    private FileDatabase()
    {
        FilePath = $@"..\db\{FileName}{FileExtention}";
    }

    public void SaveToFile(User user, string fileName, string fileExtension)
    {
        // Ensure the file path exists
        if (!Directory.Exists(FilePath))
        {
            Directory.CreateDirectory(FilePath);
        }
        // Save to csv
        // Save to txt
    }

    public User GetUserFile(string fileName)
    {
        var user = User.GetUser();
        return user;
    }

}