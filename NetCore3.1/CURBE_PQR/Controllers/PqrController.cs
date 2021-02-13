using BLL;
using CURBE_PQR.Hubs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Models;
using Models.APPNOTIFICACIONES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CURBE_PQR.Controllers
{
    [Route("api/pqr")]
    [ApiController]
    public class PqrController : ControllerBase
    {
        private PqrService pqrService;
        private readonly IConfiguration configuration;
        private AppNotificacionService appNotificacionService;
        public PqrController(IConfiguration _configuration, PqrService _pqrService, AppNotificacionService _appNotificacionService)
        {
            pqrService = _pqrService;
            configuration = _configuration;
            appNotificacionService = _appNotificacionService;
        }
        
        [HttpPost, Route("notificar")]
        public async Task<IActionResult> notificarAsync()
        {
            var u = new Usuario();
            u.usr_codigo = 10;

            var m = new MensajeNotificacion();
            m.mensaje = "Tienes un nuevo PQR: PQT-ABC123";
            await appNotificacionService.enviarNotificacionAsync(new List<Usuario> { u },m);
            return Ok();
        }
    }
}
