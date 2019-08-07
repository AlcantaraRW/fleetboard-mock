using FleetboardMock.Domain.Jornada;
using System.Threading.Tasks;

namespace FleetboardMock.WebAPI.Interfaces
{
    public interface IJornadaRealtime
    {
        Task Iniciar(IniciarJornadaDto iniciarJornadaDto);

        Task Finalizar(FinalizarJornadaDto finalizarJornadaDto);
    }
}
