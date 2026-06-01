
Console.WriteLine("\n========== WORKING WITH FILE SYSTEM ==========\n");

#region Paths
Console.WriteLine("\n========== PATHS ==========\n");

// ===> ABSOLUTE PATHS
string studentRepoClassFullPath = @"C:\Users\code\Desktop\advanced-csharp\Classes\Class09\FileSystem\Program.cs";
string studentRepoClassHomeworkFullPath = @"C:\Users\code\Desktop\advanced-csharp\Homeworks";

// ===> RELATIVE PATHS
string classReadmeRelativePaths = @"..\..\..\..\..\..\README.md";
#endregion

#region Directory
Console.WriteLine("\n========== DIRECTORY (Folder) ==========\n");

// ===> Get Current Directory 
string currentDirectory = Directory.GetCurrentDirectory();
Console.WriteLine($"Current Directory: {currentDirectory}");

// ===> Check if a folder exists 
string testFolderPath = @"..\..\..\TestFolder";

bool testFolderExists = Directory.Exists(testFolderPath);

Console.WriteLine("The folder 'TestFolder exists {0}", testFolderExists);

// ===> Create new folder if it dosen't exists
if (!testFolderExists)
{
    Directory.CreateDirectory(testFolderPath);
    Console.WriteLine("Succefully created folder TestFolder.");
} 
else
{
    Console.WriteLine("TestFolder alredy exists.");
}

// ===> Delete a folder
if (Directory.Exists(testFolderPath))
{
    // Directory.Delete(testFolderPath);
    Directory.Delete(testFolderPath, recursive: true);
}

#endregion

#region File
Console.WriteLine("\n========== FILE ==========\n");

// ===> Check if a file exists
testFolderPath = @"..\..\..\TestFolder";
string fileName = "example.txt";

//string filePath = $@"{testFolderPath}\{fileName}";
string filePath = Path.Combine(testFolderPath, fileName);

bool fileExists = File.Exists(filePath);

if (!Directory.Exists(testFolderPath))
{
    Directory.CreateDirectory(testFolderPath);
}

// Create a new file
if (!fileExists)
{
    File.Create(filePath)
        .Close();
}
else
{
    Console.WriteLine("File alredy exists");
}

// ===> Delete a file
//if (File.Exists(filePath))
//{
//    File.Delete(filePath);
//    Console.WriteLine("Succesfully deleted a file 'example.txt'.");
//}

// ===> Write to a file
File.WriteAllText(filePath, "Hello from SEDC :)\n");

//File.WriteAllText(filePath, "Hello from Avenga Academy!");
File.AppendAllText(filePath, "Hello from Avenga Academy!");

// ===> Read from a file
string fileContent = File.ReadAllText(filePath);
Console.WriteLine("File content:\n");
Console.WriteLine(fileContent);

// ===> Get File Info
FileInfo fileInfo = new FileInfo(filePath);
Console.WriteLine("\nThe File's info: ");
Console.WriteLine("Full Name " + fileInfo.FullName);
Console.WriteLine("File Name " + fileInfo.Name);
Console.WriteLine("Extension " + fileInfo.Extension);
Console.WriteLine("Size " + fileInfo.Length + " bytes");
Console.WriteLine("Last modified " + fileInfo.LastWriteTime);

#endregion