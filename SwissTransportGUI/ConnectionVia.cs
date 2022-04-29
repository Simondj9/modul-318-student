using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwissTransport.Core;
using SwissTransport.Models;
using Newtonsoft.Json;

namespace SwissTransportGUI
{
    public class ConnectionVia
    {
        [JsonProperty("from")]
        public ConnectionPoint From { get; set; }



        [JsonProperty("to")]
        public ConnectionPoint To { get; set; }



        [JsonProperty("duration")]
        public string Duration { get; set; }

    }
}
