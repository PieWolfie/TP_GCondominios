/*
 * 
 * Classe "Despesas" - Dados
 * Fábio Fernandes - a22996@alunos.ipca.pt
 * Pedro Rocha - a23009@alunos.ipca.pt
 * LESI - POO
 * 
 */

using System;
using System.Collections.Generic;
using ObjetosNegocio;
using Excecoes;
using RegrasNegocio;

namespace Dados
{
    /// <summary>
    /// Classe responsável por armazenar e gerenciar informações sobre despesas.
    /// </summary>
    public class Despesas
    {
        #region Atributos

        private List<Despesa> listaDespesas;

        #endregion

        #region Métodos

        #region Construtores

        /// <summary>
        /// Inicializa uma nova instância da classe Despesas.
        /// </summary>
        public Despesas()
        {
            listaDespesas = new List<Despesa>();
        }

        #endregion

        #region Propriedades
        #endregion

        #region Outros Métodos

        /// <summary>
        /// Adiciona uma nova despesa à lista.
        /// </summary>
        /// <param name="despesa">A despesa a ser adicionada.</param>
        public void AdicionarDespesa(Despesa despesa)
        {
            DespesaRegras.ValidarDespesa(despesa);
            listaDespesas.Add(despesa);
        }

        /// <summary>
        /// Obtém a lista de todas as despesas.
        /// </summary>
        /// <returns>A lista de despesas.</returns>
        public List<Despesa> ObterDespesas()
        {
            return listaDespesas;
        }

        /// <summary>
        /// Obtém uma despesa com base no tipo, valor e data de vencimento.
        /// </summary>
        /// <param name="tipo">O tipo da despesa.</param>
        /// <param name="valor">O valor da despesa.</param>
        /// <param name="dataVencimento">A data de vencimento da despesa.</param>
        /// <returns>A despesa correspondente ou null se não encontrada.</returns>
        public Despesa? ObterDespesaPorTipoValorEData(string tipo, decimal valor, DateTime dataVencimento)
        {
            return listaDespesas.Find(despesa => despesa.Tipo == tipo && despesa.Valor == valor && despesa.DataVencimento == dataVencimento);
        }

        #endregion

        #endregion
    }
}