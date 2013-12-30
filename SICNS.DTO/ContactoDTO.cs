using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace SICNS.DTO
{
    [DataContract]
    [Serializable]
    public class ContactoDTO
    {
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public string Nombres { get; set; }

        [DataMember]
        public string ApePaterno { get; set; }

        [DataMember]
        public string ApeMaterno { get; set; }

        [DataMember]
        public string Correo { get; set; }

    }
    [JsonObject("JsonAgendaDTO")]
    public class JsonAgendaDTO
    {
        [JsonProperty("GetContactosResult")]
        public string LstContactosDTO { get; set; }
    }
}