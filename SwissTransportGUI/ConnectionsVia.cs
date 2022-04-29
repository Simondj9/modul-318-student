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
    public class ConnectionsVia
    {
[JsonProperty("connections")]
public List<Connection> ConnectionViaList { get; set; }


    }
}
