using AppAjedrez.Business.Interfaces;
using AppAjedrez.Business.Models;
using AppAjedrez.Infraestructure.Enums;
using System;
using System.Collections.Generic;

namespace AppAjedrez.Business.Services
{
    public class MovimientoService : IMovimientoService
    {
        public MovimientoResponse ValidarMovimiento(ETypeShape tipoFicha, Coordenada coordenadaInicial, Coordenada coordenadaFinal)
        {
            List<Coordenada> coordenadasValidas = new List<Coordenada>();
            Ficha ficha = CrearFicha(tipoFicha);

            if (ficha == null)
            {
                throw new ArgumentException("Tipo de ficha no válido.");
            }

            bool esMovimientoValido = ficha.ValidarMovimiento(coordenadaInicial, coordenadaFinal, ref coordenadasValidas);

            return new MovimientoResponse
            {
                EsMovimientoValido = esMovimientoValido,
                CoordenadasValidas = esMovimientoValido ? null : coordenadasValidas
            };
        }

        private Ficha CrearFicha(ETypeShape tipoFicha)
        {
            switch (tipoFicha)
            {
                case ETypeShape.Peon:
                    return new Peon();
                case ETypeShape.Alfil:
                    return new Alfil();
                default:
                    return null;
            }
        }
    }
}