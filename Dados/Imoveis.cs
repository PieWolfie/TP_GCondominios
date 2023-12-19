/*
 * 
 * Classe "Imoveis" - Dados
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
    /// Classe responsável por armazenar e gerenciar informações sobre imóveis.
    /// </summary>
    public class Imoveis
    {
        #region Atributos

        private List<Imovel> listaImoveis;

        #endregion

        #region Métodos

        #region Construtores

        /// <summary>
        /// Inicializa uma nova instância da classe Imoveis.
        /// </summary>
        public Imoveis()
        {
            listaImoveis = new List<Imovel>();
        }

        #endregion

        #region Propriedades
        #endregion

        #region Outros Métodos

        /// <summary>
        /// Adiciona um novo imóvel à lista.
        /// </summary>
        /// <param name="imovel">O imóvel a ser adicionado.</param>
        /// <param name="lancaExcecao">Indica se uma exceção deve ser lançada em caso de duplicata.</param>
        /// <exception cref="ImovelException.ImovelDuplicadoException">Lançada se um imóvel duplicado for detectado.</exception>
        public void AdicionarImovel(Imovel imovel, bool lancaExcecao = false)
        {
            if (!listaImoveis.Contains(imovel))
            {
                if (lancaExcecao)
                {
                    throw new ImovelException.ImovelDuplicadoException(imovel.IdImovel);
                }

            }
            else
            {
                ImovelRegras.ValidarImovel(imovel);
                listaImoveis.Add(imovel);
            }
        }

        /// <summary>
        /// Obtém a lista de todos os imóveis.
        /// </summary>
        /// <returns>A lista de imóveis.</returns>
        public List<Imovel> ObterImoveis()
        {
            return listaImoveis;
        }

        /// <summary>
        /// Obtém um imóvel com base no identificador único.
        /// </summary>
        /// <param name="idImovel">O identificador único do imóvel.</param>
        /// <returns>O imóvel correspondente ou null se não encontrado.</returns>
        public Imovel? ObterImovelPorId(int idImovel)
        {
            return listaImoveis.Find(imovel => imovel.IdImovel == idImovel);
        }

        /// <summary>
        /// Grava a lista de imóveis em um arquivo usando serialização JSON.
        /// </summary>
        /// <param name="caminhoArquivo">O caminho do arquivo para salvar.</param>
        /// <exception cref="ImovelException.GravarImoveisException">Lançada em caso de erro ao gravar imóveis.</exception>
        public void GravarImoveis(string caminhoArquivo)
        {
            try
            {
                string jsonString = JsonSerializer.Serialize(listaImoveis);
                File.WriteAllText(caminhoArquivo, jsonString);
            }
            catch (Exception ex)
            {
                throw new ImovelException.GravarImoveisException(ex.Message);
            }
        }

        /// <summary>
        /// Carrega a lista de imóveis a partir de um arquivo usando desserialização JSON.
        /// </summary>
        /// <param name="caminhoArquivo">O caminho do arquivo para carregar.</param>
        /// <exception cref="ImovelException.CarregarImoveisException">Lançada em caso de erro ao carregar imóveis.</exception>
        public void CarregarImoveis(string caminhoArquivo)
        {
            try
            {
                string jsonString = File.ReadAllText(caminhoArquivo);
                listaImoveis = JsonSerializer.Deserialize<List<Imovel>>(jsonString)!;
            }
            catch (Exception ex)
            {
                throw new ImovelException.CarregarImoveisException(ex.Message);
            }
        }
        #endregion

        #endregion
    }
}