/*
 * 
 * Classe "Proprietario" - Objeto de Negócio
 * Fábio Fernandes - a22996@alunos.ipca.pt
 * Pedro Rocha - a23009@alunos.ipca.pt
 * LESI - POO
 * 
 */

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using Excecoes;

namespace ObjetosNegocio
{
    [Serializable()]
    public class Proprietario : ISerializable
    {
        #region Atributos

        // Nome do proprietário
        private string nome;

        // Contato do proprietário
        private string contato;

        // Imóvel associado ao proprietário
        private string imovel;

        // NIF (Número de Identificação Fiscal) do proprietário
        private string nif;

        // Lista de histórico de pagamentos do proprietário
        private List<string> historicoPagamentos;

        // Lista de presenças em reuniões do proprietário
        private List<string> presencasReunioes;

        #endregion

        #region Construtores

        /// <summary>
        /// Construtor predefinido para a classe Proprietario.
        /// </summary>
        /// <param name="nome">O nome do proprietário.</param>
        /// <param name="contato">O contato do proprietário.</param>
        /// <param name="imovel">O imóvel associado ao proprietário.</param>
        /// <param name="nif">O NIF do proprietário.</param>
        public Proprietario(string nome, string contato, string imovel, string nif)
        {
            Nome = nome;
            Contato = contato;
            Imovel = imovel;
            Nif = nif;
            HistoricoPagamentos = new List<string>();
            PresencasReunioes = new List<string>();
        }

        #endregion

        #region Propriedades

        /// <summary>
        /// Obtém ou define o nome do proprietário.
        /// </summary>
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        /// <summary>
        /// Obtém ou define o contato do proprietário.
        /// </summary>
        public string Contato
        {
            get { return contato; }
            set { contato = value; }
        }

        /// <summary>
        /// Obtém ou define o imóvel associado ao proprietário.
        /// </summary>
        public string Imovel
        {
            get { return imovel; }
            set { imovel = value; }
        }

        /// <summary>
        /// Obtém ou define o NIF (Número de Identificação Fiscal) do proprietário.
        /// </summary>
        public string Nif
        {
            get { return nif; }
            set { nif = value; }
        }

        /// <summary>
        /// Obtém a lista de histórico de pagamentos do proprietário.
        /// </summary>
        public List<string> HistoricoPagamentos
        {
            get { return historicoPagamentos; }
            private set { historicoPagamentos = value; }
        }

        /// <summary>
        /// Obtém a lista de presenças em reuniões do proprietário.
        /// </summary>
        public List<string> PresencasReunioes
        {
            get { return presencasReunioes; }
            private set { presencasReunioes = value; }
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Realiza o pagamento do proprietário com o valor especificado.
        /// </summary>
        /// <param name="valor">O valor a ser pago.</param>
        public void RealizarPagamento(decimal valor)
        {
            HistoricoPagamentos.Add($"Pagamento de {valor:C} realizado em {DateTime.Now}.");
        }

        /// <summary>
        /// Visualiza o histórico de pagamentos do proprietário.
        /// </summary>
        public List<string> VisualizarHistorico()
        {
            return HistoricoPagamentos;
        }

        /// <summary>
        /// Registra a presença do proprietário em uma reunião.
        /// </summary>
        public string PresenciarReuniao()
        {
            string mensagem = $"Presença na reunião em {DateTime.Now}.";
            PresencasReunioes.Add(mensagem);
            return mensagem;
        }

        #endregion

        #region ISerializable

        // Adicione este método para suportar serialização
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Nome", Nome);
            info.AddValue("Contato", Contato);
            info.AddValue("Imovel", Imovel);
            info.AddValue("Nif", Nif);
            info.AddValue("HistoricoPagamentos", HistoricoPagamentos);
            info.AddValue("PresencasReunioes", PresencasReunioes);
        }

        // Adicione este construtor para suportar desserialização
        public Proprietario(SerializationInfo info, StreamingContext context)
        {
            Nome = (string)info.GetValue("Nome", typeof(string));
            Contato = (string)info.GetValue("Contato", typeof(string));
            Imovel = (string)info.GetValue("Imovel", typeof(string));
            Nif = (string)info.GetValue("Nif", typeof(string));
            HistoricoPagamentos = (List<string>)info.GetValue("HistoricoPagamentos", typeof(List<string>));
            PresencasReunioes = (List<string>)info.GetValue("PresencasReunioes", typeof(List<string>));
        }

        #endregion
    }
}
