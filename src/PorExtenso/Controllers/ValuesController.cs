using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExtensoSuporte;
using ExtensoSuporte.Model;
using Microsoft.AspNetCore.Mvc;

namespace PorExtenso.Controllers
{
    [Route("api/values")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private const string MENSAGEM = "É necessário informar um número entre -999999 e 999999";
        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            Suporte<Numeral> suporte = new();
            suporte.GetDI().Erro = MENSAGEM;
            return BadRequest(suporte.GetDI().ToJson());
        }

        // GET api/values/5
        [HttpGet("{numero}")]
        public IActionResult Get(int numero)
        {
            Suporte<Numeral> suporte = new();
            try
            {
                if (numero < -999999 || numero > 999999)
                {
                    throw new ArgumentOutOfRangeException(nameof(numero));
                }
                suporte.GetDI().Numero = numero;
                suporte.GetDI().Extenso = suporte.GetCardinal(suporte.GetDI().Numero);
            }
            catch (ArgumentOutOfRangeException e)
            {
                suporte.GetDI().Extenso = null;
                suporte.GetDI().Erro = e.Message + MENSAGEM;

                return BadRequest(suporte.GetDI().ToJson());
            }
            return Ok(suporte.GetDI().ToJson());
        }

        public static T FromJson<T>(string json)
        {
            return (new BaseModel<T>()).FromJson(json);
        }

    }
}
