using System;
using System.Collections.Generic;
using System.Text;

namespace Models.APPNOTIFICACIONES
{
    public class MensajeNotificacion : IAppNotificacion
    {
        public MensajeNotificacion()
        {
            fecha = DateTime.Now;
        }

        public string titulo { get; set; }
        public string mensaje { get; set; }
        public DateTime fecha { get; set; }
        public Boolean visto { get; set; }
    }
}
