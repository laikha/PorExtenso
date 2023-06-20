using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace ExtensoSuporte
{
    /// <summary>
    /// Classe para IOC
    /// </summary>
    /// <typeparam name="T">Classe que terá a inversão de controle</typeparam>
    /// @author laikha
    public class Suporte<T> where T : new()
    {
        public bool TemNegativo;
        readonly List<String> Unidade = new List<String> { "Um", "Dois", "Três", "Quatro", "Cinco", "Seis", "Sete", "Oito", "Nove" };
        readonly List<String> Dezena = new List<String> { "Dez", "Vinte", "Trinta", "Quarenta", "Cinquenta", "Sessenta", "Setenta", "Oitenta", "Noventa" };
        readonly List<String> DezenaComplementar = new List<String> { "Onze", "Doze", "Treze", "Quatorze", "Quinze", "Dezesseis", "Dezesete", "Dezoito", "Dezenove" };
        readonly List<String> Centena = new List<String> { "Cem", "Duzentos", "Trezentos", "Quatroscentos", "Quinhentos", "Seiscentos", "Setecentos", "Oitocentos", "Novecentos" };
        readonly List<String> CentenaAglutinada = new List<String> {"Cento"};
        readonly List<String> Milhar = new List<String> { "Mil" };
        readonly T tipo = new T();
        
        /// <summary>
        /// Pega a classe que foi Injetada
        /// </summary>
        /// <returns>Retorna a classe injetada</returns>
        public T GetDI()
        {
            return tipo;
        }

        /// <summary>
        /// Pega a ordem desejada
        /// </summary>
        /// <param name="valorParaConverter">valor a ser tratado para extenso</param>
        /// <returns>Valor por extenso</returns>
        public string GetCardinal(int valorParaConverter)
        {
            string ret = string.Empty;

            int tamanhoParaReduzirDoValor = 1;
            TemNegativo = valorParaConverter < 0;

            if (TemNegativo)
            {
                valorParaConverter *= -1;
            }

            int quantidadeDeCaracteresDoValor = valorParaConverter.ToString().Length;
            int posicaoNalista = quantidadeDeCaracteresDoValor;

            if (quantidadeDeCaracteresDoValor > 1)
            {
                if (quantidadeDeCaracteresDoValor== 2)
                {
                    if (VerificaDecimalComplamentar(valorParaConverter))
                    {
                        ret = DezenaComplementar[(valorParaConverter % 10)-1];
                    }
                    else
                    {
                        ret = Dezena[(valorParaConverter / ConstroiDivisor(quantidadeDeCaracteresDoValor)) - 1];
                    }
                }
                else if (quantidadeDeCaracteresDoValor ==3)
                {
                    if (valorParaConverter > 100 && valorParaConverter <= 199)
                    {
                        ret = CentenaAglutinada[(valorParaConverter / ConstroiDivisor(quantidadeDeCaracteresDoValor)) - 1];
                    }
                    else
                    {
                        ret = Centena[(valorParaConverter / ConstroiDivisor(quantidadeDeCaracteresDoValor)) - 1];
                    }
                }
                else
                {
                    if (valorParaConverter >= 2000)
                    {
                        tamanhoParaReduzirDoValor = (valorParaConverter / ConstroiDivisor(quantidadeDeCaracteresDoValor)).ToString().Length;
                        ret = $"{GetCardinal(valorParaConverter / ConstroiDivisor(quantidadeDeCaracteresDoValor))} {Milhar[0]}";
                    }
                    else
                    {
                        ret = Milhar[0];
                    }

                }

                valorParaConverter = (VerificaDecimalComplamentar(valorParaConverter)?0:int.Parse(valorParaConverter.ToString().Remove(0, tamanhoParaReduzirDoValor)));

                if (quantidadeDeCaracteresDoValor > 0 && valorParaConverter !=0)
                {
                    ret += (quantidadeDeCaracteresDoValor>=4?" ":" e ") + GetCardinal(valorParaConverter);
                }
                else if(valorParaConverter != 0)
                {
                    ret = GetCardinal(valorParaConverter);
                }

            }
            else
            {
                ret = Unidade[valorParaConverter - 1];
            }
            return $"{(TemNegativo?"Menos " : "")}{ret}";
        }
        
        /// <summary>
        /// Verifica se o número passado é um decimal complementar (de 11 até 19)
        /// </summary>
        /// <param name="valor">valor a ser verificado</param>
        /// <returns>Se estiver entre 10 e 20 retorna verdadeiro</returns>
        private bool VerificaDecimalComplamentar(int valor)
        {
            return (valor > 10 && valor < 20);
        }

        /// <summary>
        /// Constroi o divisor a partir do tamanho de caracteres do valor para converter
        /// </summary>
        /// <example>
        ///  ConstroiDivisor(4)
        ///  o retorno será 1000
        /// </example>
        /// <param name="tamanhoDivisor">Cardinalidade que deverá ter o divisor</param>
        /// <returns>retorna o divisor gerado</returns>
        private int ConstroiDivisor(int tamanhoDivisor)
        {
            tamanhoDivisor = (tamanhoDivisor > 4 ? 4 : tamanhoDivisor);
            return int.Parse($"1{new String('0',tamanhoDivisor-1)}");
        }
    }
}