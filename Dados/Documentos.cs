/*
 * 
 * Classe "Documentos" - Dados
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
using System.Text.Json;

namespace Dados
{
    /// <summary>
    /// Classe responsável por armazenar e gerenciar informações sobre documentos.
    /// </summary>
    public class Documentos
    {
        #region Atributos

        // Lista de documentos
        private List<Documento> listaDocumentos;

        #endregion

        #region Métodos

        #region Construtores

        /// <summary>
        /// Inicializa uma nova instância da classe <see cref="Documentos"/>.
        /// </summary>
        public Documentos()
        {
            listaDocumentos = new List<Documento>();
        }

        #endregion

        #region Propriedades
        #endregion

        #region Outros Métodos

        /// <summary>
        /// Adiciona um novo documento à lista.
        /// </summary>
        /// <param name="documento">O documento a ser adicionado.</param>
        /// <param name="lancaExcecao">Indica se deve lançar uma exceção em caso de documento duplicado.</param>
        /// <exception cref="DocumentoException.DocumentoDuplicadoException">Lançada em caso de documento duplicado.</exception>
        public void AdicionarDocumento(Documento documento, bool lancaExcecao = false)
        {
            if (!listaDocumentos.Contains(documento))
            {
                if (lancaExcecao)
                {
                    throw new DocumentoException.DocumentoDuplicadoException(documento.Nome);
                }
            }
            else
            {
                DocumentoRegras.ValidarDocumento(documento);
                listaDocumentos.Add(documento);
            }
        }

        /// <summary>
        /// Obtém a lista de todos os documentos.
        /// </summary>
        /// <returns>A lista de documentos.</returns>
        public List<Documento> ObterDocumentos()
        {
            return listaDocumentos;
        }

        /// <summary>
        /// Obtém um documento com base no tipo e nome.
        /// </summary>
        /// <param name="tipo">O tipo do documento.</param>
        /// <param name="nome">O nome do documento.</param>
        /// <returns>O documento correspondente ou null se não encontrado.</returns>
        public Documento? ObterDocumentoPorTipoENome(string tipo, string nome)
        {
            return listaDocumentos.Find(documento => documento.Tipo == tipo && documento.Nome == nome);
        }

        /// <summary>
        /// Grava a lista de documentos em um arquivo usando serialização JSON.
        /// </summary>
        /// <param name="caminhoArquivo">O caminho do arquivo para gravar.</param>
        /// <exception cref="DocumentoException.GravarDocumentosException">Lançada em caso de erro ao gravar os documentos.</exception>
        public void GravarDocumentos(string caminhoArquivo)
        {
            try
            {
                string jsonString = JsonSerializer.Serialize(listaDocumentos);
                File.WriteAllText(caminhoArquivo, jsonString);
            }
            catch (Exception ex)
            {
                throw new DocumentoException.GravarDocumentosException(ex.Message);
            }
        }

        /// <summary>
        /// Carrega a lista de documentos a partir de um arquivo usando desserialização JSON.
        /// </summary>
        /// <param name="caminhoArquivo">O caminho do arquivo para carregar.</param>
        /// <exception cref="DocumentoException.CarregarDocumentosException">Lançada em caso de erro ao carregar os documentos.</exception>
        public void CarregarDocumentos(string caminhoArquivo)
        {
            try
            {
                string jsonString = File.ReadAllText(caminhoArquivo);
                listaDocumentos = JsonSerializer.Deserialize<List<Documento>>(jsonString)!;
            }
            catch (Exception ex)
            {
                throw new DocumentoException.CarregarDocumentosException(ex.Message);
            }
        }

        #endregion

        #endregion
    }
}