using FleetboardMock.Domain.Evento;
using FleetboardMock.WebAPI.Interfaces;
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace FleetboardMock.WebAPI.Hubs
{
    public class EventoHub : Hub<IEventoRealtime>, IEventoRealtime
    {
        public const string ROUTE = "/hubs/eventos";

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
