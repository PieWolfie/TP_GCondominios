/*
 * 
 * Classe "Despesa" - Objeto de Negócio
 * Fábio Fernandes - a22996@alunos.ipca.pt
 * Pedro Rocha - a23009@alunos.ipca.pt
 * LESI - POO
 * 
 */

using System;
using System.Runtime.Serialization;

namespace ObjetosNegocio
{
    /// <summary>
    /// Representa um despesa no contexto do sistema.
    /// </summary>
    [Serializable]
    public class Despesa
    {
        #region Atributos

        // Tipo da despesa
        private string tipo = null!;

        // Valor da despesa
        private decimal valor;

        // Data de vencimento da despesa
        private DateTime dataVencimento;

        // Estado de pagamento da despesa
        private bool estadoPagamento;

        // Imóvel associado à despesa
        private string imovel = null!;

        #endregion

        #region Métodos

        #region Construtores

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

        #region Propriedades

        /// <summary>
        /// Obtém ou define o tipo da despesa.
        /// </summary>
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        /// <summary>
        /// Obtém ou define o valor da despesa.
        /// </summary>
        public decimal Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        /// <summary>
        /// Obtém ou define a data de vencimento da despesa.
        /// </summary>
        public DateTime DataVencimento
        {
            get { return dataVencimento; }
            set { dataVencimento = value; }
        }

        /// <summary>
        /// Obtém ou define o estado de pagamento da despesa.
        /// </summary>
        public bool EstadoPagamento
        {
            get { return estadoPagamento; }
            set { estadoPagamento = value; }
        }

        /// <summary>
        /// Obtém ou define o imóvel associado à despesa.
        /// </summary>
        public string Imovel
        {
            get { return imovel; }
            set { imovel = value; }
        }

        #endregion

        #region Overrides
        #endregion

        #region Outros Métodos

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

        #region Destrutor
        #endregion

        #endregion
    }
}