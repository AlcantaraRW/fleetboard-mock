using FleetboardMock.WebAPI.Interfaces;
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace FleetboardMock.WebAPI.Hubs
{
    public class ModoSombraHub : Hub<IModoSombraRealtime>, IModoSombraRealtime
    {
        public const string ROUTE = "/hubs/modoSombra";

        public async Task Ativar()
        {
            await Clients.Caller.Ativar();
        }

        public async Task Desativar()
        {
            await Clients.Caller.Desativar();
        }
    }
}
