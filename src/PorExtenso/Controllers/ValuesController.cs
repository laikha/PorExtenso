using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExtensoSuporte;
using ExtensoSuporte.Model;
using Microsoft.AspNetCore.Mvc;

namespace PorExtenso.Controllers
{
    [Route("")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private const string MENSAGEM = "É necessário informar um número entre -999999 e 999999";
        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            Suporte<Numeral> suporte = new Suporte<Numeral>();
            suporte.GetDI().erro = MENSAGEM;
            return BadRequest(suporte.GetDI().ToJson());
        }

        // GET api/values/5
        [HttpGet("{numero}")]
        public IActionResult Get(int numero)
        {
            Suporte<Numeral> suporte = new Suporte<Numeral>();
            try
            {
                if (numero < -999999 || numero > 999999)
                {
                    throw new ArgumentOutOfRangeException("numero");
                }
                suporte.GetDI().numero = numero;
                suporte.GetDI().extenso = suporte.GetCardinal(suporte.GetDI().numero);
            }
            catch (ArgumentOutOfRangeException e)
            {
                suporte.GetDI().extenso = null;
                suporte.GetDI().erro = e.Message;

                return BadRequest(suporte.GetDI().ToJson());
            }
            return Ok(suporte.GetDI().ToJson());
        }

    }
}
