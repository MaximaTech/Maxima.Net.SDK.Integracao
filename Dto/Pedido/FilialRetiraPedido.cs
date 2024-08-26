namespace Maxima.Net.SDK.Integracao.Dto.Pedido
{
    public class FilialRetiraPedido
    {
         private string codigo;

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        private string descricao;

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }
        private decimal estoqueDisp;

        public decimal EstoqueDisp
        {
            get { return estoqueDisp; }
            set { estoqueDisp = value; }
        }
    }
}