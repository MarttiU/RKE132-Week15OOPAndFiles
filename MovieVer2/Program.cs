
List<Movie> myMovies = new List<Movie>();
string[] data = GetDataFromMyFile();
//ReadDataFromArray(data);

foreach(string line in data)
{
    string[] tempArray = line.Split(new char[] {';'}, StringSplitOptions.RemoveEmptyEntries);
    Movie newMovie = new Movie(tempArray[0], tempArray[2]);
    myMovies.Add(newMovie);
}

foreach(Movie movie in myMovies)
{
    Console.WriteLine($"One of my favorite movies {movie.Titel} was released on {movie.Year}");
}

static string[] GetDataFromMyFile()
{
    string filePath = @"/Users/marttiumbleja/Projects/Data/movies.txt";
    return File.ReadAllLines(filePath);
}

static void ReadDataFromArray(string[] someArray)
{
    foreach (string line in someArray)
    {
        Console.WriteLine(line);
    }
}

class Movie
{
    string titel; //fields, allkriipsu pole vaja
    string year;

    public string Titel
    {
        get { return titel; }
    }

    public string Year
    {
        get { return year; }
    }

    public Movie(string _titel, string _year)
    {
        titel = _titel;
        year = _year;
    }

}