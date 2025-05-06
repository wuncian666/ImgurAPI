using HttpUtils;
using ImgurAPI.Models;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ImgurAPI.Comments
{
    public class Comment
    {
        private readonly IHttpRequest _request;

        public Comment(IHttpRequest request)
        { this._request = request; }

        public async Task<VotingResponseModel> CommentVoting(
            string commendId, string vote)
        {
            return await this._request.PostAsync<VotingResponseModel>
                ($"comment/{commendId}/vote/{vote}", null, null);
        }

        public async Task<CommentCreationResponse> CommentCreation(
            string imageId, string comment, string parentId = null)
        {
            var content = new MultipartFormDataContent
            {
                { new StringContent(imageId, Encoding.UTF8), "image_id" },
                { new StringContent(comment, Encoding.UTF8), "comment" }
            };
            if (parentId != null)
            {
                content.Add(new StringContent(parentId, Encoding.UTF8), "parent_id");
            }
            return await this._request.PostAsync<CommentCreationResponse>
                ("comment", content, null);
        }

        public async Task<CommentCreationResponse> ReplyCreation(
            string imageId, string commentId, string comment)
        {
            var content = new MultipartFormDataContent
            {
                { new StringContent(imageId, Encoding.UTF8), "image_id" },
                { new StringContent(comment, Encoding.UTF8), "comment" }
            };
            return await this._request.PostAsync<CommentCreationResponse>
                ($"comment/{commentId}", content);
        }
    }
}