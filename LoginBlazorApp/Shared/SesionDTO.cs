using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginBlazorApp.Shared
{
    public class SesionDTO
    {
        // clase devolver la informacion del usuario 
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Rol { get; set; }

    }
}
