/*
 * 
 * Classe "Condominios" - Dados
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
    /// Classe responsável por armazenar e gerenciar informações sobre condomínios.
    /// </summary>
    public class Condominios
    {
        #region Atributos

        // Lista privada que armazena os condomínios
        private List<Condominio> listaCondominios;

        #endregion

        #region Métodos

        #region Construtores

        /// <summary>
        /// Inicializa uma nova instância da classe Condominios.
        /// </summary>
        public Condominios()
        {
            listaCondominios = new List<Condominio>();
        }

        #endregion

        #region Propriedades
        #endregion

        #region Overrides
        #endregion

        #region Outros Métodos

        /// <summary>
        /// Adiciona um novo condomínio à lista.
        /// </summary>
        /// <param name="condominio">O condomínio a ser adicionado.</param>
        /// <param name="lancaExcecao">Indica se uma exceção deve ser lançada em caso de duplicata.</param>
        /// <exception cref="CondominioException.CondominioDuplicadoException">Lançada se um condomínio duplicado for detectado.</exception>
        public void AdicionarCondominio(Condominio condominio, bool lancaExcecao = false)
        {
            if (!listaCondominios.Contains(condominio))
            {
                if (lancaExcecao)
                {
                    throw new CondominioException.CondominioDuplicadoException(condominio.Nome, condominio.Endereco);
                }
            }
            else
            {
                CondominioRegras.ValidarCondominio(condominio);
                listaCondominios.Add(condominio);
            }
        }

        /// <summary>
        /// Obtém a lista de todos os condomínios.
        /// </summary>
        /// <returns>A lista de condomínios.</returns>
        public List<Condominio> ObterCondominios()
        {
            return listaCondominios;
        }

        /// <summary>
        /// Obtém um condomínio com base no nome.
        /// </summary>
        /// <param name="nome">O nome do condomínio.</param>
        /// <returns>O condomínio correspondente ou null se não encontrado.</returns>
        public Condominio? ObterCondominioPorNome(string nome)
        {
            return listaCondominios.Find(condominio => condominio.Nome == nome);
        }

        /// <summary>
        /// Grava a lista de condomínios em um arquivo usando serialização JSON.
        /// </summary>
        /// <param name="caminhoArquivo">O caminho do arquivo para salvar.</param>
        /// <exception cref="CondominioException.GravarCondominiosException">Lançada em caso de erro ao gravar condomínios.</exception>
        public void GravarCondominios(string caminhoArquivo)
        {
            try
            {
                string jsonString = JsonSerializer.Serialize(listaCondominios);
                File.WriteAllText(caminhoArquivo, jsonString);
            }
            catch (Exception ex)
            {
                throw new CondominioException.GravarCondominiosException(ex.Message);
            }
        }

        /// <summary>
        /// Carrega a lista de condomínios a partir de um arquivo usando desserialização JSON.
        /// </summary>
        /// <param name="caminhoArquivo">O caminho do arquivo para carregar.</param>
        /// <exception cref="CondominioException.CarregarCondominiosException">Lançada em caso de erro ao carregar condomínios.</exception>
        public void CarregarCondominios(string caminhoArquivo)
        {
            try
            {
                string jsonString = File.ReadAllText(caminhoArquivo);
                listaCondominios = JsonSerializer.Deserialize<List<Condominio>>(jsonString)!;
            }
            catch (Exception ex)
            {
                throw new CondominioException.CarregarCondominiosException(ex.Message);
            }
        }

        #endregion

        #endregion
    }
}