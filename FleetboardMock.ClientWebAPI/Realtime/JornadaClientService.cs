using FleetboardMock.Domain.Jornada;
using Microsoft.AspNetCore.SignalR.Client;
using System.Threading.Tasks;

namespace FleetboardMock.ClientWebAPI.Realtime
{
    public class JornadaClientService
    {
        private readonly HubConnection connection;
        private bool isConnected = false;

        public JornadaClientService(string uri)
        {
            connection = new HubConnectionBuilder()
                .WithUrl(uri)
                .Build();

            connection.On<IniciarJornadaDto>("Iniciar", dto =>
            {
                System.Console.WriteLine("Iniciar jornada no aplicativo");
            });
        }

        public async Task Connect()
        {
            if (isConnected)
            {
                return;
            }

            await connection.StartAsync();
            isConnected = true;
        }
    }
}
