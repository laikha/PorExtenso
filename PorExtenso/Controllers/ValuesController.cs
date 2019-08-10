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
        // GET api/values
        [HttpGet]
        public ActionResult<String> Get()
        {
            Suporte<Numeral> suporte = new Suporte<Numeral>();
            suporte.GetDI().erro = "é necessário informar um número entre -99999 e 99999";
            return suporte.GetDI().ToJson();
        }

        // GET api/values/5
        [HttpGet("{numero}")]
        public ActionResult<String> Get(int numero)
        {
            Suporte<Numeral> suporte = new Suporte<Numeral>();
            try
            {
                if (numero < -99999 || numero > 99999)
                {
                    throw new ArgumentOutOfRangeException("O valor informado para deve estar entre -99999 e 99999");
                }
                suporte.GetDI().numero = numero;
                suporte.GetDI().extenso = suporte.GetCardinal(suporte.GetDI().numero);
            }
            catch (ArgumentOutOfRangeException e)
            {
                suporte.GetDI().extenso = null;
                suporte.GetDI().erro = e.Message;
            }
            return suporte.GetDI().ToJson();
        }

    }
}
