
using Newtonsoft.Json;
using SerializationDeserialization.Demo;
using System.Text.Json.Serialization;

void WriteInFile(string path, string text)
{
    using (StreamWriter sw = new StreamWriter(path))
    {
        sw.WriteLine(text);   
           
    }
}

string ReadFromFile(string path)
{
    using (StreamReader sr = new StreamReader(path))
    {
        return sr.ReadToEnd();
           
    }
}

string directoryPath = @"..\..\..\OurData";
string filePath = Path.Combine(directoryPath, "myFirstJson.json");

#region Manual Serialization\Deseralization

if (!Directory.Exists(directoryPath))
{
    Directory.CreateDirectory(directoryPath);
}

Student bob = new Student()
{
    FirstName = "Bob",
    LastName = "Bobsky",
    Age = 33,
    IsPartTime = false
};

WriteInFile(filePath, bob.ToString());

#endregion

#region MyRegion

string bobSerializedNewtonsoftJson = JsonConvert.SerializeObject(bob, Formatting.Indented);
WriteInFile(filePath, bobSerializedNewtonsoftJson);

Student bobDeserializedNewtonsoft = JsonConvert.DeserializeObject<Student>(bobSerializedNewtonsoftJson);


#endregion