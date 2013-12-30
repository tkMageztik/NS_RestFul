using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace NS_RESTFull
{
    [DataContract]
    public class Contacto
    {
        [DataMember]
        public string ProductName { set; get; }
    }
}