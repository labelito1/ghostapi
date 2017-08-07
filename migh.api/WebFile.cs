using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace migh.api
{
    public class WebFile
    {
        public string Name { get; set; }
        public string URL { get; set; }
        public bool FTP { get; set; }
        public bool Default { get; set; }
        public NetworkCredential Credentials = new NetworkCredential();

        public override string ToString()
        {
            return Name;
        }
    }
}
