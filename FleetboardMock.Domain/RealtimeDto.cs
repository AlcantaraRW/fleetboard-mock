using System;

namespace FleetboardMock.Domain
{
    public class RealtimeDto
    {
        public string FleetID { get; set; }

        public string FleetIDMotorista { get; set; }

        public long VeiculoID { get; set; }

        public DateTime DataInicioFleetBoard { get; set; }

        public DateTime? DataFimFleetBoard { get; set; }

        public DateTime Data { get; set; }

        public string Localidade { get; set; }

        public decimal Latitude { get; set; }

        public decimal Longitude { get; set; }
    }
}
