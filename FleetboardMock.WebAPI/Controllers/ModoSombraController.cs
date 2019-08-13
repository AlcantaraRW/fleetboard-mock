using FleetboardMock.Domain.ModoSombra;
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
        public IActionResult AtivarModoSombra(string connectionID, ModoSombraDto dto)
        {
            modoSombraHubContext.Clients.Client(connectionID).Ativar(dto);

            return Ok();
        }

        [HttpPost("desativar/{connectionID}")]
        public IActionResult DesativarModoSombra(string connectionID, ModoSombraDto dto)
        {
            modoSombraHubContext.Clients.Client(connectionID).Desativar(dto);

            return Ok();
        }
    }
}
