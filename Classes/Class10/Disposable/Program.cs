
Console.WriteLine("\n========== DISPOSABLE ==========\n");

const string FolderPath = @"..\..\..\Text";
string FilePath = Path.Combine(FolderPath, "text.txt");

static void CreateFolder(string path)
{
    if (!Directory.Exists(path))
    {
        Directory.CreateDirectory(path);
    }
}

static void CreateFile(string path)
{
    if (!File.Exists(path))
    {
        File.Create(path).Close();   
    }
}

CreateFolder(FolderPath);
CreateFile(FilePath);

#region Manual Dispose Methods

void AppendTextInFile(string text, string filePath)
{
    StreamWriter sw = new StreamWriter(filePath, true);
    sw.WriteLine(text);
    sw.Dispose(); 
}

void ReadFromFile(string path)
{
    StreamReader sr = new StreamReader(path);
    Console.WriteLine(sr.ReadToEnd());
}

void ManualDisposeExample()
{
    Console.WriteLine("Enter text part 1: ");
    string text1 = Console.ReadLine();
    AppendTextInFile(text1, FilePath);

    Console.WriteLine("Enter text part 2: ");
    string text2 = Console.ReadLine();
    AppendTextInFile(text2, FilePath);

    Console.WriteLine("Enter text part 3: ");
    string text3 = Console.ReadLine();
    AppendTextInFile(text3, FilePath);

    Console.ReadLine();

    Console.WriteLine("---------- Read ----------\n");
    ReadFromFile(FilePath);
}

ManualDisposeExample();

#endregion