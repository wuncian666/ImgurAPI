namespace ImgurAPI.Models
{
    public class AlbumCreationModel
    {
        public int status { get; set; }
        public bool success { get; set; }
        public Data data { get; set; }

        public class Data
        {
            public string id { get; set; }
            public string deletehash { get; set; }
        }
    }
}