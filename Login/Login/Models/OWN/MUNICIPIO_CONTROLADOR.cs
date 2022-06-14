using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Login.Models.OWN
{
    public class MUNICIPIO_CONTROLADOR
    {
        public string CENTRO_MEDICO_ZOHO { get; set; }

        public MUNICIPIO_CONTROLADOR(string cod_comuna)
        {
            CENTRO_MEDICO_ZOHO = "https://analytics.zoho.com/open-view/2395394000013768977?ZOHO_CRITERIA=%22Localiza%20CL%22.%22Codcom%22%3D" + cod_comuna;
        }
    }

    public class MUNICIPIO_DB
    {

    }
}