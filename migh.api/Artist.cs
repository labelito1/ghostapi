using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace migh.api
{
    public class Artist
    {
        public int id { get; set; }
        public string name { get; set; }
        public string url_name { get; set; }

        public override string ToString()
        {
            return name;
        }

        #region get
        public static Artist get(List<Artist> artist_list, int artist_id)
        {
            foreach(Artist a in artist_list)
            {
                if(a.id == artist_id)
                {
                    return a;
                }
            }
            return null;
        }
        #endregion

        #region set
        public static void set(ref List<Artist> artist_list, int artist_id, Artist new_artist)
        {
            foreach(Artist a in artist_list)
            {
                if(a.id == artist_id)
                {
                    a.name = new_artist.name;
                    return;
                }
            }
        }   
        #endregion

        #region remove
        public static void remove(ref List<Artist> artist_list, int artist_id)
        {
            List<Artist> aux = new List<Artist>();
            foreach(Artist artist in artist_list)
            {
                aux.Add(artist);
            }
            foreach (Artist a in aux)
            {
                if(a.id == artist_id)
                {
                    artist_list.Remove(a);
                    return;
                }
            }
        }
        #endregion

        #region validation
        public static bool id_exists(List<Artist> artist_list, int artist_id)
        {
            foreach(Artist a in artist_list)
            {
                if(a.id == artist_id)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool name_exists(List<Artist> artist_list, string artist_name)
        {
            foreach (Artist a in artist_list)
            {
                if (a.name.ToLower() == artist_name.ToLower())
                {
                    return true;
                }
            }
            return false;
        }

        public static bool has_children(List<Album> album_list, int artist_id)
        {
            foreach(Album a in album_list)
            {
                if(a.artist_id == artist_id)
                {
                    return true;
                }
            }
            return false;
        }
        #endregion
    }
}
