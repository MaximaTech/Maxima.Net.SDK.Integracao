using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    public class RomaneioApi
    {
        [JsonProperty("romaneio")]
        public List<RomaneioMaxima> RomaneioMaximas { get; set; }
    }
    public class RomaneioMaxima
    {
        public long IdRomaneio { get; set; }

        public List<string> IdsCarregamentos { get; set; }

        public DateTime? DataSaida { get; set; }

        public DateTime? DataInicio { get; set; }

        public DateTime? DataFim { get; set; }

        public string IdMotorista { get; set; }

        public string Motorista { get; set; }

        public string IdVeiculo { get; set; }

        public string Veiculo { get; set; }

        public List<EntregaInfoRomaneio> Entregas { get; set; }
        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "InfoRomaneio";
    }
    public class EntregaInfoRomaneio
    {

        public long IdEntrega { get; set; }

        public string IdCliente { get; set; }

        public string IdEnderecoEntrega { get; set; }

        public string IdCarregamento { get; set; }

        public DateTime? PrevisaoEntrega { get; set; }

        public List<NotaFiscalInfoRomaneio> NotasFiscais { get; set; }
    }

    public class NotaFiscalInfoRomaneio
    {
        public long? NumNota { get; set; }

        public long? NumTransVenda { get; set; }

        public DateTime? DataEntrega { get; set; }

        public string SituacaoEntrega { get; set; }

        public string IdFilial { get; set; }
    }
}