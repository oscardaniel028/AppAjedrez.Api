using AppAjedrez.Infraestructure.Enums;

namespace AppAjedrez.Business.Models
{
    public class Alfil : Ficha
    {
        public override ETypeShape Tipo => ETypeShape.Alfil;

        public override bool ValidarMovimiento(Coordenada coordenadaInicial, Coordenada coordenadaFinal, ref List<Coordenada> coordenadasValidas)
        {
            if (Math.Abs(coordenadaFinal.X - coordenadaInicial.X) == Math.Abs(coordenadaFinal.Y - coordenadaInicial.Y))
            {
                return true;
            }
            else
            {
                for (int i = 1; i < 8; i++)
                {
                    coordenadasValidas.Add(new Coordenada { X = coordenadaInicial.X + i, Y = coordenadaInicial.Y + i });
                    coordenadasValidas.Add(new Coordenada { X = coordenadaInicial.X - i, Y = coordenadaInicial.Y - i });
                    coordenadasValidas.Add(new Coordenada { X = coordenadaInicial.X + i, Y = coordenadaInicial.Y - i });
                    coordenadasValidas.Add(new Coordenada { X = coordenadaInicial.X - i, Y = coordenadaInicial.Y + i });
                }
                return false;
            }
        }
    }
}