/*
 * 
 * Classe "Documento" - Objeto de Negócio
 * Fábio Fernandes - a22996@alunos.ipca.pt
 * Pedro Rocha - a23009@alunos.ipca.pt
 * LESI - POO
 * 
 */

using System;

namespace ObjetosNegocio
{
    /// <summary>
    /// Representa um documento no contexto do sistema.
    /// </summary>
    public class Documento
    {
        #region Atributos

        /// <summary>
        /// Obtém ou define o tipo do documento.
        /// </summary>
        public string Tipo { get; set; }

        /// <summary>
        /// Obtém ou define a data de criação do documento.
        /// </summary>
        public DateTime DataCriacao { get; set; }

        /// <summary>
        /// Obtém ou define o conteúdo do documento.
        /// </summary>
        public string Conteudo { get; set; }

        /// <summary>
        /// Obtém ou define o nome do documento.
        /// </summary>
        public string Nome { get; set; }

        #endregion

        #region Métodos

        #region Construtores

        /// <summary>
        /// Inicializa uma nova instância da classe Documento com os parâmetros especificados.
        /// </summary>
        /// <param name="tipo">O tipo do documento.</param>
        /// <param name="dataCriacao">A data de criação do documento.</param>
        /// <param name="conteudo">O conteúdo do documento.</param>
        /// <param name="nome">O nome do documento.</param>
        public Documento(string tipo, DateTime dataCriacao, string conteudo, string nome)
        {
            Tipo = tipo;
            DataCriacao = dataCriacao;
            Conteudo = conteudo;
            Nome = nome;
        }

        #endregion

        #region Propriedades
        #endregion

        #region Overrides
        #endregion

        #region Outros Métodos

        /// <summary>
        /// Adiciona ou atualiza o documento com o conteúdo fornecido.
        /// </summary>
        /// <param name="conteudo">O novo conteúdo do documento.</param>
        public void AtualizarConteudo(string conteudo)
        {
            Conteudo = conteudo;
        }

        /// <summary>
        /// Adiciona um novo documento com o tipo, data de criação, conteúdo e nome fornecidos.
        /// </summary>
        /// <param name="tipo">O tipo do documento.</param>
        /// <param name="dataCriacao">A data de criação do documento.</param>
        /// <param name="conteudo">O conteúdo do documento.</param>
        /// <param name="nome">O nome do documento.</param>
        public void AdicionarDocumento(string tipo, DateTime dataCriacao, string conteudo, string nome)
        {
            Tipo = tipo;
            DataCriacao = dataCriacao;
            Conteudo = conteudo;
            Nome = nome;
        }

        /// <summary>
        /// Remove o documento, definindo todos os atributos como vazios ou padrão.
        /// </summary>
        public void RemoverDocumento()
        {
            Tipo = string.Empty;
            DataCriacao = DateTime.MinValue;
            Conteudo = string.Empty;
            Nome = string.Empty;
        }
        #endregion

        #region Destrutor
        #endregion

        #endregion
    }
}