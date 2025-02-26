using HttpUtils.Models;
using ImgurAPI.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ImgurAPI
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            ImgurContext context = new ImgurContext();
            //ImageModel result = context.Image.GetImage("nzK26wd");
            //UploadImageParam param = new UploadImageParam(@"D:\test_image.png");
            //UploadImageModel result = await context.Image.UploadImage(param);
            GallerySearchModel result = await context.Gallery.GallerySearch("time", "week", 0, "cat");
            Console.WriteLine(result.data[0].id);
            Console.ReadKey();
        }
    }
}