using HttpUtils;
using ImgurAPI.Accounts;
using ImgurAPI.Albums;
using ImgurAPI.Gellaries;
using ImgurAPI.Images;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgurAPI
{
    public class ImgurContext
    {
        private string _baseUrl = "https://api.imgur.com/3";

        public Comments.Comment Comment;

        public Gallery Gallery;

        public Image Image;

        public Album Album;

        public Account Account;

        public ImgurContext()
        {
            IHttpRequest httpRequest = new HttpRequest
            {
                BaseUrl = this._baseUrl,
                Token = $"Bearer {ConfigurationManager.AppSettings["token"]}"
            };
            this.Comment = new Comments.Comment(httpRequest);
            this.Gallery = new Gallery(httpRequest);
            this.Image = new Image(httpRequest);
            this.Album = new Album(httpRequest);
            this.Account = new Account(httpRequest);
        }
    }
}