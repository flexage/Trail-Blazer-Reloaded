using System.Collections.Generic;
using System.Linq;

namespace TrailBlazerReloaded
{
    class Collection
    {
        public List<Movie> ScanCollection(System.IO.DirectoryInfo collectionPath)
        {
            List<Movie> Movies = new List<Movie>();
            System.IO.DirectoryInfo[] movieDirs = null;
            System.IO.FileInfo[] metaFile = null;
            System.IO.DirectoryInfo[] trailerDir = null;
            System.IO.FileInfo[] trailerFile = null;

            if (collectionPath.Exists)
            {
                movieDirs = collectionPath.GetDirectories();

                foreach (System.IO.DirectoryInfo dirInfo in movieDirs)
                {
                    Movie tempMovie = new Movie();

                    tempMovie.MoviePath = dirInfo.FullName;

                    if (!dirInfo.Name.Contains("System Volume Information"))
                    {

                        metaFile = dirInfo.GetFiles("mymovies.xml");
                        if (metaFile.Count() != 0)
                        {
                            tempMovie.MetaFile = metaFile[0].FullName;

                            // Create new MetaXML Object
                            MetaXML MetaXML = new MetaXML();

                            // Extract MetaInfo from XML File and store in MetaXML object
                            MetaXML.ExtractMeta(metaFile[0].FullName);

                            // Set TempMovie Attributes with Meta Data from MetaXML Object
                            if (MetaXML.MetaTitle != null)
                            {
                                MetaXML.MetaTitle = MetaXML.MetaTitle.Trim();
                                if (MetaXML.MetaTitle.Length != 0)
                                {
                                    tempMovie.Title = MetaXML.MetaTitle;
                                }
                                else
                                {
                                    tempMovie.Title = dirInfo.Name;
                                }
                            }
                            else
                            {
                                tempMovie.Title = dirInfo.Name;
                            }
                            tempMovie.Year = MetaXML.MetaYear;
                            tempMovie.TmdbID = MetaXML.MetaTmdbID;
                            tempMovie.ImdbID = MetaXML.MetaImdbID;

                            trailerDir = dirInfo.GetDirectories("trailers");
                            if (trailerDir.Count() != 0)
                            {
                                tempMovie.TrailerPath = trailerDir[0].FullName;
                                trailerFile = trailerDir[0].GetFiles("*.*");
                                if (trailerFile.Count() != 0)
                                {
                                    tempMovie.TrailerFile = trailerFile[0].FullName;
                                    tempMovie.TrailerExists = true;
                                }
                            }

                            Movies.Add(tempMovie);
                            tempMovie = null;
                        }
                        else
                        {
                            tempMovie.Title = dirInfo.Name;
                        }
                    }
                }
            }
            return Movies;
        }
    }
}
