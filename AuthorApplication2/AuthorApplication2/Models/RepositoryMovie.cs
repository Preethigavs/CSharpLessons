using Microsoft.Data.SqlClient;
using System.Data;

namespace AuthorApplication2.Models
{
    public class RepositoryMovie
    {
        public static List<Movies> GetMovieList()
        {
            List<Movies> movielist = new List<Movies>();
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != System.Data.ConnectionState.Open)
                    cn.Open();
                SqlCommand selectmoviecmd = cn.CreateCommand();
                String selectAllMovies = "Select * from Movies";
                selectmoviecmd.CommandText = selectAllMovies;
                SqlDataReader moviedr = selectmoviecmd.ExecuteReader();
                while (moviedr.Read())
                {
                    Movies movie = new Movies
                  
                    {
                        ID = moviedr.GetInt32(0),
                        Title = moviedr.GetString(1),
                        Language = moviedr.GetString(2),
                        Hero = moviedr.GetString(3),
                        Director = moviedr.GetString(4),
                        MusicDirector = moviedr.GetString(5),
                        ReleaseDate = moviedr.GetDateTime(6),
                        Cost = moviedr.GetDecimal(7) ,
                        Collection = moviedr.GetDecimal(8),
                        Review = moviedr.GetString(9)

                    };
                    movielist.Add(movie);
                }
            }

            return movielist;

        }
        public static Movies GetMovieID(int id)
        {
            Movies movieFound = null;
           
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != System.Data.ConnectionState.Open)
                    cn.Open();


                SqlCommand selectmoviecmd = cn.CreateCommand();
                String selectmovie = "Select * from Movies where ID=@id";
                selectmoviecmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                selectmoviecmd.CommandText = selectmovie;
                SqlDataReader moviedr = selectmoviecmd.ExecuteReader();
                while (moviedr.Read())
                {
                    movieFound = new Movies
                    {
                        ID = moviedr.GetInt32(0),
                        Title = moviedr.GetString(1),
                        Language = moviedr.GetString(2),
                        Hero = moviedr.GetString(3),
                        Director = moviedr.GetString(4),
                        MusicDirector = moviedr.GetString(5),
                        ReleaseDate = moviedr.GetDateTime(6),
                        Cost = moviedr.GetDecimal(7),
                        Collection = moviedr.GetDecimal(8),
                        Review = moviedr.GetString(9)

                    };

                }
            }
            return movieFound;
        }
        public static int AddNewMovie(Movies newMovie)
        {
            int query_result = 0;
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand insertMoviecmd = cn.CreateCommand();
                String insertNewMovieQuery = "insert into Movies values( @ID,@Title,@Language,@Hero,@Director,@MusicDirector,@ReleaseDate,@Cost,@Collection,@Review )";
                insertMoviecmd.Parameters.Add("@ID", SqlDbType.Int).Value = newMovie.ID;
                insertMoviecmd.Parameters.Add("@Title", SqlDbType.NVarChar).Value = newMovie.Title;
                insertMoviecmd.Parameters.Add("@Language", SqlDbType.NVarChar).Value = newMovie.Language;
                insertMoviecmd.Parameters.Add("@Hero", SqlDbType.NVarChar).Value = newMovie.Hero;
                insertMoviecmd.Parameters.Add("@Director", SqlDbType.NVarChar).Value = newMovie.Director;
                insertMoviecmd.Parameters.Add("@MusicDirector", SqlDbType.NVarChar).Value = newMovie.MusicDirector;
                insertMoviecmd.Parameters.Add("@ReleaseDate", SqlDbType.DateTime).Value = newMovie.ReleaseDate;
                insertMoviecmd.Parameters.Add("@Cost", SqlDbType.Decimal).Value = newMovie.Cost;
                insertMoviecmd.Parameters.Add("@Collection", SqlDbType.Decimal).Value = newMovie.Collection;
                insertMoviecmd.Parameters.Add("@Review", SqlDbType.NVarChar).Value = newMovie.Review;
                insertMoviecmd.CommandText = insertNewMovieQuery;
                query_result = insertMoviecmd.ExecuteNonQuery(); // insert stmt is a non-query - it is a reader 
            }
            return query_result; // no of rows inserted
        }

        public static int UpdateMovie(Movies modifiedMovie)
        {
            int query_result = 0;
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand updateMoviecmd = cn.CreateCommand();
                String updateMovieQuery = "Update Movies set ID=@id, Title=@Title,Language=@Language, Hero=@Hero, Director=@Director, MusicDirector=@MusicDirector, ReleaseDate=@ReleaseDate, Cost=@Cost, Collection=@Collection, Review=@Review where ID=@ID";
                updateMoviecmd.Parameters.Add("@ID", SqlDbType.Int).Value = modifiedMovie.ID;
                updateMoviecmd.Parameters.Add("@Title", SqlDbType.NVarChar).Value = modifiedMovie.Title;
                updateMoviecmd.Parameters.Add("@Language", SqlDbType.NVarChar).Value = modifiedMovie.Language;
                updateMoviecmd.Parameters.Add("@Hero", SqlDbType.NVarChar).Value = modifiedMovie.Hero;
                updateMoviecmd.Parameters.Add("@Director", SqlDbType.NVarChar).Value = modifiedMovie.Director;
                updateMoviecmd.Parameters.Add("@MusicDirector", SqlDbType.NVarChar).Value = modifiedMovie.MusicDirector;
                updateMoviecmd.Parameters.Add("@ReleaseDate", SqlDbType.DateTime).Value = modifiedMovie.ReleaseDate;
                updateMoviecmd.Parameters.Add("@Cost", SqlDbType.Decimal).Value = modifiedMovie.Cost;
                updateMoviecmd.Parameters.Add("@Collection", SqlDbType.Decimal).Value = modifiedMovie.Collection;
                updateMoviecmd.Parameters.Add("@Review", SqlDbType.NVarChar).Value = modifiedMovie.Review;
                updateMoviecmd.CommandText = updateMovieQuery;
                query_result = updateMoviecmd.ExecuteNonQuery();
            }
            return query_result;
        }

        public static int DeleteMovie(int id)
        {
            int query_result = 0;
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand deleteMoviecmd = cn.CreateCommand();
                String deleteEmpQuery = "Delete from Movies where ID=@id";
                deleteMoviecmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                deleteMoviecmd.CommandText = deleteEmpQuery;
                query_result = deleteMoviecmd.ExecuteNonQuery();
            }
            return query_result;
        }
    }
}
