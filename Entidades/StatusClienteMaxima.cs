namespace Maxima.Net.SDK.Integracao.Entidades
{
    public class StatusClienteMaxima
    {
        public long Id_cliente { get; set; }
        public string Objeto_json { get; set; }
        public int? Status { get; set; }
        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "StatusClientes";
        internal const string Tabela = "MXSINTEGRACAOCLIENTE";

    }
}
