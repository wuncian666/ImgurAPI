using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgurAPI.Models
{
    internal class AlbumImageVotesModel
    {
        public Data data { get; set; }
        public bool success { get; set; }
        public int status { get; set; }

        public class Data
        {
            public int ups { get; set; }
            public int downs { get; set; }
        }
    }
}