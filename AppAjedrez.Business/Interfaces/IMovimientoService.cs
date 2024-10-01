using AppAjedrez.Business.Models;
using AppAjedrez.Infraestructure.Enums;

namespace AppAjedrez.Business.Interfaces
{
    public interface IMovimientoService
    {
        MovimientoResponse ValidarMovimiento(ETypeShape tipoFicha, Coordenada coordenadaInicial, Coordenada coordenadaFinal);
    }
}