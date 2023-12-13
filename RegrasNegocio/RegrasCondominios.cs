using System;
using System.Collections.Generic;

namespace RegrasNegocio
{
    /// <summary>
    /// Classe de Regras de Negócio para a entidade Condominio.
    /// </summary>
    public class RegrasCondominios
    {
        /// <summary>
        /// Valida e cria um novo condomínio.
        /// </summary>
        /// <param name="nome">O nome do condomínio.</param>
        /// <param name="endereco">O endereço do condomínio.</param>
        /// <param name="despesas">A lista de despesas associadas ao condomínio.</param>
        /// <param name="imoveis">A lista de imóveis associados ao condomínio.</param>
        /// <param name="proprietarios">A lista de proprietários associados ao condomínio.</param>
        /// <param name="reunioes">A lista de reuniões agendadas no condomínio.</param>
        /// <param name="documentos">A lista de documentos associados ao condomínio.</param>
        /// <returns>Instância válida de Condominio ou null se os parâmetros forem inválidos.</returns>
        public Condominio CriarCondominio(string nome, string endereco, List<string> despesas, List<string> imoveis, List<string> proprietarios, List<string> reunioes, List<string> documentos)
        {
            // Lógica de validação aqui...

            // Se a lógica de validação passar, crie e retorne uma nova instância de Condominio
            Condominio condominio = new Condominio(nome, endereco, despesas, imoveis, proprietarios, reunioes, documentos);

            return condominio;
        }

        // Adicione outras regras de negócio conforme necessário...
    }

    /// <summary>
    /// Representa um condomínio no contexto do sistema.
    /// </summary>
    public class Condominio
    {
        #region Atributos

        /// <summary>
        /// Obtém ou define o nome do condomínio.
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Obtém ou define o endereço do condomínio.
        /// </summary>
        public string Endereco { get; set; }

        /// <summary>
        /// Obtém ou define a lista de despesas associadas ao condomínio.
        /// </summary>
        public List<string> Despesas { get; set; }

        /// <summary>
        /// Obtém ou define a lista de imóveis associados ao condomínio.
        /// </summary>
        public List<string> Imoveis { get; set; }

        /// <summary>
        /// Obtém ou define a lista de proprietários associados ao condomínio.
        /// </summary>
        public List<string> Proprietarios { get; set; }

        /// <summary>
        /// Obtém ou define a lista de reuniões agendadas no condomínio.
        /// </summary>
        public List<string> Reunioes { get; set; }

        /// <summary>
        /// Obtém ou define a lista de documentos associados ao condomínio.
        /// </summary>
        public List<string> Documentos { get; set; }

        #endregion

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


        }
