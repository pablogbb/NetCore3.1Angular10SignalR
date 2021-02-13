using Microsoft.AspNetCore.SignalR;
using Models;
using Models.APPNOTIFICACIONES;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CURBE_PQR.Hubs
{
    public class AppNotificacionService
    {
        private IHubContext<AppNotificacionHub> _messagehubcontext;
        private readonly IUserConnectionManager _userConnectionManager;
        public AppNotificacionService(IHubContext<AppNotificacionHub> messagehubcontext, IUserConnectionManager userConnectionManager)
        {
            _messagehubcontext = messagehubcontext;
            _userConnectionManager = userConnectionManager;
        }

        public async Task enviarNotificacionAsync(List<Usuario> usuarios,IAppNotificacion appNotificacion)
        {
            if(appNotificacion.GetType() == typeof(MensajeNotificacion))
            {
                foreach (var u in usuarios)
                {
                    await buscarConeccionesYEnviarAsync(u.usr_codigo.ToString(), appNotificacion,"send");
                }
            }
            else if(appNotificacion.GetType() == typeof(DataNotificacion))
            {
                foreach (var u in usuarios)
                {
                    await buscarConeccionesYEnviarAsync(u.usr_codigo.ToString(), appNotificacion, "event");
                }
            }
        }

        private async Task buscarConeccionesYEnviarAsync(string usuario, Object data, string function)
        {
            //await _messagehubcontext.Clients.All.SendAsync("send", data);
            var connections = _userConnectionManager.GetUserConnections(usuario);

            if (connections != null && connections.Count > 0)
            {
                foreach (var connectionId in connections)
                {
                    await _messagehubcontext.Clients.Client(connectionId).SendAsync(function, data);
                    
                }
            }
        }
    }
}
