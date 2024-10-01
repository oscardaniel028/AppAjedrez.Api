

namespace AppAjedrez.Business.Models
{
    public class MovimientoRequest
    {
        public String TipoFicha { get; set; }
        public Coordenada CoordenadaInicial { get; set; }
        public Coordenada CoordenadaFinal { get; set; }
    }
}
