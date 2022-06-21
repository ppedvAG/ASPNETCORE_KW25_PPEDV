// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.DependencyInjection;

Console.WriteLine("Hello, World!");

IServiceCollection collection = new ServiceCollection();


collection.AddSingleton<ISingletonMovieService, MovieService>();

collection.AddScoped<IScopedMovieService, MovieService2>();





public interface IMovieService
{
    public IList<Movie> GetAll();
}

public interface ISingletonMovieService : IMovieService
{

}

public interface IScopedMovieService : IMovieService
{

}

public class Movie
{
    public int Id { get; set; }
    public string Title { get; set; }
}


public class MovieService : ISingletonMovieService, IScopedMovieService
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



public class MovieService2 : ISingletonMovieService, IScopedMovieService
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