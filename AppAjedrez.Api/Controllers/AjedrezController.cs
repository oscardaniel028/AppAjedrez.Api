using Microsoft.AspNetCore.Mvc;
using AppAjedrez.Business.Interfaces;
using AppAjedrez.Business.Models;
using AppAjedrez.Infraestructure.Enums;

namespace AppAjedrez.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AjedrezController : ControllerBase
    {
        private readonly IMovimientoService _movimientoService;

        public AjedrezController(IMovimientoService movimientoService)
        {
            _movimientoService = movimientoService;
        }

        [HttpPost("mover")]
        public IActionResult MoverFicha(ETypeShape tipoFicha, int xInicial, int yInicial, int xFinal, int yFinal)
        {
            var coordenadaInicial = new Coordenada { X = xInicial, Y = yInicial };
            var coordenadaFinal = new Coordenada { X = xFinal, Y = yFinal };

            var resultado = _movimientoService.ValidarMovimiento(tipoFicha, coordenadaInicial, coordenadaFinal);

            if (resultado.EsMovimientoValido)
            {
                return Ok("Movimiento Válido");
            }
            else
            {
                return BadRequest(new { mensaje = "Movimiento Inválido", coordenadasValidas = resultado.CoordenadasValidas });
            }
        }
    }
}