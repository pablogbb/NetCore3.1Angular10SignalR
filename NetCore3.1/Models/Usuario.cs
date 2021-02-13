using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Usuario
    {
        public Int64? usr_codigo { get; set; }
        public String usr_id { get; set; }
        public String usr_nombre { get; set; }
        public String usr_apellido { get; set; }
        public String usr_telefono { get; set; }
        public String usr_clave { get; set; }
        public int? usr_permiso { get; set; }
        public String usr_mail { get; set; }
        public int? usr_estado { get; set; }
        public String usr_cedula_ruc { get; set; }
        public int? usr_marca { get; set; }
    }
}
