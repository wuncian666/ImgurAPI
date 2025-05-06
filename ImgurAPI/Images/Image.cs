using HttpUtils;
using ImgurAPI.Models;
using ImgurAPI.Models.Params;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ImgurAPI.Images
{
    public class Image
    {
        private IHttpRequest _request;

        public Image(IHttpRequest request)
        {
            this._request = request;
        }

        public ImageModel GetImage(string imagehash)
        {
            return this._request.GetAsync<ImageModel>($"image/{imagehash}").Result;
        }

        public async Task<ImageUploadModel> UploadImage(ImageUploadParam param)
        {
            var content = new MultipartFormDataContent
            {
                { new StringContent("type", Encoding.UTF8), param.Type },// default file
                { new StringContent("title", Encoding.UTF8), param.Title },// optional
                { new StringContent("description", Encoding.UTF8), param.Discirption}
            };
            Stream fileStream = File.OpenRead(param.FilePath);
            StreamContent streamContent = new StreamContent(fileStream);
            content.Add(streamContent, "image", param.FilePath);
            return await this._request.PostAsync<ImageUploadModel>("image", content, null);
        }
    }
}