using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Login.Models
{
    public class SUPER_USER
    {
        //DATASUSCRIPCIONES2-D990_AGENCIA_INFORMACION-300
        public List<string> correos { get; set; }
        public List<string> Semi { get; set; }


        public SUPER_USER()
        {
            this.correos = new List<string>
            {
                "lmonsalve22@gmail.com","viviandrg7@gmail.com","porvenir@dataintelligence-group.com"/*,"mbazan@terram.cl"*/
            };
        }
    }
}