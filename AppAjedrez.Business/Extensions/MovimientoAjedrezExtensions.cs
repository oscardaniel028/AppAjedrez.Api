using AppAjedrez.Business.Models;
using AppAjedrez.Data.Entities;

namespace AppAjedrez.Business.Extensions
{
    public static class MovimientoAjedrezExtensions
    {
        public static MovimientoAjedrezModel Map(MovimientoAjedrez movimientoAjedrez)
        {
            var model =  new MovimientoAjedrezModel();

            model.CoordenadaFinal = movimientoAjedrez.CoordenadaFinal;
            return model;
        }
    }
}
