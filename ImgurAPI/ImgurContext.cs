using HttpUtils;
using ImgurAPI.Gellaries;
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

        public Images.Image Image;

        public ImgurContext()
        {
            IHttpRequest httpRequest = new HttpRequest
            {
                BaseUrl = this._baseUrl,
                Token = $"Bearer {ConfigurationManager.AppSettings["token"]}"
            };
            this.Comment = new Comments.Comment(httpRequest);
            this.Gallery = new Gallery(httpRequest);
            this.Image = new Images.Image(httpRequest);
        }
    }
}