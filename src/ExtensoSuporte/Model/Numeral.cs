using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace ExtensoSuporte.Model
{
    /// <summary>
    /// Classe dos número a serem transformados em extenso
    /// </summary>
    /// @author laikha
    public class Numeral : BaseModel<Numeral>
    {
        /// <summary>
        /// Número a ser tranformado.  Ele não é serializado
        /// </summary>
        [NonSerialized]
        private int numero;

        private string extenso;

        private string erro;

        public int Numero { get => numero; set => numero = value; }
        public string Extenso { get => extenso; set => extenso = value; }
        public string Erro { get => erro; set => erro = value; }
    }

    
}
