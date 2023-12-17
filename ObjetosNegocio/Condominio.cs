/*
 * 
 * Classe "Condominio" - Objeto de Negócio
 * Fábio Fernandes - a22996@alunos.ipca.pt
 * Pedro Rocha - a23009@alunos.ipca.pt
 * LESI - POO
 * 
 */

using System;
using System.Collections.Generic;
using System. Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace ObjetosNegocio
{

    [Serializable()]
    /// <summary>
    /// Representa um condomínio no contexto do sistema.
    /// </summary>
    public class Condominio : ISerializable
    {
        #region Atributos

        // Nome do condomínio
        private string nome;

        // Endereço do condomínio
        private string endereco;

        // Lista de despesas associadas ao condomínio
        private List<string> despesas;

        // Lista de imóveis associados ao condomínio
        private List<string> imoveis;

        // Lista de proprietários associados ao condomínio
        private List<string> proprietarios;

        // Lista de reuniões agendadas no condomínio
        private List<string> reunioes;

        // Lista de documentos associados ao condomínio
        private List<string> documentos;

        #endregion

        #region Métodos

        #region Construtores

        /// <summary>
        /// Construtor predefinido para a classe Condominio.
        /// </summary>
        /// <param name="nome">O nome do condomínio.</param>
        /// <param name="endereco">O endereço do condomínio.</param>
        /// <param name="despesas">A lista de despesas associadas ao condomínio.</param>
        /// <param name="imoveis">A lista de imóveis associados ao condomínio.</param>
        /// <param name="proprietarios">A lista de proprietários associados ao condomínio.</param>
        /// <param name="reunioes">A lista de reuniões agendadas no condomínio.</param>
        /// <param name="documentos">A lista de documentos associados ao condomínio.</param>
        public Condominio(string nome, string endereco, List<string> despesas, List<string> imoveis, List<string> proprietarios, List<string> reunioes, List<string> documentos)
        {
            Nome = nome;
            Endereco = endereco;
            Despesas = despesas;
            Imoveis = imoveis;
            Proprietarios = proprietarios;
            Reunioes = reunioes;
            Documentos = documentos;
        }

        #endregion

        #region Propriedades

        /// <summary>
        /// Obtém ou define o nome do condomínio.
        /// </summary>
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        /// <summary>
        /// Obtém ou define o endereço do condomínio.
        /// </summary>
        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        /// <summary>
        /// Obtém ou define a lista de despesas associadas ao condomínio.
        /// </summary>
        public List<string> Despesas
        {
            get { return despesas; }
            set { despesas = value; }
        }

        /// <summary>
        /// Obtém ou define a lista de imóveis associados ao condomínio.
        /// </summary>
        public List<string> Imoveis
        {
            get { return imoveis; }
            set { imoveis = value; }
        }

        /// <summary>
        /// Obtém ou define a lista de proprietários associados ao condomínio.
        /// </summary>
        public List<string> Proprietarios
        {
            get { return proprietarios; }
            set { proprietarios = value; }
        }

        /// <summary>
        /// Obtém ou define a lista de reuniões agendadas no condomínio.
        /// </summary>
        public List<string> Reunioes
        {
            get { return reunioes; }
            set { reunioes = value; }
        }

        /// <summary>
        /// Obtém ou define a lista de documentos associados ao condomínio.
        /// </summary>
        public List<string> Documentos
        {
            get { return documentos; }
            set { documentos = value; }
        }

        #endregion

        #region Overrides
        #endregion

        #region Outros Métodos

        /// <summary>
        /// Adiciona uma nova despesa à lista de despesas associadas ao condomínio.
        /// </summary>
        /// <param name="despesa">A despesa a ser adicionada.</param>
        public void AdicionarDespesa(string despesa)
        {
            Despesas.Add(despesa);
        }

        /// <summary>
        /// Adiciona um novo imóvel à lista de imóveis associados ao condomínio.
        /// </summary>
        /// <param name="imovel">O imóvel a ser adicionado.</param>
        public void AdicionarImovel(string imovel)
        {
            Imoveis.Add(imovel);
        }

        /// <summary>
        /// Adiciona um novo proprietário à lista de proprietários associados ao condomínio.
        /// </summary>
        /// <param name="proprietario">O proprietário a ser adicionado.</param>
        public void AdicionarProprietario(string proprietario)
        {
            Proprietarios.Add(proprietario);
        }

        /// <summary>
        /// Agenda uma nova reunião na lista de reuniões do condomínio.
        /// </summary>
        /// <param name="reuniao">A reunião a ser agendada.</param>
        public void AgendarReuniao(string reuniao)
        {
            Reunioes.Add(reuniao);
        }

        /// <summary>
        /// Adiciona um novo documento à lista de documentos associados ao condomínio.
        /// </summary>
        /// <param name="documento">O documento a ser adicionado.</param>
        public void AdicionarDocumento(string documento)
        {
            Documentos.Add(documento);
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Nome", Nome);
            info.AddValue("Endereco", Endereco);
            info.AddValue("Despesas", Despesas);
            info.AddValue("Imoveis", Imoveis);
            info.AddValue("Proprietarios", Proprietarios);
            info.AddValue("Reunioes", Reunioes);
            info.AddValue("Documentos", Documentos);
        }

        public Condominio(SerializationInfo info, StreamingContext context)
        {
            Nome = (string)info.GetValue("Nome", typeof(string));
            Endereco = (string)info.GetValue("Endereco", typeof(string));
            Despesas = (List<string>)info.GetValue("Despesas", typeof(List<string>));
            Imoveis = (List<string>)info.GetValue("Imoveis", typeof(List<string>));
            Proprietarios = (List<string>)info.GetValue("Proprietarios", typeof(List<string>));
            Reunioes = (List<string>)info.GetValue("Reunioes", typeof(List<string>));
            Documentos = (List<string>)info.GetValue("Documentos", typeof(List<string>));
        }

        #endregion

        #region Destrutor
        #endregion

        #endregion
    }
}