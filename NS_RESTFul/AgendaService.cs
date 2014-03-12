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

        [WebGet(UriTemplate = "ContactosStrJson", BodyStyle = WebMessageBodyStyle.Wrapped, ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        public string GetContactosStrJson()
        {
            List<ContactoDTO> contactos = new ContactoBL().ListarContacto();
            return JsonConvert.SerializeObject(contactos);
        }

        [WebInvoke(UriTemplate = "POST/ContactosStrJson", Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped,
            ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        public string PostContactosStrJson()
        {
            List<ContactoDTO> contactos = new ContactoBL().ListarContacto();
            return JsonConvert.SerializeObject(contactos);
        }


        [WebGet(UriTemplate = "ContactosObjJson", BodyStyle = WebMessageBodyStyle.Wrapped, ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        public List<ContactoDTO> GetContactosObjJson()
        {
            List<ContactoDTO> contactos = new ContactoBL().ListarContacto();
            return contactos;
        }

        [WebGet(UriTemplate = "ContactosXML", BodyStyle = WebMessageBodyStyle.Wrapped)]
        public List<ContactoDTO> GetContactosXML()
        {
            List<ContactoDTO> contactos = new ContactoBL().ListarContacto();
            return contactos;
        }

        [WebInvoke(UriTemplate = "CrearContactoJson", Method = "POST",
            BodyStyle = WebMessageBodyStyle.Wrapped,
            ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        public string Crear(ContactoDTO contacto)
        {
            return JsonConvert.SerializeObject(contacto, Formatting.Indented);
        }


        [WebInvoke(UriTemplate = "TipoCambioJson", Method = "POST",
            BodyStyle = WebMessageBodyStyle.Wrapped,
            ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        public string Crear2(ContactoDTO contacto)
        {
            //task = _taskRepository.Post(task);

            //var response = new HttpResponseMessage<Task>(task, HttpStatusCode.Created);
            //HttpResponse t = new HttpResponse();


            //string uri = Url.Route(null, new { id = task.Id });
            //response.Headers.Location = new Uri(Request.RequestUri, uri);

            //return response;

            return JsonConvert.SerializeObject(contacto, Formatting.Indented);
        }

        //[WebInvoke(UriTemplate = "NuevoContacto", Method = "POST")]
        //public ContactoDTO Create2(ContactoDTO contacto)
        //{
        //    return contacto;
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