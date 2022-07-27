using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorMovieApp.Shared
{
    public class MoviesList : IMoviesList
    {
        List<Movie> Movies = new List<Movie>() {
            new Movie() { Id=1, Image = "https://occ-0-1527-32.1.nflxso.net/dnm/api/v6/evlCitJPPCVCry0BZlEFb5-QjKc/AAAABf1-harId4_vBBSFGqsYsUpwwii-AZ6qgBmiJ77Sv9YOZ7LoyoQEzvNQ1jpm4wlh6zWAyFjaVjhUgXotGaIXF6E5t1ReSbbFSekl9XJuhV_FHa5QQW1grUf1T4O82sGbJYGd_w.jpg?r=ccb", Title="The Gray Man", Genre= "Action" },
            new Movie() { Id=2, Image = "https://occ-0-1527-32.1.nflxso.net/dnm/api/v6/X194eJsgWBDE2aQbaNdmCXGUP-Y/AAAABUzz82BKtSyxFQLfKsS1mICi-heJukJeJ1QyMIz76kgEYz8fEgOvZeUTeFjoUQN4PNrmkWWLJ8dFespzDwSBnRdxMDvlZion97A.webp?r=dc2", Title="Gone Girl", Genre= "Suspence Thriller" },
            new Movie() { Id=3, Image = "https://occ-0-1527-32.1.nflxso.net/dnm/api/v6/X194eJsgWBDE2aQbaNdmCXGUP-Y/AAAABVbYOihBCVLoMdYZ7iRotdpJjueBsr7DWrC_NDdmsCKpJ9BtwsdAMIuCtMpFRQVtv1J5fbaCa57kcXys9wF-r3MXI6PbfowA6vU.webp?r=dac", Title="Shaw Shank Redemption", Genre= "Drama" },
            new Movie() { Id=4, Image = "https://occ-0-1527-32.1.nflxso.net/dnm/api/v6/X194eJsgWBDE2aQbaNdmCXGUP-Y/AAAABTADNIuM0OPLizVL4S7stWkYcxIbVOFg31V6_4EkArCwtf3A6dqv3bCfJyts3dhbIz2LxWxokcjftmvJBW5Wd29ypDgROZDfj3k.webp?r=ed2", Title="Gladiator", Genre= "Action Drama" },
            new Movie() { Id=5, Image = "https://occ-0-1527-32.1.nflxso.net/dnm/api/v6/X194eJsgWBDE2aQbaNdmCXGUP-Y/AAAABXkC3MrlCgUtEpGSTFMUsnS_Jnga9Bi9jpaNXQQZizzUQGs2DPXLaE_BfHSHHM5xEAWlmK6AS9_s2MicbEyCMEFA2CA6R6KzNyE.webp?r=198", Title="Kung Fu Hustle", Genre= "Action Comedy" },
            new Movie() { Id=6, Image = "https://occ-0-1527-32.1.nflxso.net/dnm/api/v6/X194eJsgWBDE2aQbaNdmCXGUP-Y/AAAABQHiy7-Yf1m46Qx5oEedBQkB2hpcDWiM78q1_joW4uTUlfXuRrfJbsMMVnfr-mTiL90QbObDCQ7LveJQGxuSVPZis4oUh3deWgo.webp?r=e8d", Title="The American", Genre= "Spy Action" },
            new Movie() { Id=7, Image = "https://occ-0-1527-32.1.nflxso.net/dnm/api/v6/X194eJsgWBDE2aQbaNdmCXGUP-Y/AAAABYPViVUJCOfDLrFnOfqcEa6etOMvDItLYfxsJDzg-8WesT_yTN6Yl15CwHIdgZuilQYQzFCqeP02eKavT5Ll6Dz9X2mKYURLHF4.webp?r=205", Title="Coach Carter", Genre= "True Life, Drama" },
            new Movie() { Id=8, Image = "https://occ-0-1527-32.1.nflxso.net/dnm/api/v6/X194eJsgWBDE2aQbaNdmCXGUP-Y/AAAABdPnpojIPo-sXPioshOXvntXBsjKZf8JA9CTnS4ulr7nR3x8_dQeUao61r99KBUkAeBBTdRrR8sls0mhJVOhmBX0yyysBsQt_W6UaGxvJe70GgFmna_Fh6N0lYzdFLyEBkn-.jpg?r=e3e", Title="A Classic Horror Story", Genre= "Horror" },
            new Movie() { Id=9, Image = "https://occ-0-1527-32.1.nflxso.net/dnm/api/v6/X194eJsgWBDE2aQbaNdmCXGUP-Y/AAAABfBZxajyZii0jl8nlnH80oEBAzR1AhwUWk1hxjxV_k6UDDn8mMCp5Qf7cp-RjVXxqThBAfaKsQkuwYUqdSL2kBJLNkqSOZPwA3UbT8Z3vJM3sDkAXkHui81avyLyl50gqIWr.jpg?r=a55", Title="Uncut Gems", Genre= "Drama" },
            new Movie() { Id=10, Image = "https://occ-0-1527-32.1.nflxso.net/dnm/api/v6/X194eJsgWBDE2aQbaNdmCXGUP-Y/AAAABbsuP4mC_oYdOZHGhGD2Ygin9oBKDmB3AiKmrr_S6Qw76e2IPB4RJIbxVn3u3DqhJW13v7AhpXcOHzfVuJT999YeziDiuR_Sxlc.webp?r=c05", Title="Interstellar", Genre= "Sci-Fi" },
            new Movie() { Id=11, Image = "https://occ-0-1527-32.1.nflxso.net/dnm/api/v6/X194eJsgWBDE2aQbaNdmCXGUP-Y/AAAABQHZ-5_G04NizP2BNPC0VcX7Dvijd8VbLkhip6XKE9HJeWi9VoK834zuauuzPQlj-UQoCfiFm4Ilbl-76rpdcR_sdkj3qU0vhmM.webp?r=21d", Title="Batman Ninja", Genre= "Animation" },
            new Movie() { Id=12, Image = "https://occ-0-1527-32.1.nflxso.net/dnm/api/v6/X194eJsgWBDE2aQbaNdmCXGUP-Y/AAAABR9gt78q7tzOHUyDxFQJWwbjl_kOVtkAhOFfIlIaCfnA1cey-TiPY5GZZggf38B8kIm3xVZQezN0RDFafkTRVk8GhUA9bUH7o3U.webp?r=6db", Title="American Outlaws", Genre= "Western" },
            new Movie() { Id=13, Image = "https://occ-0-1527-32.1.nflxso.net/dnm/api/v6/X194eJsgWBDE2aQbaNdmCXGUP-Y/AAAABUDkmcmwbT1IDdY-5qjz-8_AZxYSBxpJ56vUiHj6cbl1QNqm_Sd1Jn-e6_I4i0LqQjwUe7n3FIyGBYrXKI_sP_6nvmq5V9n0cBQ.webp?r=009", Title="Seven Years in Tibet", Genre= "Adventure" },
            new Movie() { Id=14, Image = "https://occ-0-1527-32.1.nflxso.net/dnm/api/v6/X194eJsgWBDE2aQbaNdmCXGUP-Y/AAAABdVDq2rVrWW9rzpZcnldIcRZUAO66o69bDUEjf6yjzd4l5M9W1uk12-oJ9-6jSwlY_-tGZ37UEKHP1vRNWU5sf7yHvcLDRNTnBPpUYzoZuX2eqwHJ-xhtiOcszqmwZYyXCtK.jpg?r=a3c", Title="The Outlaw King", Genre= "Period Action" },
            new Movie() { Id=15, Image = "https://occ-0-1527-32.1.nflxso.net/dnm/api/v6/X194eJsgWBDE2aQbaNdmCXGUP-Y/AAAABaoIrQNHzCfOKszfBJL5M95t3Xv_qsIsMTyLtv1m-HxpPC_CAXEnHgtMdBAvm8g2SF-0Kcd58rjLCQyvtbv2MKfG4RM-J0qqyjM.webp?r=0f1", Title="The Revenant", Genre= "Period Drama" }
        };

        List<Movie> DeletedMovies = new List<Movie>();

        List<Movie> LikedMovies = new List<Movie>();

        public List<Movie> GetMovies()
        {
            return Movies;
        }

        public List<Movie> GetDeletedMovies()
        {
            return DeletedMovies;
        }

        public List<Movie> GetLikedMovies()
        {
            return LikedMovies;
        }

        public void AddMovie(string imgUrl, string tilte, string genre)
        {
            int id = Movies.Last().Id++;
            Movie movie = new Movie() { Id = id, Image = imgUrl, Title = tilte, Genre = genre };
            Movies.Add(movie);
        }

        public void DeleteMovie(int id)
        {
            for (int i = 0; i < Movies.Count; i++)
            {
                Movie movie = Movies[i];
                if (movie.Id == id)
                {
                    DeletedMovies.Add(movie);
                    Movies.Remove(movie);
                }
            }
        }

        public void EditMovie(int id, string tilte, string genre)
        {
            for (int i = 0; i < Movies.Count; i++)
            {
                Movie movie = Movies[i];
                if (movie.Id == id)
                {
                    movie.Title = tilte;
                    movie.Genre = genre;
                }
            }

        }

        public void AddLikedMovie(int id)
        {
            for (int i = 0; i < Movies.Count; i++)
            {
                Movie movie = Movies[i];
                if (movie.Id == id)
                {
                    LikedMovies.Add(movie);
                }
            }
        }

        public void RemoveLikedMovie(int id)
        {
            for (int i = 0; i < LikedMovies.Count; i++)
            {
                Movie movie = LikedMovies[i];
                if (movie.Id == id)
                {
                    LikedMovies.Remove(movie);
                }
            }
        }
    }
}
