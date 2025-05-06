using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgurAPI.Models
{
    public class AlbumsModel
    {
        public Datum[] data { get; set; }
        public bool success { get; set; }
        public int status { get; set; }

        public class Datum
        {
            public string id { get; set; }
            public string title { get; set; }
            public string description { get; set; }
            public int datetime { get; set; }
            public string cover { get; set; }
            public int? cover_edited { get; set; }
            public int? cover_width { get; set; }
            public int? cover_height { get; set; }
            public string account_url { get; set; }
            public int account_id { get; set; }
            public string privacy { get; set; }
            public string layout { get; set; }
            public int views { get; set; }
            public string link { get; set; }
            public bool favorite { get; set; }
            public object nsfw { get; set; }
            public object section { get; set; }
            public int images_count { get; set; }
            public bool in_gallery { get; set; }
            public bool is_ad { get; set; }
            public bool include_album_ads { get; set; }
            public bool is_album { get; set; }
            public string deletehash { get; set; }
            public int order { get; set; }
        }
    }
}