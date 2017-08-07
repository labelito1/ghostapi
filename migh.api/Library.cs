using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using JsonTools;
using System.IO;
namespace migh.api
{
    public class Library
    {
        public List<User> user_list = new List<User>();
        public List<Artist> artist_list = new List<Artist>();
        public List<Album> album_list = new List<Album>();
        public List<Song> song_list = new List<Song>();
        public Configuration configuration = new Configuration();
        public int Version = 0;

        public Library()
        {
            user_list = new List<User>();
            artist_list = new List<Artist>();
            album_list = new List<Album>();
            song_list = new List<Song>();
        }
        public Library(string source_link, string username, string password)
        {
            Library lib = null;
            using (WebClient wc = new WebClient())
            {
                wc.Credentials = new NetworkCredential(username, password);
                try
                {
                    wc.Encoding = System.Text.Encoding.UTF8;
                    var json = wc.DownloadString(source_link);
                    lib = json.ToObject<Library>();
                    if(lib != null)
                    {
                        user_list = lib.user_list;
                        artist_list = lib.artist_list;
                        album_list = lib.album_list;
                        song_list = lib.song_list;
                        Version = lib.Version;
                        configuration = lib.configuration;
                    }
                }
                catch { }
            }
        }

        public static bool write_local(Library library, string file)
        {
            try
            {
                string json = library.ToJsonString();
                try
                {
                    File.WriteAllText(@file, json);
                }
                catch
                {
                    return false;
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static string read_local(string file)
        {
            string json = null;
            if (!File.Exists(@file))
            {
                Library lib = new Library();
                write_local(lib, file);
            }
            using (StreamReader sr = new StreamReader(@file))
            {
                json = sr.ReadToEnd();
            }
            return json;
        }
    }
}
