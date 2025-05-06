using HttpUtils;
using ImgurAPI.Models;
using ImgurAPI.Models.Params;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ImgurAPI.Gellaries
{
    public class Gallery
    {
        private readonly IHttpRequest _request;

        public Gallery(IHttpRequest request)
        { this._request = request; }

        public async Task<GallerySearchModel> GallerySearch(GallerySearchParam param)
        {
            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>
            {
                { "q", param.Query }
            };
            return await this._request.GetAsync<GallerySearchModel>(
                $"gallery/search/{param.Sort}/{param.Window}/{param.Page}", keyValuePairs);
        }

        public async Task<GalleryAlbumModel> GalleryAlbum(string galleryHash)
        {
            return await this._request.GetAsync<GalleryAlbumModel>($"gallery/album/{galleryHash}");
        }

        public async Task<string> GalleryImage(string galleryImageHash)
        {
            return await this._request.GetAsync($"gallery/image/{galleryImageHash}");
        }

        public async Task<AlbumImageVotesModel> AlbumImageVotes(string gallerHash)
        {
            return await this._request.GetAsync<AlbumImageVotesModel>
                ($"gallery/{gallerHash}/votes");
        }

        public async Task<VotingResponseModel> AlbumImageVoting(string gallerHash, string vote)
        {
            return await this._request.PostAsync<VotingResponseModel>
                ($"gallery/{gallerHash}/vote/{vote}", null, null);
        }

        public async Task<CommentsModel> GetComments(string id)
        {
            return await this._request.GetAsync<CommentsModel>
                ($"gallery/{id}/comments/best");
        }
    }
}