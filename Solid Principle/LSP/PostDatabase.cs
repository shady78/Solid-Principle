using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principle.LSP
{
    public class PostDatabase
    {
        public string Add(string post)
        {
            return "Original Post: " + post;
        }
        public string AddTagPost(string post)
        {
            return "Tag Post: " + post;
        }
        public string AddMentionPost(string post)
        {
            return "Mention Post: " + post;
        }
    }
}
