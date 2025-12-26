namespace FileHandling;

public class DirectoryInfoDemo
{
    public static void CreateDirectory(string directoryPath)
    {
        DirectoryInfo directoryInfo = new DirectoryInfo(directoryPath);
        directoryInfo.Create();
        {
            Console.WriteLine($"{directoryPath} has been created");
        }
        Console.ReadKey();
    }
    
    public static void createSubDirectory(string directoryPath)
    {
        DirectoryInfo directoryInfo = new DirectoryInfo(directoryPath);
        directoryInfo.CreateSubdirectory("SubDirectory");
        {
            Console.WriteLine($"{directoryPath} has been created");
        }
        Console.ReadKey();
    }

    public static void MoveDirectory(string sourceDirectoryPath, string destinationDirectoryPath)
    {
        DirectoryInfo directoryInfo = new DirectoryInfo(sourceDirectoryPath);
        directoryInfo.MoveTo(destinationDirectoryPath);
        {
            Console.WriteLine($"{sourceDirectoryPath} has been moved to {destinationDirectoryPath}");
        }
        Console.ReadKey();
    }
}