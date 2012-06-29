using System.Collections.Generic;
using WatTmdb.V3;

namespace TrailBlazerReloaded
{
    class TMDb
    {
        private string mApiKey = "25e147b049c60ae416438d428bac1e45";
        private string mYoutubeTrailerURL = null;

        public TMDb()
        {

        }

        public string YoutubeTrailerURL
        {
            get { return mYoutubeTrailerURL; }
            set { mYoutubeTrailerURL = value; }
        }

        public List<Youtube> getYoutubeTrailerURL(Movie currentMovie)
        {
            bool noExist = false;
            int TmdbID = 0;
            List<Youtube> youtube = new List<Youtube>();
            Tmdb api = new Tmdb(mApiKey, "en");

            if (currentMovie.TmdbID == null)
            {
                // Search TMDB by title + year for correct movie ID
                TmdbMovieSearch movie = api.SearchMovie(currentMovie.Title, 1);
                List<MovieResult> movieResults = movie.results;
                if (movieResults.Count != 0)
                {
                    TmdbID = movieResults[0].id;
                }
                else
                {
                    noExist = true;
                }
            }
            else
            {
                // Parse String TMDBID to Int
                int.TryParse(currentMovie.TmdbID, out TmdbID);
            }

            if (noExist == false)
            {
                TmdbMovieTrailers trailers = api.GetMovieTrailers(TmdbID);
                if (trailers.youtube != null)
                {
                    youtube = trailers.youtube;
                }
                else
                {
                    youtube = null;
                }
            }
            else
            {
                youtube = null;
            }
            return youtube;
        }
    }
}
