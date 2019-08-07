using FleetboardMock.Domain.Jornada;
using FleetboardMock.WebAPI.Interfaces;
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace FleetboardMock.WebAPI.Hubs
{
    public class JornadaHub : Hub<IJornadaRealtime>, IJornadaRealtime
    {
        public const string ROUTE = "/hubs/jornada";

        public async Task Finalizar(FinalizarJornadaDto finalizarJornadaDto)
        {
            await Clients.Caller.Finalizar(finalizarJornadaDto);
        }

        public async Task IniciarViagem(IniciarViagemDto iniciarViagemDto)
        {
            await Clients.Caller.IniciarViagem(iniciarViagemDto);
        }

        public async Task FinalizarViagem(FinalizarViagemDto finalizarViagemDto)
        {
            await Clients.Caller.FinalizarViagem(finalizarViagemDto);
        }

        public async Task IniciarEspera(IniciarEsperaDto iniciarEsperaDto)
        {
            await Clients.Caller.IniciarEspera(iniciarEsperaDto);
        }
    }
}
