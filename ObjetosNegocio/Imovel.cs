/*
 * 
 * Classe "Imovel" - Objeto de Negócio
 * Fábio Fernandes - a22996@alunos.ipca.pt
 * Pedro Rocha - a23009@alunos.ipca.pt
 * LESI - POO
 * 
 */

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using Excecoes;

namespace ObjetosNegocio
{
    [Serializable()]
    public class Imovel : ISerializable
    {
        #region Atributos

        // Identificador único do imóvel
        private int idImovel;

        // Lista de proprietários do imóvel
        private List<Proprietario> proprietarios;

        // Lista de despesas associadas ao imóvel
        private List<Despesa> despesas;

        // Lista de quotas associadas ao imóvel
        private List<decimal> quotas;

        // Endereço do imóvel
        private string endereco;

        #endregion

        #region Métodos

        #region Construtores

        /// <summary>
        /// Inicializa uma nova instância da classe Imovel com os parâmetros especificados.
        /// </summary>
        /// <param name="idImovel">O identificador único do imóvel.</param>
        /// <param name="proprietarios">A lista de proprietários do imóvel.</param>
        /// <param name="endereco">O endereço do imóvel.</param>
        public Imovel(int idImovel, List<Proprietario> proprietarios, string endereco)
        {
            IdImovel = idImovel;

            // Inicializa as listas de despesas e quotas
            Despesas = new List<Despesa>();
            Quotas = new List<decimal>();

            // Define a lista de proprietários
            Proprietarios = proprietarios;

            // Define o endereço do imóvel
            Endereco = endereco;
        }

        #endregion

        #region Propriedades

        /// <summary>
        /// Obtém ou define o identificador único do imóvel.
        /// </summary>
        public int IdImovel
        {
            get { return idImovel; }
            set { idImovel = value; }
        }

        /// <summary>
        /// Obtém ou define a lista de proprietários do imóvel.
        /// </summary>
        public List<Proprietario> Proprietarios
        {
            get { return proprietarios; }
            set { proprietarios = value; }
        }

        /// <summary>
        /// Obtém ou define a lista de despesas associadas ao imóvel.
        /// </summary>
        public List<Despesa> Despesas
        {
            get { return despesas; }
            set { despesas = value; }
        }

        /// <summary>
        /// Obtém ou define a lista de quotas associadas ao imóvel.
        /// </summary>
        public List<decimal> Quotas
        {
            get { return quotas; }
            set { quotas = value; }
        }

        /// <summary>
        /// Obtém ou define o endereço do imóvel.
        /// </summary>
        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        #endregion

        #region Overrides
        #endregion

        #region Outros Métodos

        /// <summary>
        /// Adiciona uma despesa à lista de despesas associadas ao imóvel.
        /// </summary>
        /// <param name="despesa">A despesa a ser adicionada.</param>
        public void AdicionarDespesa(Despesa despesa)
        {
            Despesas.Add(despesa);
        }

        /// <summary>
        /// Registra o pagamento de uma quota do imóvel.
        /// </summary>
        /// <param name="valorPago">O valor pago para a quota.</param>
        public void PagarQuota(decimal valorPago)
        {
            Quotas.Add(valorPago);
        }

        /// <summary>
        /// Obtém o saldo total do imóvel considerando as despesas e quotas pagas.
        /// </summary>
        /// <returns>O saldo total do imóvel.</returns>
        public decimal ObterSaldo()
        {
            // Calcular saldo considerando despesas e quotas pagas
            decimal saldoDespesas = 0;
            foreach (var despesa in Despesas)
            {
                if (despesa.EstadoPagamento)
                {
                    saldoDespesas += despesa.Valor;
                }
            }

            decimal saldoQuotas = 0;
            foreach (var quota in Quotas)
            {
                saldoQuotas += quota;
            }

            return saldoQuotas - saldoDespesas;
        }

        #endregion

        #region ISerializable

        // Adicione este método para suportar serialização
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("IdImovel", IdImovel);
            info.AddValue("Proprietarios", Proprietarios);
            info.AddValue("Despesas", Despesas);
            info.AddValue("Quotas", Quotas);
            info.AddValue("Endereco", Endereco);
        }

        // Adicione este construtor para suportar desserialização
        public Imovel (SerializationInfo info, StreamingContext context)
        {
            IdImovel = (int)info.GetValue("IdImovel", typeof(int));
            Proprietarios = (List<Proprietario>)info.GetValue("Proprietarios", typeof(List<Proprietario>));
            Despesas = (List<Despesa>)info.GetValue("Despesas", typeof(List<Despesa>));
            Quotas = (List<decimal>)info.GetValue("Quotas", typeof(List<decimal>));
            Endereco = (string)info.GetValue("Endereco", typeof(string));
        }

        #endregion

        #region Destrutor
        #endregion

        #endregion
    }
}
