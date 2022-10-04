using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sitio_Web_VR222731.Models
{
    public class Categorias
    {
        public List<SelectListItem> categorias { get; set; }
        public int nIdCategoria;
        public string sNombreCategoria;
    }
}
