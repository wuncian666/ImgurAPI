using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgurAPI.Models.Params
{
    public class ImageUploadParam
    {
        public string Type { get; set; }
        public string Title { get; set; }
        public string FilePath { get; set; }
        public string Discirption { get; set; }

        public ImageUploadParam(string filePath)
        {
            this.FilePath = filePath;
            this.Type = "file";
            this.Title = "title";
            this.Discirption = "discription";
        }
    }
}