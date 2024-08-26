using System;
using System.ComponentModel.DataAnnotations;

namespace Maxima.Net.SDK.Integracao.Utils.Atributos
{
    internal class ValorEntreAttribute : RangeAttribute
    {
        public ValorEntreAttribute(double minimum, double maximum) : base(minimum, maximum)
        {
            ErrorMessage = "A propriedade {0} deve ter um valor entre {1} e {2}.";
        }

        public ValorEntreAttribute(Type type, string minimum, string maximum) : base(type, minimum, maximum)
        {
            ErrorMessage = "A propriedade {0} deve ter um valor entre {1} e {2}.";
        }
    }
}
