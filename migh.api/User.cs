using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace migh.api
{
    public class User
    {
        public string name { get; set; }
        public string password { get; set; }
        public string message { get; set; }
        public bool premium { get; set; }
        public List<int> artist_list = new List<int>();

        public override string ToString()
        {
            return name;
        }

        #region get
        public static User get(List<User> user_list, string name)
        {
            foreach(User u in user_list)
            {
                if(u.name.ToLower() == name.ToLower())
                {
                    return u;
                }
            }
            return null;
        }
        #endregion

        #region set
        public static void set(ref List<User> user_list, string name, User new_user)
        {
            foreach(User u in user_list)
            {
                if(u.name.ToLower() == name.ToLower())
                {
                    u.name = new_user.name;
                    u.password = new_user.password;
                    u.message = new_user.message;
                    u.premium = new_user.premium;
                    u.artist_list = new_user.artist_list;
                }
            }
        }
        #endregion

        #region remove
        public static void remove(ref List<User> user_list, string name)
        {
            List<User> aux = new List<User>();
            foreach(User user in user_list)
            {
                aux.Add(user);
            }
            foreach (User u in aux)
            {
                if(u.name.ToLower() == name.ToLower())
                {
                    user_list.Remove(u);
                }
            }
        }
        #endregion

        #region validation
        public static bool name_exists(List<User> user_list, string name)
        {
            foreach(User u in user_list)
            {
                if(u.name.ToLower() == name.ToLower())
                {
                    return true;
                }
            }
            return false;
        }
        #endregion
    }
}
