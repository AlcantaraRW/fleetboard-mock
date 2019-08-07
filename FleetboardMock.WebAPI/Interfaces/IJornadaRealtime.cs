using FleetboardMock.Domain.Jornada;
using System.Threading.Tasks;

namespace FleetboardMock.WebAPI.Interfaces
{
    public interface IJornadaRealtime
    {
        Task Finalizar(FinalizarJornadaDto finalizarJornadaDto);

        Task IniciarViagem(IniciarViagemDto iniciarViagemDto);

        Task FinalizarViagem(FinalizarViagemDto finalizarViagemDto);

        Task IniciarEspera(IniciarEsperaDto iniciarEsperaDto);
    }
}
