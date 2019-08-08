using System.Threading.Tasks;

namespace FleetboardMock.WebAPI.Interfaces
{
    public interface IModoSombraRealtime
    {
        Task Ativar();

        Task Desativar();
    }
}
