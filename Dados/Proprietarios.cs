/*
 * 
 * Classe "Proprietarios" - Dados
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
    /// Classe responsável por armazenar e gerenciar informações sobre proprietários.
    /// </summary>
    public class Proprietarios
    {
        #region Atributos

        // Lista privada que armazena os proprietários
        private List<Proprietario> listaProprietarios;

        #endregion

        #region Métodos

        #region Construtores

        /// <summary> 
        /// Construtor padrão que inicializa a lista de proprietários.
        /// </summary>
        public Proprietarios()
        {
            listaProprietarios = new List<Proprietario>();
        }

        #endregion

        #region Propriedades
        #endregion

        #region Overrides
        #endregion

        #region Outros Métodos

        /// <summary>
        /// Adiciona um novo proprietário à lista.
        /// </summary>
        /// <param name="proprietario">O proprietário a ser adicionado.</param>
        /// <param name="lancaExcecao">Indica se uma exceção deve ser lançada em caso de duplicata.</param>
        /// <exception cref="ProprietarioException.ProprietarioDuplicadoException">Lançada se um proprietário duplicado for detectado.</exception>
        public void AdicionarProprietario(Proprietario proprietario, bool lancaExcecao = false)
        {
            if (!listaProprietarios.Contains(proprietario))
            {
                if (lancaExcecao)
                {
                    throw new ProprietarioException.ProprietarioDuplicadoException(proprietario.Nif);
                }
            }
            else
            {
                ProprietarioRegras.ValidarProprietario(proprietario);
                listaProprietarios.Add(proprietario);
            }
        }

        /// <summary>
        /// Obtém a lista de todos os proprietários.
        /// </summary>
        /// <returns>A lista de proprietários.</returns>
        public List<Proprietario> ObterProprietarios()
        {
            return listaProprietarios;
        }

        /// <summary>
        /// Obtém um proprietário com base no NIF.
        /// </summary>
        /// <param name="nif">O NIF do proprietário.</param>
        /// <returns>O proprietário correspondente ou null se não encontrado.</returns>
        public Proprietario? ObterProprietarioPorNif(string nif)
        {
            return listaProprietarios.Find(proprietario => proprietario.Nif == nif);
        }

        /// <summary>
        /// Grava a lista de proprietários em um arquivo usando serialização JSON.
        /// </summary>
        /// <param name="caminhoArquivo">O caminho do arquivo para salvar.</param>
        /// <exception cref="ProprietarioException.GravarProprietariosException">Lançada em caso de erro ao gravar proprietários.</exception>
        public void GravarProprietarios(string caminhoArquivo)
        {
            try
            {
                string jsonString = JsonSerializer.Serialize(listaProprietarios);
                File.WriteAllText(caminhoArquivo, jsonString);
            }
            catch (Exception ex)
            {
                throw new ProprietarioException.GravarProprietariosException(ex.Message);
            }
        }

        /// <summary>
        /// Carrega a lista de proprietários a partir de um arquivo usando desserialização JSON.
        /// </summary>
        /// <param name="caminhoArquivo">O caminho do arquivo para carregar.</param>
        /// <exception cref="ProprietarioException.CarregarProprietariosException">Lançada em caso de erro ao carregar proprietários.</exception>
        public void CarregarProprietarios(string caminhoArquivo)
        {
            try
            {
                string jsonString = File.ReadAllText(caminhoArquivo);
                listaProprietarios = JsonSerializer.Deserialize<List<Proprietario>>(jsonString)!;
            }
            catch (Exception ex)
            {
                throw new ProprietarioException.CarregarProprietariosException(ex.Message);
            }
        }

        #endregion

        #endregion
    }
}