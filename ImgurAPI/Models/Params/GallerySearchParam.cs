using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgurAPI.Models.Params
{
    public class GallerySearchParam
    {
        public string Sort { get; set; }
        public string Window { get; set; }
        public int Page { get; set; }
        public string Query { get; set; }

        public GallerySearchParam(string sort, string window, int page, string query)
        {
            this.Sort = sort;
            this.Window = window;
            this.Page = page;
            this.Query = query;
        }
    }
}