string[] data = GetDataFromMyFile();
ReadDataFromArray(data);

static string[] GetDataFromMyFile()
{
    string filePath = @"/Users/marttiumbleja/Projects/Data/movies.txt";
    return File.ReadAllLines(filePath);
}

static void ReadDataFromArray(string[] someArray)
{
    foreach(string line in someArray)
    {
        Console.WriteLine(line);
    }
}