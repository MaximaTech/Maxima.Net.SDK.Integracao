using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Maxima.Net.SDK.Integracao.Utils.Atributos
{
    internal class RangeNumberAttribute : ValidationAttribute
    {
        public int[] Valores { get; set; }

        public RangeNumberAttribute(params int[] valores)
        {
            Valores = valores;
            ErrorMessage = "{0} deve ser: " + string.Join(", ", valores) + ".";
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null && Valores.Any(c => c == int.Parse(value.ToString())))
                return ValidationResult.Success;
            else
            {
                string[] memberNames = validationContext.MemberName != null ? new string[] { validationContext.MemberName } : null;
                return new ValidationResult(FormatErrorMessage(validationContext.DisplayName), memberNames);
            }
        }
    }
}
