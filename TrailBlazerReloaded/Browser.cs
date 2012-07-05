using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.Drawing;
using WatTmdb.V3;
using YoutubeExtractor;

namespace TrailBlazerReloaded
{
    public partial class Browser : Form
    {
        private Config config;
        private List<Movie> MovieList = new List<Movie>();
        private int DefinitionCounter = 0;

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
                defaultDefinitions[2] = new Config.Definition { Type = "360p", Active = true };

                config.DefinitionsCollection = defaultDefinitions;

                Config.Provider[] defaultProviders = new Config.Provider[2];
                defaultProviders[0] = new Config.Provider { Name = "TheMovieDB.org", Active = true };
                defaultProviders[1] = new Config.Provider { Name = "Trakt.tv", Active = true };

                config.ProvidersCollection = defaultProviders;

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

        private void menuItemFetch_Click(object sender, EventArgs e)
        {
            bool trailerFound = false;

            for (int i = 0; trailerFound == false && i < config.DefinitionsCollection.Count(); i++)
            {
                if (config.DefinitionsCollection[i].Active == true)
                {
                    for (int j = 0; trailerFound == false && j < config.ProvidersCollection.Count(); j++)
                    {
                        if (config.ProvidersCollection[j].Active == true)
                        {
                            trailerFound = FetchTrailer(olvMovies.SelectedIndex, config.ProvidersCollection[j].Name, config.DefinitionsCollection[i].Type);
                        }
                    }
                }
            }
        }

        private void btnFetchAll_Click(object sender, EventArgs e)
        {
            int id;
            for (id = 0; id < olvMovies.Items.Count; id++)
            {
                bool trailerFound = false;

                for (int i = 0; trailerFound == false && i < config.DefinitionsCollection.Count(); i++)
                {
                    if (config.DefinitionsCollection[i].Active == true)
                    {
                        for (int j = 0; trailerFound == false && j < config.ProvidersCollection.Count(); j++)
                        {
                            if (config.ProvidersCollection[j].Active == true)
                            {
                                trailerFound = FetchTrailer(id, config.ProvidersCollection[j].Name, config.DefinitionsCollection[i].Type);
                            }
                        }
                    }
                }
            }
        }

        private bool FetchTrailer(int id, string provider, string definition)
        {
            bool found;
            switch (provider)
            {
                case "TheMovieDB.org":
                    found = FetchTMDB(id, definition);
                    break;

                case "Trakt.tv":
                    found = FetchTrakt(id, definition);
                    break;

                default:
                    found = false;
                    break;
            }

            return found;
        }

        private bool FetchTMDB(int id, string definition)
        {
            // Generate movie list beforehand and pass movies into this function ONE by ONE

            bool found = false;
            TMDb tmdbQuery = new TMDb();
            List<Youtube> TMDBResponse = new List<Youtube>();
            TMDBResponse = tmdbQuery.getYoutubeTrailerURL(MovieList[id]);
            bool notFound = false;

            IEnumerable<VideoInfo> videoInfos = null;

            try
            {
                videoInfos = DownloadUrlResolver.GetDownloadUrls("http://www.youtube.com/watch?v=" + TMDBResponse[0].source);
            }
            catch (Exception ex)
            {
                notFound = true;
            }
            

            VideoInfo video = null;

            if (notFound == false)
            {
                switch (definition)
                {
                    case "1080p":
                        video = videoInfos.FirstOrDefault(info => info.VideoFormat == VideoFormat.HighDefinition1080);
                        break;

                    case "720p":
                        video = videoInfos.FirstOrDefault(info => info.VideoFormat == VideoFormat.HighDefinition720);
                        break;

                    case "360p":
                        video = videoInfos.FirstOrDefault(info => info.VideoFormat == VideoFormat.Standard360);
                        break;

                    default:

                        break;
                }
            }

            if (video != null)
            {
                //ONLY TEMP - Set ObjectListView Background Colors (Later move these to after DOWNLOADS HAVE COMPLETED OR NOT AND RUN AT COLLECTION SCAN TIME)
                if (TMDBResponse != null && TMDBResponse.Count != 0 && TMDBResponse[0].source.Length != 0)
                {
                    apiTextBox.Text = apiTextBox.Text + "#TMDb \t" + MovieList[id].Title + ": FOUND @ '" + definition + "' Definition \r\n";
                    olvMovies.Items[id].BackColor = Color.FromArgb(10, 200, 255, 200);
                    found = true;
                }
                else
                {
                    olvMovies.Items[id].BackColor = Color.FromArgb(10, 255, 200, 200);
                }

                olvMovies.Refresh();

                found = true;
            }
            else
            {
                apiTextBox.Text = apiTextBox.Text + "#TMDb \t" + MovieList[id].Title + ": NOT FOUND @ '" + definition + "' Definition \r\n";
            }

            return found;
        }

        private bool FetchTrakt(int id, string definition)
        {
            // Generate movie list beforehand and pass movies into this function ONE by ONE

            bool found = false;
            Trakt traktQuery = new Trakt();
            string TraktResponse = traktQuery.GetMovieTrailer(MovieList[id].TmdbID);
            bool notFound = false;

            IEnumerable<VideoInfo> videoInfos = null;

            try
            {
                videoInfos = DownloadUrlResolver.GetDownloadUrls(TraktResponse);
            }
            catch (Exception ex)
            {
                notFound = true;
            }

            VideoInfo video = null;

            if (notFound == false)
            {
                switch (definition)
                {
                    case "1080p":
                        video = videoInfos.FirstOrDefault(info => info.VideoFormat == VideoFormat.HighDefinition1080);
                        break;

                    case "720p":
                        video = videoInfos.FirstOrDefault(info => info.VideoFormat == VideoFormat.HighDefinition720);
                        break;

                    case "360p":
                        video = videoInfos.FirstOrDefault(info => info.VideoFormat == VideoFormat.Standard360);
                        break;

                    default:

                        break;
                }
            }

            if (video != null)
            {
                //ONLY TEMP - Set ObjectListView Background Colors (Later move these to after DOWNLOADS HAVE COMPLETED OR NOT AND RUN AT COLLECTION SCAN TIME)
                if (TraktResponse != null && TraktResponse.Length != 0)
                {
                    apiTextBox.Text = apiTextBox.Text + "#Trakt \t" + MovieList[id].Title + ":  FOUND @ '" + definition + "' Definition \r\n";
                    olvMovies.Items[id].BackColor = Color.FromArgb(10, 200, 255, 200);
                    found = true;
                }
                else
                {
                    olvMovies.Items[id].BackColor = Color.FromArgb(10, 255, 200, 200);
                }

                olvMovies.Refresh();

                found = true;
            }
            else
            {
                apiTextBox.Text = apiTextBox.Text + "#Trakt \t" + MovieList[id].Title + ": NOT FOUND @ '" + definition + "' Definition \r\n";
            }
            return found;
        }

        private void btnRefreshCollection_Click(object sender, EventArgs e)
        {
            ScanCollection();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }
    }
}
