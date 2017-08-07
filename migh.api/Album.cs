using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace migh.api
{
    public class Album
    {
        public int id { get; set; }
        public int artist_id { get; set; }
        public string name { get; set; }
        public string url_name { get; set; }
        public string cover_url { get; set; }

        public override string ToString()
        {
            return name;
        }

        #region get
        public static Album get(List<Album> album_list, int album_id)
        {
            foreach(Album a in album_list)
            {
                if(a.id == album_id)
                {
                    return a;
                }
            }
            return null;
        }

        public static List<Album> getByArtist(List<Album> album_list, int artist_id)
        {
            List<Album> list = new List<Album>();
            foreach(Album a in album_list)
            {
                if(a.artist_id == artist_id)
                {
                    list.Add(a);
                }
            }
            return list;
        }
        #endregion

        #region set
        public static void set(ref List<Album> album_list, int album_id, Album new_album)
        {
            foreach(Album a in album_list)
            {
                if(a.id == album_id)
                {
                    a.artist_id = new_album.artist_id;
                    a.name = new_album.name;
                    a.url_name = new_album.url_name;
                    a.cover_url = new_album.cover_url;
                    return;
                }
            }
        }
        #endregion

        #region remove
        public static void remove(ref List<Album> album_list, int album_id)
        {
            List<Album> aux = new List<Album>();
            foreach(Album album in album_list)
            {
                aux.Add(album);
            }
            foreach (Album a in aux)
            {
                if (a.id == album_id)
                {
                    album_list.Remove(a);
                    return;
                }
            }
        }
        #endregion

        #region validation
        public static bool id_exists(List<Album> album_list, int album_id)
        {
            foreach(Album a in album_list)
            {
                if(a.id == album_id)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool name_exists(List<Album> album_list, string album_name)
        {
            foreach (Album a in album_list)
            {
                if (a.name.ToLower() == album_name.ToLower())
                {
                    return true;
                }
            }
            return false;   
        }

        public static bool has_children(List<Song> song_list, int album_id)
        {
            foreach (Song s in song_list)
            {
                if (s.album_id == album_id)
                {
                    return true;
                }
            }
            return false;
        }
        #endregion
    }
}
