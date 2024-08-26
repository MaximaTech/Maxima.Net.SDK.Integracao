using System.ComponentModel.DataAnnotations;

namespace Maxima.Net.SDK.Integracao.Utils.Atributos
{
    internal class CampoObrigatorioAoInserirAttribute : RequiredAttribute
    {
        public CampoObrigatorioAoInserirAttribute()
        {
            AllowEmptyStrings = false;
            ErrorMessage = "A propriedade obrigatória {0} não foi informada.";
        }
    }
}
