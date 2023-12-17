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
using System.Runtime.Serialization.Formatters.Binary;
using Excecoes;

namespace ObjetosNegocio
{
    [Serializable()]
    public class Despesa : ISerializable
    {
        #region Atributos

        // Tipo da despesa
        private string tipo;

        // Valor da despesa
        private decimal valor;

        // Data de vencimento da despesa
        private DateTime dataVencimento;

        // Estado de pagamento da despesa
        private bool estadoPagamento;

        // Imóvel associado à despesa
        private string imovel;

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

        #region ISerializable

        // Adicione este método para suportar serialização
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Tipo", Tipo);
            info.AddValue("Valor", Valor);
            info.AddValue("DataVencimento", DataVencimento);
            info.AddValue("EstadoPagamento", EstadoPagamento);
            info.AddValue("Imovel", Imovel);
        }

        // Adicione este construtor para suportar desserialização
        public Despesa(SerializationInfo info, StreamingContext context)
        {
            Tipo = (string)info.GetValue("Tipo", typeof(string));
            Valor = (decimal)info.GetValue("Valor", typeof(decimal));
            DataVencimento = (DateTime)info.GetValue("DataVencimento", typeof(DateTime));
            EstadoPagamento = (bool)info.GetValue("EstadoPagamento", typeof(bool));
            Imovel = (string)info.GetValue("Imovel", typeof(string));
        }

        #endregion

        #endregion
    }
}