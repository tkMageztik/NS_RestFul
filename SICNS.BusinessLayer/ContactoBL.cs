using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SICNS.DataLayer;
using SICNS.DTO;

namespace SICNS.BusinessLayer
{
    public class ContactoBL
    {
        public List<ContactoDTO> ListarContacto()
        {
            return new ContactoDA().ListarContacto();
        }
    }
}
