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
        public int numero;

        public string extenso;

        public string erro;
       
    }

    
}
