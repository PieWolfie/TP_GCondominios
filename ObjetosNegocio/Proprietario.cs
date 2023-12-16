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
using Excecoes;

namespace ObjetosNegocio
{
    /// <summary>
    /// Representa um proprietário no contexto do sistema.
    /// </summary>
    public class Proprietario
    {
        #region Atributos

        /// <summary>
        /// Obtém ou define o nome do proprietário.
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Obtém ou define o contato do proprietário.
        /// </summary>
        public string Contato { get; set; }

        /// <summary>
        /// Obtém ou define o imóvel associado ao proprietário.
        /// </summary>
        public string Imovel { get; set; }

        /// <summary>
        /// Obtém ou define o NIF (Número de Identificação Fiscal) do proprietário.
        /// </summary>
        public string Nif { get; set; }

        /// <summary>
        /// Obtém a lista de histórico de pagamentos do proprietário.
        /// </summary>
        public List<string> HistoricoPagamentos { get; private set; }

        /// <summary>
        /// Obtém a lista de presenças em reuniões do proprietário.
        /// </summary>
        public List<string> PresencasReunioes { get; private set; }

        #endregion

        #region Métodos

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
            if (string.IsNullOrWhiteSpace(nome))
            {
                throw new ProprietarioException.NomeProprietarioNuloOuVazioException();
            }

            if (string.IsNullOrWhiteSpace(contato))
            {
                throw new ProprietarioException.ContatoProprietarioNuloOuVazioException();
            }

            if (string.IsNullOrWhiteSpace(imovel))
            {
                throw new ProprietarioException.ImovelProprietarioNuloOuVazioException();
            }

            if (string.IsNullOrWhiteSpace(nif))
            {
                throw new ProprietarioException.NifProprietarioNuloOuVazioException();
            }

            Nome = nome;
            Contato = contato;
            Imovel = imovel;
            Nif = nif;
            HistoricoPagamentos = new List<string>();
            PresencasReunioes = new List<string>();
        }

        #endregion

        #region Propriedades
        #endregion

        #region Overrides
        #endregion

        #region Outros Métodos

        /// <summary>
        /// Realiza o pagamento e registra no histórico de pagamentos.
        /// </summary>
        /// <param name="valor">O valor do pagamento.</param>
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

        #region Destrutor
        #endregion

        #endregion
    }
}