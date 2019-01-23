using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShellExplained.Model
{
    public class Recipe
    {
        [JsonProperty("recipe_id")]
        public string Id { get; set; }

        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }


    }
}
