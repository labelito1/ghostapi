using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace migh.api
{
    public class Song
    {
        public int id { get; set; }
        public int album_id { get; set; }
        public int artist_id { get; set; }
        public string name { get; set; }
        public string file_name { get; set; }
        public string url_name { get; set; }

        public override string ToString()
        {
            return name;
        }

        #region get
        public Song get(List<Song> song_list, int song_id)
        {
            foreach(Song s in song_list)
            {
                if(s.id == song_id)
                {
                    return s;
                }
            }
            return null;
        }

        public static List<Song> getByAlbum(List<Song> song_list, int album_id)
        {
            List<Song> list = new List<Song>();
            foreach (Song s in song_list)
            {
                if (s.album_id == album_id)
                {
                    list.Add(s);
                }
            }
            return list;
        }

        public static List<Song> getByArtist(List<Song> song_list, int artist_id)
        {
            List<Song> list = new List<Song>();
            foreach (Song s in song_list)
            {
                if (s.artist_id == artist_id)
                {
                    list.Add(s);
                }
            }
            return list;
        }
        #endregion

        #region set
        public static void set(ref List<Song> song_list, int song_id, Song new_song)
        {
            foreach(Song s in song_list)
            {
                if(s.id == song_id)
                {
                    s.album_id = new_song.album_id;
                    s.artist_id = new_song.artist_id;
                    s.name = new_song.name;
                    s.file_name = new_song.file_name;
                    s.url_name = new_song.url_name;
                    return;
                }
            }
        }
        #endregion

        #region remove
        public static void remove(ref List<Song> song_list, int song_id)
        {
            List<Song> aux = new List<Song>();
            foreach(Song song in song_list)
            {
                aux.Add(song);
            }
            foreach (Song s in aux)
            {
                if (s.id == song_id)
                {
                    song_list.Remove(s);
                    return;
                }
            }
        }
        #endregion

        #region validation
        public static bool id_exists(List<Song> song_list, int song_id)
        {
            foreach(Song s in song_list)
            {
                if(s.id == song_id)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool name_exists(List<Song> song_list, string song_name)
        {
            foreach (Song s in song_list)
            {
                if (s.name.ToLower() == song_name.ToLower())
                {
                    return true;
                }
            }
            return false;
        }

        public static bool file_name_exists(List<Song> song_list, string song_file_name)
        {
            foreach (Song s in song_list)
            {
                if (s.file_name.ToLower() == song_file_name.ToLower())
                {
                    return true;
                }
            }
            return false;
        }
        #endregion
    }
}
