using System.Text;

namespace FileHandling;

public class WriteToFile
{
    public static void WriteFile(string filePath,  string content)
    {
        FileStream fileStream = new FileStream(filePath, FileMode.Append);
        
        byte[]  bytedata = Encoding.Default.GetBytes(content);
        
        fileStream.Write(bytedata, 0, bytedata.Length);
        
        fileStream.Close();
        
        Console.WriteLine("Successfully Written File with data: " + content);
    }
}