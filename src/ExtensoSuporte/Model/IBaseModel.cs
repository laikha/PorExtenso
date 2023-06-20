using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensoSuporte
{
    /// <summary>
    /// Interface for base model
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// @author laikha
    public interface IBaseModel<out T>
    {
        string ToJson();
        T FromJson(String jsonString);
    }
}
