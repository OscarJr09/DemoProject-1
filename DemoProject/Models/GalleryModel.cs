using Java.Lang;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace DemoProject.Models
{

    public class GalleryModel
    {
        public Data Data { get; set; }
    }

    public class Data
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public object Description { get; set; }
        public int Datetime { get; set; }
        public string Cover { get; set; }
        public string Account_url { get; set; }
        public int Account_id { get; set; }
        public string Privacy { get; set; }
        public string Layout { get; set; }
        public int Views { get; set; }
        public string Link { get; set; }
        public int Ups { get; set; }
        public int Downs { get; set; }
        public int Points { get; set; }
        public int Score { get; set; }
        public bool Is_album { get; set; }
        public object Vote { get; set; }
        public int Comment_count { get; set; }
        public int Images_count { get; set; }
        public Image[] Images { get; set; }
    }

    public class Image
    {
        public string Id { get; set; }
        public object Title { get; set; }
        public object Description { get; set; }
        public int Datetime { get; set; }
        public string Type { get; set; }
        public bool Animated { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Size { get; set; }
        public int Views { get; set; }
        public long Bandwidth { get; set; }
        public string Link { get; set; }
    }
}
