using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace Gourmet_s_ChoiceAPI
{
    [JsonObject(MemberSerialization.OptIn)]
    [MetadataType(typeof(ImageMeta))]
    public class Image
    {
    }

    public class ImageMeta
    {
        [JsonProperty]
        public int FoodID { get; set; }
        [JsonProperty]
        public Image Image { get; set; }
        [JsonProperty]
        public Image Thumbnail { get; set; }
    }
}