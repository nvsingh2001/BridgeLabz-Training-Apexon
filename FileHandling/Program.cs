namespace FileHandling;

class Program
{
    static void Main(string[] args)
    {
        string filePath = @"/home/ares/Documents/MyFile.txt"; 
        
        // CreateFile.Run(FilePath);
        // WriteToFile.WriteFile(filePath, "My name is Naman Vinay Singh");
        // ReadFromFile.ReadFile(filePath);
        // StreamWriterDemo.WriteToFile(filePath, "Hello World");

        // int a = 10;
        // int b = 20;
        // int result = a + b;
        
        // StreamWriterDemo.WriteToFile(filePath, $"\n{a} + {b} = {result}");
        
        StreamReaderDemo.ReadFileLineByLine(filePath);
        StreamReaderDemo.ReadFileUptoEndOfFile(filePath);
        
        
    }
}