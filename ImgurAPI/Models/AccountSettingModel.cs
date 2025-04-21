using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgurAPI.Models
{
    public class AccountSettingModel
    {
        public Data data { get; set; }
        public bool success { get; set; }
        public int status { get; set; }

        public class Data
        {
            public string account_url { get; set; }
            public string email { get; set; }
            public object avatar { get; set; }
            public object cover { get; set; }
            public bool public_images { get; set; }
            public string album_privacy { get; set; }
            public bool pro_expiration { get; set; }
            public bool accepted_gallery_terms { get; set; }
            public object[] active_emails { get; set; }
            public bool messaging_enabled { get; set; }
            public bool comment_replies { get; set; }
            public object[] blocked_users { get; set; }
            public bool show_mature { get; set; }
            public bool newsletter_subscribed { get; set; }
            public bool first_party { get; set; }
        }
    }
}