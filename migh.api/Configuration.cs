using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JsonTools;
using System.IO;

namespace migh.api
{
    public class Configuration
    {
        public class Cookie
        {
            public string su { get; set; }
            public string u { get; set; }
            public string p { get; set; }
        }
        public static Configuration Data = new Configuration();
        public static string ConfigFileName = "migh.config";
        public static string LibraryFileName = "migh.lib";
        
        public List<WebFile> WebFile_List = new List<WebFile>();
        public List<ReplaceText> GitHubFile_TextToReplace_List = new List<ReplaceText>();
        public List<ReplaceText> GitHubFile_TextToReplace_HTML_List = new List<ReplaceText>();
        public string AudioFileURLFormat { get; set; }
        public string AlbumCoverImageFileURLFormat { get; set; }

        //public static void Save()
        //{
        //    string json = Data.ToJsonString();
        //    File.WriteAllText(ConfigFileName, json);
        //}

        //public static void Load()
        //{
        //    string json = "";
        //    if (!File.Exists(ConfigFileName))
        //    {
        //        Save();
        //    }
        //    using (StreamReader sr = new StreamReader(ConfigFileName))
        //    {
        //        json = sr.ReadToEnd();
        //    }
        //    Data = json.ToObject<Configuration>();
        //}
    }
}
