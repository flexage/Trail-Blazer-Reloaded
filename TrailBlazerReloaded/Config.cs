using System;
using System.IO;
using System.Collections.Generic;
using System.Reflection;
using System.Xml;
using System.Xml.Serialization;

namespace TrailBlazerReloaded
{
    public class Config
    {
        Config config = null;
        XmlSerializer serializer = new XmlSerializer(typeof(Config));

        public Config()
        {
            CollectionPaths = null;
            DefinitionsCollection = new Definition[3];
            TrailerPath = "";
        }

        public string Version { get; set; }

        public string[] CollectionPaths { get; set; }



        public class Definition
        {
            [XmlAttribute("active")]
            public bool Active { get; set; }

            [XmlText]
            public string Type { get; set; }
        }

        [XmlElement("Definition")]
        public Definition[] DefinitionsCollection { get; set; }



        public string TrailerPath { get; set; }

        public void WriteConfig(Config configToSave)
        {
            serializer = new XmlSerializer(typeof(Config));
            TextWriter textWriter = new StreamWriter(@"config.xml");
            serializer.Serialize(textWriter, configToSave);
            textWriter.Close();
        }

        public Config ReadConfig()
        {
            if (File.Exists(@"config.xml"))
            {
                var reader = new StreamReader("config.xml");
                config = (Config) serializer.Deserialize(reader);
                reader.Close();
            }

            return config;
        }

        public static string GetConfigFilePath()
        {
            return Assembly.GetExecutingAssembly().Location + ".config";
        }

    }
}
