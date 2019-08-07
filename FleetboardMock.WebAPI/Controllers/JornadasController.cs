using FleetboardMock.Domain.Jornada;
using FleetboardMock.WebAPI.Hubs;
using FleetboardMock.WebAPI.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace FleetboardMock.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JornadasController : ControllerBase
    {
        private readonly IHubContext<JornadaHub, IJornadaRealtime> jornadaHubContext;

        public JornadasController(IHubContext<JornadaHub, IJornadaRealtime> jornadaHubContext)
        {
            this.jornadaHubContext = jornadaHubContext;
        }

        [HttpPost("iniciar/{connectionID}")]
        public IActionResult Iniciar(string connectionID, IniciarJornadaDto iniciarJornadaDto)
        {
            jornadaHubContext.Clients.Client(connectionID).Iniciar(iniciarJornadaDto);

            return Ok();
        }

        [HttpPost("finalizar/{connectionID}")]
        public IActionResult Finalizar(string connectionID, FinalizarJornadaDto finalizarJornadaDto)
        {
            jornadaHubContext.Clients.Client(connectionID).Finalizar(finalizarJornadaDto);

            return Ok();
        }
    }
}