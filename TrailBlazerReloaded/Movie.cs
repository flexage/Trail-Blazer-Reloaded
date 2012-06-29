using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrailBlazerReloaded
{
    class Movie
    {
        // =========================
        // #  Movie Object Class   #
        // -------------------------
        // Contains Movie Parameters
        // ================================

        public Movie()
        {

        }

        public string Title { get; set; }

        public string Year { get; set; }

        public string TmdbID { get; set; }

        public string ImdbID { get; set; }

        public string MoviePath { get; set; }

        public string MetaFile { get; set; }

        public bool TrailerExists { get; set; }

        public string TrailerPath { get; set; }

        public string TrailerFile { get; set; }
    }
}
