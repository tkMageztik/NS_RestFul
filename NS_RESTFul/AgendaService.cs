using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel.Web;
using System.ServiceModel;
using System.ServiceModel.Activation;
using SICNS.BusinessLayer;
using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.IO;
using SICNS.DTO;
using Newtonsoft.Json.Linq;

namespace NS_RESTFull
{
    [ServiceContract]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class AgendaService
    {
        // TODO: Implement the collection resource that will contain the SampleItem instances

        [WebGet(UriTemplate = "Contactos", BodyStyle = WebMessageBodyStyle.Wrapped, ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        public string GetContactos()
        {
            // TODO: Replace the current implementation to return a collection of SampleItem instances

            List<ContactoDTO> contactos = new ContactoBL().ListarContacto();

            //return JsonConvert.SerializeObject(contacto);
            //return JsonConvert.SerializeObject(t);
            return JsonConvert.SerializeObject(contactos, Formatting.Indented);


            //return JsonConvert.SerializeObject(objReportBO);

            //JsonSerializer.Create(new JsonSerializerSettings() { ContractResolver= new Contacto() });
            //return JsonConvert.SerializeObject(t, new JsonSerializerSettings() { ContractResolver = new Contacto() });

            //return JsonConvert.SerializeObject(objReportBO);

            //return contacto;
        }


        //[WebInvoke(UriTemplate = "", Method = "POST")]
        //public SampleItem Create(SampleItem instance)
        //{
        //     TODO: Add the new instance of SampleItem to the collection
        //    throw new NotImplementedException();
        //}

        //[WebGet(UriTemplate = "{id}")]
        //public SampleItem Get(string id)
        //{
        //     TODO: Return the instance of SampleItem with the given id
        //    throw new NotImplementedException();
        //}

        //[WebInvoke(UriTemplate = "{id}", Method = "PUT")]
        //public SampleItem Update(string id, SampleItem instance)
        //{
        //     TODO: Update the given instance of SampleItem in the collection
        //    throw new NotImplementedException();
        //}

        //[WebInvoke(UriTemplate = "{id}", Method = "DELETE")]
        //public void Delete(string id)
        //{
        //     TODO: Remove the instance of SampleItem with the given id from the collection
        //    throw new NotImplementedException();
        //}

    }
}