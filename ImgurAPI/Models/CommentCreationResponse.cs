using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgurAPI.Models
{
    public class CommentCreationResponse
    {
        public Data data { get; set; }
        public bool success { get; set; }
        public int status { get; set; }

        public class Data
        {
            public long id { get; set; }
        }
    }
}