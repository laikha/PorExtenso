using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensoSuporte.Model
{
    /// <summary>
    /// Classe base para interface de modelo
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// @author laikha
    [Serializable]
    public class BaseModel<T> : IBaseModel<T>
    {
        /// <summary>
        /// Converte da string em JSON para a classe original
        /// </summary>
        /// <param name="jsonString">string em json</param>
        /// <returns>classe convertida</returns>
        public virtual T FromJson(string jsonString)
        {
            return JsonConvert.DeserializeObject<T>(jsonString);
        }

        /// <summary>
        /// Converte a classe atual em JSon
        /// </summary>
        /// <returns>valor em JSon</returns>
        public virtual string ToJson()
        {
            string ret = JsonConvert.SerializeObject(this);
            return ret;
        }

    }}
