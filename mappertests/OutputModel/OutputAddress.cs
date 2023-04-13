using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace mappertests.OutputModel;

internal class OutputAddress
{
    [JsonPropertyName("address")]
    public string Address { get; set; }
    [JsonPropertyName("city")]
    public string City { get; set; }
}
