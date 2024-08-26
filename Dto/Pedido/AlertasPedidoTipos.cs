namespace Maxima.Net.SDK.Integracao.Dto.Pedido
{
   public enum AlertasPedidoTipos
    {
        /// <summary>
        /// Denota apenas alguma informação sobre o pedido
        /// </summary>

        Informacao = 0,
        /// <summary>
        /// Representa um alerta, o pedido sera gravado, mas com restrições
        /// </summary>

        Alerta = 1,
        /// <summary>
        /// Representa um erro que impede que o pedido seja salvo
        /// </summary>

        Erro = 2
    }
}