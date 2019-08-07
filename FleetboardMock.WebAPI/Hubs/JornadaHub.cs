using FleetboardMock.Domain.Jornada;
using FleetboardMock.WebAPI.Interfaces;
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace FleetboardMock.WebAPI.Hubs
{
    public class JornadaHub : Hub<IJornadaRealtime>, IJornadaRealtime
    {
        public const string ROUTE = "/hubs/jornada";

        public async Task Iniciar(IniciarJornadaDto iniciarJornadaDto)
        {
            await Clients.Caller.Iniciar(iniciarJornadaDto);
        }

        public async Task Finalizar(FinalizarJornadaDto finalizarJornadaDto)
        {
            await Clients.Caller.Finalizar(finalizarJornadaDto);
        }
    }
}
