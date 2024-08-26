using System.Collections.Generic;
using System.Linq;

namespace Maxima.Net.SDK.Integracao.Dto
{
    public class ResponseApiMaxima<T>
    {
        public ResponseApiMaxima()
        {
            ItensInserido = new List<T>();
            ErrosValidacao = new List<string>();
        }
        public bool Sucesso { get { return ItensInserido.Any(); } }
        public int TotalItensNaoInserido { get; set; }
        public List<T> ItensInserido { get; set; }
        public List<string> ErrosValidacao { get; set; }
        public string ErrosValidacaoFormatado { get { return string.Join("", ErrosValidacao); } }
    }
}
