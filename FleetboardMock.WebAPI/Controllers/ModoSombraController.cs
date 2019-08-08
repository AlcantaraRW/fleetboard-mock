using FleetboardMock.WebAPI.Hubs;
using FleetboardMock.WebAPI.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace FleetboardMock.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModoSombraController : ControllerBase
    {
        private readonly IHubContext<ModoSombraHub, IModoSombraRealtime> modoSombraHubContext;

        public ModoSombraController(IHubContext<ModoSombraHub, IModoSombraRealtime> modoSombraHubContext)
        {
            this.modoSombraHubContext = modoSombraHubContext;
        }

        [HttpPost("ativar/{connectionID}")]
        public IActionResult AtivarModoSombra(string connectionID)
        {
            modoSombraHubContext.Clients.Client(connectionID).Ativar();

            return Ok();
        }

        [HttpPost("desativar/{connectionID}")]
        public IActionResult DesativarModoSombra(string connectionID)
        {
            modoSombraHubContext.Clients.Client(connectionID).Desativar();

            return Ok();
        }
    }
}
