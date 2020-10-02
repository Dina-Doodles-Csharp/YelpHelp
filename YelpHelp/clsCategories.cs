using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YelpHelp
{
    public class clsCategories
    {
        [JsonProperty("categories")]
        public List<Category> CategoriesList { get; set; }
    }

    public class Category
    {
        [JsonProperty("alias")]
        public string Alias { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("parent_aliases")]
        public string[] ParentCategories { get; set; }
    }
}
