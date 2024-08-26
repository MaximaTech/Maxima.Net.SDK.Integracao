using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Maxima.Net.SDK.Integracao.Utils.Atributos
{
    internal class RangeStringAttribute : ValidationAttribute
    {
        public string[] Valores { get; set; }

        public RangeStringAttribute(params string[] valores)
        {
            Valores = valores;
            ErrorMessage = "{0} deve ser: " + string.Join(", ", valores) + ".";
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (string.IsNullOrEmpty(value?.ToString()))
                return ValidationResult.Success;

            if (Valores.Any(c => c == value.ToString()))
                return ValidationResult.Success;
            else
            {
                string[] memberNames = validationContext.MemberName != null ? new string[] { validationContext.MemberName } : null;
                return new ValidationResult(FormatErrorMessage(validationContext.DisplayName), memberNames);
            }
        }
    }
}
