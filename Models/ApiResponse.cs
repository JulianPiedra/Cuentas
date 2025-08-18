using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ApiResponse<T>
    {
        [JsonProperty("objectResponse")]
        public T ObjectResponse { get; set; } = default!;
    }

}
