using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgurAPI.Models.Params
{
    public class AlbumCreationParam
    {
        public string[] Ids { get; set; }

        public string[] DeleteHashes { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Cover { get; set; }

        public AlbumCreationParam(string[] Ids)
        {
            this.Ids = Ids;
        }
    }
}