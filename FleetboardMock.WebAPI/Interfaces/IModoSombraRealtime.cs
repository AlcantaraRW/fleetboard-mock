using FleetboardMock.Domain.ModoSombra;
using System.Threading.Tasks;

namespace FleetboardMock.WebAPI.Interfaces
{
    public interface IModoSombraRealtime
    {
        Task Ativar(ModoSombraDto dto);

        Task Desativar(ModoSombraDto dto);
    }
}
