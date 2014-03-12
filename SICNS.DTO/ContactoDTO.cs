using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Reflection;

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
        [JsonProperty("GetContactosStrJsonResult")]
        public string LstStrJsonContactosDTO { get; set; }


        //Lista genérica de objetos, por defecto el json ya tiene la relación pair name_meber:value (key:value)
        [JsonProperty("GetContactosObjJsonResult")]
        public List<Object> LstObjJsonContactosDTO { get; set; }

        //Lista tipada
        //[JsonProperty("GetContactosObjJsonResult")]
        public List<ContactoDTO> LstTypJsonContactosDTO
        {
            get { return DeLstObjALstContactoDTO(); }
            //set { LstTypJsonContactosDTO = (List<ContactoDTO>)(Object)this.LstObjJsonContactosDTO; }
        }

        public List<ContactoDTO> DeLstObjALstContactoDTO()
        {
            List<ContactoDTO> LstTypJsonContactosDTO = new List<ContactoDTO>();
            foreach (Object tmp in this.LstObjJsonContactosDTO)
            {
                JObject Jobj = (JObject)tmp;

                ContactoDTO contactoDTO = new ContactoDTO();

                Type MyType = typeof(ContactoDTO);
                MemberInfo[] MyMemberInfoArray = MyType.GetMembers();

                //MemberInfo m = contactoDTO.ApeMaterno();

                foreach (MemberInfo Mymemberinfo in MyMemberInfoArray.Where(x => x.MemberType == MemberTypes.Property))
                {
                    switch (Mymemberinfo.Name)
                    {
                        case "ID":
                            contactoDTO.ID = int.Parse(Jobj[Mymemberinfo.Name].ToString()); break;
                        case "Nombres":
                            contactoDTO.Nombres = Jobj[Mymemberinfo.Name].ToString(); break;
                        case "ApePaterno":
                            contactoDTO.ApePaterno = Jobj[Mymemberinfo.Name].ToString(); break;
                        case "ApeMaterno":
                            contactoDTO.ApeMaterno = Jobj[Mymemberinfo.Name].ToString(); break;
                        case "Correo":
                            contactoDTO.Correo = Jobj[Mymemberinfo.Name].ToString(); break;
                    }
                }

                LstTypJsonContactosDTO.Add(contactoDTO);
            }
            return LstTypJsonContactosDTO;
        }
    }


}