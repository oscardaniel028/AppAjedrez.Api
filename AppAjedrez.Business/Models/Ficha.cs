using AppAjedrez.Infraestructure.Enums;

namespace AppAjedrez.Business.Models
{
    public abstract class Ficha
    {
        public abstract ETypeShape Tipo { get; }

        public abstract bool ValidarMovimiento(Coordenada coordenadaInicial, Coordenada coordenadaFinal, ref List<Coordenada> coordenadasValidas);
    }
}