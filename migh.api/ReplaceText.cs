using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace migh.api
{
    public class ReplaceText
    {
        public string OriginalText { get; set; }
        public string NewText { get; set; }

        public override string ToString()
        {
            return "'" + OriginalText + "' --> '" + NewText + "'";
        }
    }
}
