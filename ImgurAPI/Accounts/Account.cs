using HttpUtils;
using ImgurAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgurAPI.Accounts
{
    public class Account
    {
        private IHttpRequest _request;

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
    }
}