using FleetboardMock.Domain.ModoSombra;
using FleetboardMock.WebAPI.Interfaces;
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace FleetboardMock.WebAPI.Hubs
{
    public class ModoSombraHub : Hub<IModoSombraRealtime>, IModoSombraRealtime
    {
        public const string ROUTE = "/hubs/modoSombra";

        public async Task Ativar(ModoSombraDto dto)
        {
            await Clients.Caller.Ativar(dto);
        }

        public async Task Desativar(ModoSombraDto dto)
        {
            await Clients.Caller.Desativar(dto);
        }
    }
}
