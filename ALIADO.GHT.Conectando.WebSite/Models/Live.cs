using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;


namespace ALIADO.GHT.Conectando.WebSite.Models
{
    public class Live
    {
        public string Id { get; set; }
        public string Maker { get; set; }
        [Required]
        public string Src { get; set; }
        public string Title { get; set; }

        [JsonPropertyName("img")]
        public string PosterImg { get; set; }
        public string Description { get; set; }
        public string Upload { get; set; }
       
        public override string ToString() =>
            JsonSerializer.Serialize<Live>(this);
        
        
    }
}
