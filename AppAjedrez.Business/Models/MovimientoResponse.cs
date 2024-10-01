namespace AppAjedrez.Business.Models
{
    public class MovimientoResponse
    {
        public bool EsMovimientoValido { get; set; }
        public List<Coordenada> CoordenadasValidas { get; set; }
    }
}