using System.ComponentModel.DataAnnotations;

namespace Maxima.Net.SDK.Integracao.Utils.Atributos
{
    internal class TamanhoMaximoAttribute : MaxLengthAttribute
    {
        public TamanhoMaximoAttribute(int tamanhoMaximo) : base(tamanhoMaximo)
        {
            ErrorMessage = "A propriedade {0} deve possuir no máximo {1} caracteres.";
        }
    }
}
