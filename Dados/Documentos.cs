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

namespace Dados
{
    /// <summary>
    /// Classe responsável por armazenar e gerenciar informações sobre documentos.
    /// </summary>
    public class Documentos
    {
        #region Atributos

        private List<ObjetosNegocio.Documento> listaDocumentos;

        #endregion

        #region Métodos

        #region Construtores

        /// <summary>
        /// Inicializa uma nova instância da classe Documentos.
        /// </summary>
        public Documentos()
        {
            listaDocumentos = new List<ObjetosNegocio.Documento>();
        }

        #endregion

        #region Propriedades
        #endregion

        #region Outros Métodos

        /// <summary>
        /// Adiciona um novo documento à lista.
        /// </summary>
        /// <param name="documento">O documento a ser adicionado.</param>
        public void AdicionarDocumento(ObjetosNegocio.Documento documento)
        {
            listaDocumentos.Add(documento);
        }

        /// <summary>
        /// Obtém a lista de todos os documentos.
        /// </summary>
        /// <returns>A lista de documentos.</returns>
        public List<ObjetosNegocio.Documento> ObterDocumentos()
        {
            return listaDocumentos;
        }

        /// <summary>
        /// Obtém um documento com base no tipo e nome.
        /// </summary>
        /// <param name="tipo">O tipo do documento.</param>
        /// <param name="nome">O nome do documento.</param>
        /// <returns>O documento correspondente ou null se não encontrado.</returns>
        public ObjetosNegocio.Documento? ObterDocumentoPorTipoENome(string tipo, string nome)
        {
            return listaDocumentos.Find(documento => documento.Tipo == tipo && documento.Nome == nome);
        }

        #endregion

        #endregion
    }
}

