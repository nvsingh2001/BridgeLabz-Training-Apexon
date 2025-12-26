namespace FileHandling;

public class BinaryDataReadWrite
{
    public static void WriteFile(string filePath)
    {
        using var writer = new BinaryWriter(File.Open(filePath, FileMode.Create));
        writer.Write("0x802344000");
        writer.Write("Windows Explorer Has Stopped Working");
        writer.Write(true);
        
        Console.WriteLine("Binary File Created!");
        Console.ReadKey();
    }

    public static void ReadBinaryDataFromFile(string filePath)
    {
        using var reader = new BinaryReader(File.Open(filePath, FileMode.Open));
        Console.WriteLine("Error Code: " + reader.ReadString());
        Console.WriteLine("Message : " + reader.ReadString());
        Console.WriteLine("Restart Explorer: " + reader.ReadBoolean());
    }
}