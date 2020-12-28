using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Tehno.WebSite.Models
{
    public class Torro
    {
            public string id { get; set; }
            public string naziv { get; set; }
            [JsonPropertyName("Img")]
            public string img { get; set; }
            public string materijal { get; set; }
            public string din { get; set; }
            public string opis { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Torro>(this);
    }
}
