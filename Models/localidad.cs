using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sitio_Web_VR222731.Models
{
    public class localidad
    {
        public List<SelectListItem> Localidades { get; set; }
        public int nIdMunicipio;
        public string sNombreMunicipio;
        public int nIdPais;
    }
}
