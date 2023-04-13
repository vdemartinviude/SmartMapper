using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace mappertests.OutputModel;

internal class OutputEmployee
{
    [JsonPropertyName("name")]
    [JsonRequired]
    public string Name { get; set; }


}
