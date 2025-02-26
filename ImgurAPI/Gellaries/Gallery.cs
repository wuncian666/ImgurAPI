using HttpUtils;
using HttpUtils.Models;
using ImgurAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgurAPI.Gellaries
{
    internal class Gallery
    {
        private IHttpRequest _request;

        public Gallery(IHttpRequest request)
        { this._request = request; }

        public async Task<GallerySearchModel> GallerySearch(string sort, string window, int page, string target)
        {
            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();
            keyValuePairs.Add("q", target);
            return await this._request.GetAsync<GallerySearchModel>($"gallery/search/{sort}/{window}/{page}", keyValuePairs);
        }

        public async Task<GalleryAlbumModel> GalleryAlbum(string galleryHash)
        {
            return await this._request.GetAsync<GalleryAlbumModel>($"gallery/album/{galleryHash}");
        }

        public async Task<string> GalleryImage(string galleryImageHash)
        {
            return await this._request.GetAsync($"gallery/image/{galleryImageHash}");
        }
    }
}