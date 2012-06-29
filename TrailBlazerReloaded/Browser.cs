using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.Drawing;
using WatTmdb.V3;

namespace TrailBlazerReloaded
{
    public partial class Browser : Form
    {
        private Config config;
        private List<Movie> MovieList = new List<Movie>();

        public Browser()
        {
            InitializeComponent();
        }

        private void Browser_Shown(object sender, EventArgs e)
        {
            ReadConfig();
            ScanCollection();
        } 

        private void ReadConfig()
        {
            // Read app config from Config.xml
            config = new Config();

            if (File.Exists("config.xml"))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Config));

                StreamReader reader = new StreamReader("config.xml");
                config = (Config)serializer.Deserialize(reader);
                reader.Close();

                serializer = null;
                reader = null;
            }
            else
            {
                // Create Default config.xml values
                Config.Definition[] defaultDefinitions = new Config.Definition[3];
                defaultDefinitions[0] = new Config.Definition { Type = "1080p", Active = true };
                defaultDefinitions[1] = new Config.Definition { Type = "720p", Active = true };
                defaultDefinitions[2] = new Config.Definition { Type = "480p", Active = true };

                config.DefinitionsCollection = defaultDefinitions;

                // Create and Write Default config.xml
                config.WriteConfig(config);
            }
        }

        private void ScanCollection()
        {
            if (config.CollectionPaths != null && config.CollectionPaths.Count() != 0)
            {
                MovieList = null;
                MovieList = new List<Movie>();

                this.olvMovies.Items.Clear();

                // Load movie collection from movie collection folders
                int collectionCount = config.CollectionPaths.Count();

                for (int i = 0; i < collectionCount; i++)
                {
                    Collection movieCollection = new Collection();

                    List<Movie> tempMovieList = movieCollection.ScanCollection(new System.IO.DirectoryInfo(config.CollectionPaths[i]));

                    MovieList.AddRange(tempMovieList);

                    tempMovieList = null;
                }

                this.olvMovies.AddObjects(MovieList);
            }
        }

        private void configToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigForm configForm = new ConfigForm(config);
            configForm.ShowDialog();
            config = configForm.ConfigFile;
            ScanCollection();
        }

        private void btnFetchAll_Click(object sender, EventArgs e)
        {
            //foreach (Movie movie in MovieList)
            int id;
            for (id = 0; id < olvMovies.Items.Count; id++)
            {

                switch ("tmdb")
                {
                    case "tmdb":
                        FetchTMDB(id);
                        break;

                    case "trakt":
                        FetchTrakt(id);
                        break;

                    default:

                        break;
                }

            }
        }

        private void FetchTMDB(int id)
        {
            //Generate movie list before and pass movies into this function ONE by ONE
            
            TMDb tmdbQuery = new TMDb();
            List<Youtube> TMDBResponse = new List<Youtube>();
            TMDBResponse = tmdbQuery.getYoutubeTrailerURL(MovieList[id]);

            if (TMDBResponse != null && TMDBResponse.Count != 0)
            {
                apiTextBox.Text = apiTextBox.Text + "\r\n" + MovieList[id].Title + ": " + TMDBResponse[0].name + " - " + TMDBResponse[0].size + " - " + TMDBResponse[0].source;
            }

            //ONLY TEMP - Set ObjectListView Background Colors (Later move these to after DOWNLOADS HAVE COMPLETED OR NOT AND RUN AT COLLECTION SCAN TIME)
            if (TMDBResponse != null && TMDBResponse.Count != 0 && TMDBResponse[0].source.Length != 0)
            {
                olvMovies.Items[id].BackColor = Color.FromArgb(10, 200, 255, 200);
            }
            else
            {
                olvMovies.Items[id].BackColor = Color.FromArgb(10, 255, 200, 200);
            }

            olvMovies.Refresh();
        }

        private void FetchTrakt(int id)
        {
            Trakt traktQuery = new Trakt();

            string TraktResponse = traktQuery.GetMovieTrailer(MovieList[id].TmdbID);

            //ONLY TEMP - Set ObjectListView Background Colors (Later move these to after DOWNLOADS HAVE COMPLETED OR NOT AND RUN AT COLLECTION SCAN TIME)
            if (TraktResponse != null && TraktResponse.Length != 0)
            {
                apiTextBox.Text = apiTextBox.Text + TraktResponse + "\r\n";
                olvMovies.Items[id].BackColor = Color.FromArgb(10, 200, 255, 200);
            }
            else
            {
                olvMovies.Items[id].BackColor = Color.FromArgb(10, 255, 200, 200);
            }

            olvMovies.Refresh();
        }

        private void btnRefreshCollection_Click(object sender, EventArgs e)
        {
            ScanCollection();
        }
    }
}
