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

        [HttpPost("finalizar/{connectionID}")]
        public IActionResult Finalizar(string connectionID, FinalizarJornadaDto finalizarJornadaDto)
        {
            jornadaHubContext.Clients.Client(connectionID).Finalizar(finalizarJornadaDto);
            return Ok();
        }

        [HttpPost("iniciarViagem/{connectionID}")]
        public IActionResult IniciarViagem(string connectionID, IniciarViagemDto iniciarViagemDto)
        {
            jornadaHubContext.Clients.Client(connectionID).IniciarViagem(iniciarViagemDto);
            return Ok();
        }

        [HttpPost("finalizarViagem/{connectionID}")]
        public IActionResult FinalizarViagem(string connectionID, FinalizarViagemDto finalizarViagemDto)
        {
            jornadaHubContext.Clients.Client(connectionID).FinalizarViagem(finalizarViagemDto);
            return Ok();
        }

        [HttpPost("iniciarEspera/{connectionID}")]
        public IActionResult IniciarEspera(string connectionID, IniciarEsperaDto iniciarEsperaDto)
        {
            jornadaHubContext.Clients.Client(connectionID).IniciarEspera(iniciarEsperaDto);
            return Ok();
        }
    }
}