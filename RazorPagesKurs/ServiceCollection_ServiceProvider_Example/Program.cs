// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.DependencyInjection;

Console.WriteLine("Hello, World!");


//IOC Container wird mit Diensten oder Objekten initialisiert
IServiceCollection serviceCollection = new ServiceCollection();

//Wir legen den MovieService in den IOC Container rein -> Registrierung eines Services
serviceCollection.AddSingleton<IMovieService, MovieService>();


//Einschränkungen unseres IOC Containers
//Wenn das Interface schon verwendet wird, wird die Implementierte Klasse überschrieben
//serviceCollection.AddSingleton<IMovieService, MovieService2>();

//Auch wenn anderes Scope->auch wird überschrieben 
serviceCollection.AddScoped<IMovieService, MovieService2>();

//Wir beenden den Initialisierung Prozess des IOC Container und danach sind die Dienste verwendbar -> Seperation of Concerne
IServiceProvider serviceProvider = serviceCollection.BuildServiceProvider();

//GetRequiredService vs. GetServices
//Beide geben einen Service zurücl

//Unterschied zwischen beiden Varianten, besteht im Eksalationsfall:

// - GetRequiredService liefert bei nicht finden eines Services eine Exception zurück
IMovieService service2 = serviceProvider.GetRequiredService<IMovieService>();

// - GetService liefert bei nicht finden eines Services NULL zurück
IMovieService? service1 = serviceProvider.GetService<IMovieService>();


#region Movie Service
public interface IMovieService
{
    public IList<Movie> GetAll();
}


public class MovieService : IMovieService
{
    private IList<Movie> movies;

    public MovieService()
    {
        movies = new List<Movie>();
        movies.Add(new Movie() { Id = 1, Title = "Coda" });
        movies.Add(new Movie() { Id = 2, Title = "Batman" });
    }

    public IList<Movie> GetAll()
        => movies;
}

public class MovieService2 : IMovieService
{
    private IList<Movie> movies;

    public MovieService2()
    {
        movies = new List<Movie>();
        movies.Add(new Movie() { Id = 1, Title = "Coda" });
        movies.Add(new Movie() { Id = 2, Title = "Batman" });

        movies.Add(new Movie() { Id = 1, Title = "Jurassic Park" });
        movies.Add(new Movie() { Id = 2, Title = "King Richard" });
    }

    public IList<Movie> GetAll()
        => movies;
}


public class Movie
{
    public int Id { get; set; }
    public string Title { get; set; }
}

#endregion 

