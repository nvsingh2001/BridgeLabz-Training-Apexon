namespace FileHandling;

public class StreamReaderDemo
{
    public static void ReadFileLineByLine(string filePath)
    {
        using StreamReader streamReader = new(filePath);
        
        streamReader.BaseStream.Seek(0, SeekOrigin.Begin);
        streamReader.DiscardBufferedData();
    
        var strData = streamReader.ReadLine();

        while (strData is not null)
        {
            Console.WriteLine(strData);
            strData = streamReader.ReadLine();
        }
        Console.ReadLine();
    }

    public static void ReadFileUptoEndOfFile(string filePath)
    {
        using StreamReader streamReader = new(filePath);
        
        streamReader.BaseStream.Seek(0, SeekOrigin.Begin);
        
        Console.WriteLine(streamReader.ReadToEnd());
    }
}