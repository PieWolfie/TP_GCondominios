/*
 * 
 * Classe "Documento" - Objeto de Negócio
 * Fábio Fernandes - a22996@alunos.ipca.pt
 * Pedro Rocha - a23009@alunos.ipca.pt
 * LESI - POO
 * 
 */

using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using Excecoes;

namespace ObjetosNegocio
{
    [Serializable()]
    public class Documento : ISerializable
    {
        #region Atributos

        // Tipo do documento
        private string tipo;

        // Data de criação do documento
        private DateTime dataCriacao;

        // Conteúdo do documento
        private string conteudo;

        // Nome do documento
        private string nome;

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

        /// <summary>
        /// Obtém ou define o tipo do documento.
        /// </summary>
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        /// <summary>
        /// Obtém ou define a data de criação do documento.
        /// </summary>
        public DateTime DataCriacao
        {
            get { return dataCriacao; }
            set { dataCriacao = value; }
        }

        /// <summary>
        /// Obtém ou define o conteúdo do documento.
        /// </summary>
        public string Conteudo
        {
            get { return conteudo; }
            set { conteudo = value; }
        }

        /// <summary>
        /// Obtém ou define o nome do documento.
        /// </summary>
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

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

        #region ISerializable

        // Adicione este método para suportar serialização
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Tipo", Tipo);
            info.AddValue("DataCriacao", DataCriacao);
            info.AddValue("Conteudo", Conteudo);
            info.AddValue("Nome", Nome);
        }

        // Adicione este construtor para suportar desserialização
        public Documento(SerializationInfo info, StreamingContext context)
        {
            Tipo = (string)info.GetValue("Tipo", typeof(string));
            DataCriacao = (DateTime)info.GetValue("DataCriacao", typeof(DateTime));
            Conteudo = (string)info.GetValue("Conteudo", typeof(string));
            Nome = (string)info.GetValue("Nome", typeof(string));
        }

        #endregion

        #endregion
    }
}

