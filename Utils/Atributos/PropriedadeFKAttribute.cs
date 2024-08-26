using System;

namespace Maxima.Net.SDK.Integracao.Utils.Atributos
{
    internal class PropriedadeFKAttribute : Attribute
    {
        public PropriedadeFKAttribute(string versaoAPI, string endPoint, string tabela, Type type, bool ignorarValorZero = false)
        {
            VersaoAPI = versaoAPI;
            EndPoint = endPoint;
            Tabela = tabela;
            Type = type;
            IgnorarValorZero = ignorarValorZero;
        }

        public Type Type { get; set; }

        public string VersaoAPI { get; set; }
        public string EndPoint { get; set; }
        public string Tabela { get; set; }
        public bool IgnorarValorZero { get; set; }

    }
}
