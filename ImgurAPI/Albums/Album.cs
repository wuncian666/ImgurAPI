using HttpUtils;
using ImgurAPI.Models;
using ImgurAPI.Models.Params;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ImgurAPI.Album
{
    internal class Album
    {
        private IHttpRequest _request;

        public Album(IHttpRequest request)
        { this._request = request; }

        public async Task<AlbumModel> GetInfoAlbum(string albumHash)
        {
            return await this._request.GetAsync<AlbumModel>($"album/{albumHash}");
        }

        public async Task<AlbumImagesModel> GetAllOfImageInAlbum(string albumHash)
        {
            return await this._request.GetAsync<AlbumImagesModel>($"album/{albumHash}/images");
        }

        public async Task<AlbumCreationModel> CreateNewAlbum(AlbumCreationParam param)
        {
            var content = new MultipartFormDataContent();
            foreach (var id in param.Ids)
            {
                content.Add(new StringContent(id, Encoding.UTF8), "ids[]");
            }
            foreach (var deleteHash in param.DeleteHashes)
            {
                content.Add(new StringContent(deleteHash, Encoding.UTF8), "deletehashes[]");
            }
            content.Add(new StringContent(param.Title, Encoding.UTF8), "title");
            content.Add(new StringContent(param.Description, Encoding.UTF8), "description");
            content.Add(new StringContent(param.Cover, Encoding.UTF8), "cover");
            return await this._request.PostAsync<AlbumCreationModel>("album", content, null);
        }

        public async Task<AlbumImageVotesModel> AlbumImageVotes(string gallerHash)
        {
            return await this._request.GetAsync<AlbumImageVotesModel>($"gallery/{gallerHash}/votes");
        }

        public async Task<AlbumImageVotesModel> AlbumImageVoting(string gallerHash, string vote)
        {
            return await this._request.PostAsync<AlbumImageVotesModel>($"gallery/{gallerHash}/vote/{vote}", null, null);
        }

        public async Task<AlbumImageCommentCreationModel> AlbumImageCommentCreation(string gallerHash, string comment)
        {
            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>
            {
                { "comment", comment }
            };
            return await this._request.PostAsync<AlbumImageCommentCreationModel>($"gallery/{gallerHash}/comment", null, keyValuePairs);
        }
    }
}