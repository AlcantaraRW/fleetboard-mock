using FleetboardMock.Domain.Evento;
using System.Threading.Tasks;

namespace FleetboardMock.WebAPI.Interfaces
{
    public interface IEventoRealtime
    {
        Task IniciarViagem(IniciarViagemDto iniciarViagemDto);

        Task FinalizarViagem(FinalizarViagemDto finalizarViagemDto);

        Task IniciarEspera(IniciarEsperaDto iniciarEsperaDto);
    }
}
