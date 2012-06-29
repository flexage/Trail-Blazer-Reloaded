using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace TrailBlazerReloaded
{
    class MetaXML
    {
        private string mMetaTitle;
        private string mMetaYear;
        private string mMetaTmdbID;
        private string mMetaImdbID;

        public MetaXML()
        {

        }

        public string MetaTitle
        {
            get { return mMetaTitle; }
            set { mMetaTitle = value; }
        }

        public string MetaYear
        {
            get { return mMetaYear; }
            set { mMetaYear = value; }
        }

        public string MetaTmdbID
        {
            get { return mMetaTmdbID; }
            set { mMetaTmdbID = value; }
        }

        public string MetaImdbID
        {
            get { return mMetaImdbID; }
            set { mMetaImdbID = value; }
        }

        public void ExtractMeta(string MetaFile)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(MetaFile);

            XmlNodeList MetaTitle = xmlDoc.GetElementsByTagName("LocalTitle");
            XmlNodeList MetaTmdbID = xmlDoc.GetElementsByTagName("TMDbId");
            XmlNodeList MetaYear = xmlDoc.GetElementsByTagName("ProductionYear");
            XmlNodeList MetaImdbID = xmlDoc.GetElementsByTagName("IMDbId");

            if (MetaTitle.Count != 0)
            {
                mMetaTitle = MetaTitle[0].InnerText;
            }
            if (MetaYear.Count != 0)
            {
                mMetaYear = MetaYear[0].InnerText;
            }
            if (MetaTmdbID.Count != 0)
            {
                mMetaTmdbID = MetaTmdbID[0].InnerText;
            }
            if (MetaImdbID.Count != 0)
            {
                mMetaImdbID = MetaImdbID[0].InnerText;
            }
        }
    }
}
