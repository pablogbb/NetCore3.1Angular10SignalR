using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{

    public class Pqr
    {
        public Int32 pqr_codigo { get; set; }
        public String pqr_id { get; set; }
        public String pqr_asunto { get; set; }
        public String pqr_descripcion { get; set; }
        public Int32 pqr_categoria { get; set; }
        public Int32? pqr_estado { get; set; } = 1;
        public Int32? pqr_cliente { get; set; }
        public Int32? pqr_marca { get; set; }
        public Int32? pqr_etapa { get; set; }
        public DateTime? pqr_fecha_creacion { get; set; }
        public DateTime? pqr_fecha_estado { get; set; }
        public DateTime? pqr_fecha_asg_marca { get; set; }
        public DateTime? pqr_fecha_asg_empresa { get; set; }
        public String pqr_pdf { get; set; }
        public String pqr_observaciones { get; set; }
        public Int32? pqr_solucionado { get; set; }
        public DateTime? pqr_fecha_solucionado { get; set; }
        public Int32? pqr_modelo { get; set; }
        public Int32? pqr_prioridad { get; set; }
        public Int32? pqr_nivel { get; set; }
        public int? pqr_canal { get; set; }
        public String pqr_ciudad { get; set; }
        public Int32? pqr_origen { get; set; }
        public int? pqr_plataforma { get; set; }
        public int? pqr_area { get; set; }
        public int? pqr_tipo_caso { get; set; }
        public int? pqr_empresa { get; set; }
        public int? pqr_almacen { get; set; }
       
    }

    public class Pqr_join : Pqr
    {
        // Asignacion
        public int? pqus_codigo { get; set; }
        public int? pqus_usuario { get; set; }
        public string pqus_pqr { get; set; }
        public int? pqus_propietario { get; set; }
        public DateTime? pqus_fecha_asignado { get; set; }
        // Cliente
        public String cli_ruc_cedula { get; set; }
        public String cli_nombre { get; set; }
        public String cli_apellido { get; set; }
        public String cli_direccion { get; set; }
        public String cli_telefono1 { get; set; }
        public String cli_telefono2 { get; set; }
        public String cli_mail { get; set; }
        // Categoria
        public String pcat_descripcion { get; set; }
        public String pcat_color { get; set; }
        public String pcan_descripcion { get; set; }
        public String pcan_icono { get; set; }
        public List<Usuario> usuarios { get; set; }
        // Modelos
        public int mod_codigo { get; set; }
        public string mod_nombre { get; set; }
        public int mod_cat_vehiculo { get; set; }
        public Pqr_join()
        {
            usuarios = new List<Usuario>();
        }
    }

    public class Pqr_asignar
    {
        public List<Pqr> pqrs { get; set; }
        public List<Usuario> usuarios { get; set; }
        public Pqr_asignar()
        {
            pqrs = new List<Pqr>();
            usuarios = new List<Usuario>();
        }
    }

}
