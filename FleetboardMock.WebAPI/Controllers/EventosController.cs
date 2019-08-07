using FleetboardMock.Domain.Evento;
using FleetboardMock.WebAPI.Hubs;
using FleetboardMock.WebAPI.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace FleetboardMock.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventosController : ControllerBase
    {
        private readonly IHubContext<EventoHub, IEventoRealtime> eventoHubContext;

        public EventosController(IHubContext<EventoHub, IEventoRealtime> eventoHubContext)
        {
            this.eventoHubContext = eventoHubContext;
        }

        [HttpPost("iniciarViagem/{connectionID}")]
        public IActionResult IniciarViagem(string connectionID, IniciarViagemDto iniciarViagemDto)
        {
            eventoHubContext.Clients.Client(connectionID).IniciarViagem(iniciarViagemDto);

            return Ok();
        }

        [HttpPost("finalizarViagem/{connectionID}")]
        public IActionResult FinalizarViagem(string connectionID, FinalizarViagemDto finalizarViagemDto)
        {
            eventoHubContext.Clients.Client(connectionID).FinalizarViagem(finalizarViagemDto);

            return Ok();
        }

        [HttpPost("iniciarEspera/{connectionID}")]
        public IActionResult IniciarEspera(string connectionID, IniciarEsperaDto iniciarEsperaDto)
        {
            eventoHubContext.Clients.Client(connectionID).IniciarEspera(iniciarEsperaDto);

            return Ok();
        }
    }
}