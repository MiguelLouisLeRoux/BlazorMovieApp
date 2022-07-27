namespace BlazorMovieApp.Shared
{
    public interface IMoviesList
    {
        void AddMovie(string imgUrl, string tilte, string genre);
        void DeleteMovie(int id);
        void EditMovie(int id, string tilte, string genre);
        List<Movie> GetDeletedMovies();
        List<Movie> GetLikedMovies();
        List<Movie> GetMovies();
        void AddLikedMovie(int id);
        void RemoveLikedMovie(int id);
    }
}