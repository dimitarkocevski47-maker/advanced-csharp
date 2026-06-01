
Console.WriteLine("\n========== FILE STREAMS ==========\n");

// SETUP
string folderPath = @"..\..\..\TestFiles";

if (!Directory.Exists(folderPath))
{
    Directory.CreateDirectory(folderPath);
}

string fileName = "notes.txt";
string filePath = Path.Combine(folderPath, fileName);

Console.WriteLine("\n========== StreamWriter ==========\n");

try
{
    using (StreamWriter streamWriter = new StreamWriter(filePath))
    {
        streamWriter.WriteLine("This is a simple note.");
        streamWriter.WriteLine("StreamWriter lets us write text line by line efficiently.");
        streamWriter.WriteLine("It also allows you to append OR overwrite.");
    }
}
catch (Exception ex)
{
    Console.WriteLine("Error writing in file. Error: " + ex.Message);
}