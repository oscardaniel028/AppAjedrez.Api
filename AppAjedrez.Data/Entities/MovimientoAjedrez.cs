﻿namespace AppAjedrez.Data.Entities
{
    public class MovimientoAjedrez
    {
        public int Id { get; set; }
        public string Ficha { get; set; }
        public string CoordenadaInicial { get; set; }
        public string CoordenadaFinal { get; set; }
        public bool EsMovimientoValido { get; set; }
    }
}
