﻿using HttpUtils;
using ImgurAPI.Models;
using System.Threading.Tasks;

namespace ImgurAPI.Accounts
{
    public class Account
    {
        private readonly IHttpRequest _request;

        public Account(IHttpRequest request)
        { this._request = request; }

        public async Task<AccountSettingModel> GetAccountSettings()
        {
            return await this._request.GetAsync<AccountSettingModel>($"account/me/settings");
        }

        public async Task<AccountImagesModel> GetAccountImages()
        {
            return await this._request.GetAsync<AccountImagesModel>($"account/me/images");
        }

        public async Task<AlbumsModel> GetAlbums(string username, string page)
        {
            return await this._request.GetAsync<AlbumsModel>($"account/{username}/albums/{page}");
        }

        public async Task<AlbumIDsResponse> GetIDs(string username, string page)
        {
            return await this._request.GetAsync<AlbumIDsResponse>($"account/{username}/albums/{page}");
        }
    }
}