﻿/*
 * 
 * Classe "Gestor" - Objeto de Negócio
 * Fábio Fernandes - a22996@alunos.ipca.pt
 * Pedro Rocha - a23009@alunos.ipca.pt
 * LESI - POO
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjetosNegocio
{
    /// <summary>
    /// Classe que representa um Gestor no contexto do sistema.
    /// </summary>
    public class Gestor
    {
        #region Atributos

        /// <summary>
        /// Obtém ou define o identificador do condomínio selecionado pelo gestor.
        /// </summary>
        public int CondominioSelecionado { get; set; }

        /// <summary>
        /// Obtém ou define a lista de condomínios gerenciados pelo gestor.
        /// </summary>
        public List<Condominio> Condominios { get; set; } = new List<Condominio>();

        #endregion

        #region Métodos

        #region Construtores
        #endregion

        #region Propriedades
        #endregion

        #region Overrides
        #endregion

        #region Outros Métodos

        /// <summary>
        /// Método para apresentar uma lista com os condomínios inseridos no sistema.
        /// </summary>
        public void ListaCondominios()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var condominio in Condominios)
            {
                sb.Append(condominio.Nome);
                sb.Append(Environment.NewLine);
            }
            string listaCondominios = sb.ToString();
        }

        /// <summary>
        /// Método para adicionar um novo condomínio ao sistema de gestão de condomínios.
        /// </summary>
        public void AdicionarCondominio(Condominio condominio)
        {
            Condominios.Add(condominio);
        }

        /// <summary>
        /// Método para remover um condomínio presente no sistema de gestão de condomínios.
        /// </summary>
        public void RemoverCondominio(Condominio condominio)
        {
            Condominios.Remove(condominio);
        }

        /// <summary>
        /// Método para escolher um condomínio para gerir.
        /// </summary>
        public void SelecionarCondominio(int idCondominio)
        {
            CondominioSelecionado = idCondominio;
        }

        /// <summary>
        /// Método para realizar o pagamento de todas as despesas em aberto do condomínio em questão.
        /// </summary>
        public void RealizarPagamento()
        {
            Condominio condominioAtual = Condominios.FirstOrDefault(c => c.IdCondominio == CondominioSelecionado);

            // Exemplo: Pagamento de todas as despesas em aberto
            foreach (var despesa in condominioAtual.Despesas)
            {
                if (!despesa.EstadoPagamento)
                {
                    // Obtém o proprietário associado à despesa
                    Proprietario proprietarioDaDespesa = ObterProprietarioDaDespesa(despesa, condominioAtual.Proprietarios);

                    // Realiza o pagamento chamando o método RealizarPagamento do proprietário
                    // Passa o valor da despesa como parâmetro
                    proprietarioDaDespesa.RealizarPagamento(despesa.Valor);
                }
            }
        }

        // Função para obter o proprietário associado à despesa
        private Proprietario ObterProprietarioDaDespesa(Despesa despesa, List<Proprietario> proprietarios)
        {
            // Lógica para encontrar o proprietário associado à despesa
            // Exemplo: assume que o imóvel da despesa corresponde ao imóvel do proprietário
            return proprietarios.FirstOrDefault(p => p.Imovel == despesa.Imovel);
        }

        /// <summary>
        /// Método para marcar a reunião do condomínio em questão.
        /// </summary>
        public void MarcarReunioes(DateTime data, TimeSpan hora, string local)
        {
            Condominio condominioAtual = Condominios.FirstOrDefault(c => c.IdCondominio == CondominioSelecionado);

            // Verifica se já existe uma reunião marcada para a mesma data e hora
            if (!condominioAtual.Reunioes.Any(r => r.Data == data && r.Hora == hora))
            {
                // Cria uma nova instância de Reuniao
                Reuniao novaReuniao = new Reuniao(data, hora, local);

                // Adiciona a nova reunião à lista de reuniões do condomínio
                condominioAtual.AdicionarReuniao(novaReuniao);
            }
        }

        /// <summary>
        /// Método para cancelar a reunião marcada do condomínio em questão.
        /// </summary>
        public void RemoverReunioes(DateTime data, TimeSpan hora)
        {
            Condominio condominioAtual = Condominios.FirstOrDefault(c => c.IdCondominio == CondominioSelecionado);

            // Encontra a reunião com a mesma data e hora para remover
            Reuniao reuniaoParaRemover = condominioAtual.Reunioes.FirstOrDefault(r => r.Data == data && r.Hora == hora);

            // Verifica se a reunião foi encontrada antes de tentar removê-la
            if (reuniaoParaRemover != null)
            {
                // Remove a reunião da lista de reuniões do condomínio
                condominioAtual.RemoverReuniao(reuniaoParaRemover);
            }
        }

        /// <summary>
        /// Método para adicionar documentos ao condomínio em questão.
        /// </summary>
        public void AdicionarDocumentos(List<Documento> documentos)
        {
            Condominio condominioAtual = Condominios.FirstOrDefault(c => c.IdCondominio == CondominioSelecionado);

            // Implementação da adição de documentos no contexto do condomínio selecionado
            condominioAtual.AdicionarDocumento(documentos);
        }

        /// <summary>
        /// Método para remover documentos do condomínio em questão.
        /// </summary>
        public void RemoverDocumentos(List<Documento> documentos)
        {
            Condominio condominioAtual = Condominios.FirstOrDefault(c => c.IdCondominio == CondominioSelecionado);

            // Implementação da remoção de documentos no contexto do condomínio selecionado
            condominioAtual.RemoverDocumento(documentos);
        }

        #endregion

        #region Destrutor
        #endregion

        #endregion
    }
}