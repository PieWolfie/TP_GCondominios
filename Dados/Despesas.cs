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
using System.IO;
using System.Text.Json;

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
        /// Inicializa uma nova instância da classe.
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
        /// <param name="lancaExcecao">Indica se uma exceção deve ser lançada em caso de duplicata.</param>
        /// <exception cref="DespesaException.DespesaDuplicadaException">Lançada se uma despesa duplicada for detectada.</exception>
        public void AdicionarDespesa(Despesa despesa, bool lancaExcecao = false)
        {
            if (!listaDespesas.Contains(despesa))
            {
                if (lancaExcecao)
                {
                    throw new DespesaException.DespesaDuplicadaException(despesa.Tipo, despesa.Valor, despesa.DataVencimento);
                }
            }
            else
            {
                DespesaRegras.ValidarDespesa(despesa);
                listaDespesas.Add(despesa);
            }
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

        /// <summary>
        /// Grava a lista de despesas em um arquivo usando serialização JSON.
        /// </summary>
        /// <param name="caminhoArquivo">O caminho do arquivo para salvar.</param>
        /// <exception cref="DespesaException.GravarDespesasException">Lançada em caso de erro ao gravar despesas.</exception>
        public void GravarDespesas(string caminhoArquivo)
        {
            try
            {
                string jsonString = JsonSerializer.Serialize(listaDespesas);
                File.WriteAllText(caminhoArquivo, jsonString);
            }
            catch (Exception ex)
            {
                throw new DespesaException.GravarDespesasException(ex.Message);
            }
        }

        /// <summary>
        /// Carrega a lista de despesas a partir de um arquivo usando desserialização JSON.
        /// </summary>
        /// <param name="caminhoArquivo">O caminho do arquivo para carregar.</param>
        /// <exception cref="DespesaException.CarregarDespesasException">Lançada em caso de erro ao carregar despesas.</exception>
        public void CarregarDespesas(string caminhoArquivo)
        {
            try
            {
                string jsonString = File.ReadAllText(caminhoArquivo);
                listaDespesas = JsonSerializer.Deserialize<List<Despesa>>(jsonString)!;
            }
            catch (Exception ex)
            {
                throw new DespesaException.CarregarDespesasException(ex.Message);
            }
        }

        #endregion

        #endregion
    }
}