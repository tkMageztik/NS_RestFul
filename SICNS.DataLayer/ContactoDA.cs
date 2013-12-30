using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SICNS.EntityLayer;
using System.Data;
using SICNS.DTO;

namespace SICNS.DataLayer
{

    public class ContactoDA
    {

        public List<ContactoDTO> ListarContacto()
        {
            try
            {
                using (SICDBWEBNSEntities contexto = new SICDBWEBNSEntities())
                {
                    return (from x in contexto.SICNS_T_CONTACTO
                            select new ContactoDTO()
                            {
                                ID = x.contac_c_iid,
                                Nombres = x.contac_c_vnombres,
                                ApeMaterno = x.contac_c_vape_mater,
                                ApePaterno = x.contac_c_vape_pater,
                                Correo = x.contac_c_vcorreo

                            }).ToList<ContactoDTO>();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }


    }
}
