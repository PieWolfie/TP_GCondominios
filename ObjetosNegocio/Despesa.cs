using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosNegocio
{
    /// <summary>
    /// Representa uma despesa no contexto do sistema.
    /// </summary>
    public class Despesa
    {
        #region Atributos

        /// <summary>
        /// Obtém ou define o tipo da despesa.
        /// </summary>
        public string Tipo { get; set; }

        /// <summary>
        /// Obtém ou define o valor da despesa.
        /// </summary>
        public decimal Valor { get; set; }

        /// <summary>
        /// Obtém ou define a data de vencimento da despesa.
        /// </summary>
        public DateTime DataVencimento { get; set; }

        /// <summary>
        /// Obtém ou define o estado de pagamento da despesa.
        /// </summary>
        public bool EstadoPagamento { get; set; }

        /// <summary>
        /// Obtém ou define o imóvel associado à despesa.
        /// </summary>
        public string Imovel { get; set; }

        #endregion

        #region Construtor

        /// <summary>
        /// Inicializa uma nova instância da classe Despesa com os parâmetros especificados.
        /// </summary>
        /// <param name="tipo">O tipo da despesa.</param>
        /// <param name="valor">O valor da despesa.</param>
        /// <param name="dataVencimento">A data de vencimento da despesa.</param>
        /// <param name="estadoPagamento">O estado de pagamento da despesa.</param>
        /// <param name="imovel">O imóvel associado à despesa.</param>
        public Despesa(string tipo, decimal valor, DateTime dataVencimento, bool estadoPagamento, string imovel)
        {
            Tipo = tipo;
            Valor = valor;
            DataVencimento = dataVencimento;
            EstadoPagamento = estadoPagamento;
            Imovel = imovel;
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Atualiza o estado de pagamento da despesa.
        /// </summary>
        /// <param name="novoEstado">O novo estado de pagamento.</param>
        public void AtualizarEstadoPagamento(bool novoEstado)
        {
            EstadoPagamento = novoEstado;
        }

        /// <summary>
        /// Obtém o valor total da despesa.
        /// </summary>
        /// <returns>O valor total da despesa.</returns>
        public decimal ObterValorTotal()
        {
            return Valor;
        }

        #endregion
    }
}

