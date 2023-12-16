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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excecoes;

namespace ObjetosNegocio
{
    /// <summary>
    /// Representa um imóvel no contexto do sistema.
    /// </summary>
    public class Imovel
    {
        #region Atributos

        /// <summary>
        /// Obtém ou define o identificador único do imóvel.
        /// </summary>
        public int IdImovel { get; set; }

        /// <summary>
        /// Obtém ou define o proprietário do imóvel.
        /// </summary>
        public List<Proprietario> Proprietarios { get; set; }

        /// <summary>
        /// Obtém ou define a lista de despesas associadas ao imóvel.
        /// </summary>
        public List<Despesa> Despesas { get; set; }

        /// <summary>
        /// Obtém ou define a lista de quotas associadas ao imóvel.
        /// </summary>
        public List<decimal> Quotas { get; set; }

        #endregion

        #region Métodos

        #region Construtores

        /// <summary>
        /// Inicializa uma nova instância da classe Imovel com os parâmetros especificados.
        /// </summary>
        /// <param name="idImovel">O identificador único do imóvel.</param>
        /// <param name="proprietarios">A lista de proprietários do imóvel.</param>
        public Imovel(int idImovel, List<Proprietario> proprietarios)
        {
            IdImovel = idImovel;

            // Verifica se a lista de proprietários é nula ou está vazia
            if (proprietarios == null || proprietarios.Count == 0)
            {
                // Se a lista de proprietários é nula ou vazia, lança uma exceção específica
                throw new ImovelException.ProprietariosImovelVaziosException();
            }

            // Inicializa as listas de despesas e quotas
            Despesas = new List<Despesa>();
            Quotas = new List<decimal>();

            // Verifica se a lista de despesas está vazia
            if (Despesas.Count == 0)
            {
                // Se a lista de despesas está vazia, lança uma exceção específica
                throw new ImovelException.DespesasImovelVaziasException();
            }

            // Define a lista de proprietários
            Proprietarios = proprietarios;
        }


        #endregion

        #region Propriedades
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

        #region Destrutor
        #endregion

        #endregion
    }
}