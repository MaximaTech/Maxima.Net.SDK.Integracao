using System;

namespace Maxima.Net.SDK.Integracao.Utils.Atributos
{
    internal class PropriedadePKAttribute : Attribute
    {
        public int Index { get; set; }

        public PropriedadePKAttribute(int index = 0)
        {
            Index = index;
        }
    }
}
