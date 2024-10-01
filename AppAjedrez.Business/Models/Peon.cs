using AppAjedrez.Infraestructure.Enums;

namespace AppAjedrez.Business.Models
{
    public class Peon : Ficha
    {
        public override ETypeShape Tipo => ETypeShape.Peon;

        public override bool ValidarMovimiento(Coordenada coordenadaInicial, Coordenada coordenadaFinal, ref List<Coordenada> coordenadasValidas)
        {
            if (coordenadaFinal.X == coordenadaInicial.X && (coordenadaFinal.Y == coordenadaInicial.Y + 1))
            {
                return true;
            }
            else
            {
                coordenadasValidas.Add(new Coordenada { X = coordenadaInicial.X, Y = coordenadaInicial.Y + 1 });
                return false;
            }
        }
    }
}