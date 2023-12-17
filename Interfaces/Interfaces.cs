/*
 * 
 * Interfaces
 * Fábio Fernandes - a22996@alunos.ipca.pt
 * Pedro Rocha - a23009@alunos.ipca.pt
 * LESI - POO
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IProprietario
    {
        /// <summary>
        /// Obtém ou define o nome do proprietário.
        /// </summary>
        string Nome { get; set; }

        /// <summary>
        /// Obtém ou define o número de telefone do proprietário.
        /// </summary>
        string Contato { get; set; }

        /// <summary>
        /// Obtém ou define o identificador único do imóvel do proprietário.
        /// </summary>
        string Imovel { get; set; }

        /// <summary>
        /// Obtém ou define o número de identificação fiscal do proprietário.
        /// </summary>
        string Nif { get; set; }
    }

    public interface IDespesa
    {
        /// <summary>
        /// Obtém ou define o tipo da despesa.
        /// </summary>
        string Tipo { get; set; }
        /// <summary>
        /// Obtém ou define o valor da despesa.
        ///  </summary>
        decimal Valor { get; set; }

        /// <summary>
        /// Obtém ou define a data de vencimento da despesa.
        /// </summary>
        DateTime DataVencimento { get; set; }

        /// <summary>
        /// Obtém ou define o estado de pagamento da despesa.
        /// </summary>
        bool EstadoPagamento { get; set; }

        /// <summary>
        /// Obtém ou define o imóvel associado à despesa.
        ///  </summary>
        string Imovel { get; set; }
    }

    public interface IImovel
    {
        /// <summary>
        /// Obtém ou define o identificador único do imóvel.
        /// </summary>
        int IdImovel { get; set; }

        /// <summary>
        /// Obtém ou define a lista de proprietários associados ao imóvel.
        /// </summary>
        List<IProprietario> Proprietarios { get; set; }

        /// <summary>
        /// Obtém ou define a lista de despesas associadas ao imóvel.
        /// </summary>
        List<IDespesa> Despesas { get; set; }

        /// <summary>
        /// Obtém ou define a lista de quotas associadas ao imóvel.
        /// </summary>
        List<decimal> Quotas { get; set; }

        /// <summary>
        /// Obtém ou define o endereço associado ao imóvel.
        /// </summary>
        string Endereco { get; set; }
    }

    public interface ICondominio
    {
        /// <summary>
        /// Obtém ou define o nome do condomínio.
        /// </summary>
        string Nome { get; set; }

        /// <summary>
        /// Obtém ou define o endereço do condomínio.
        /// </summary>
        string Endereco { get; set; }

        /// <summary>
        /// Obtém ou define a lista de despesas associadas ao condomínio.
        /// </summary>
        List<IDespesa> Despesas { get; set; }

        /// <summary>
        /// Obtém ou define a lista de imóveis associados ao condomínio.
        /// </summary>
        List<IImovel> Imoveis { get; set; }

        /// <summary>
        /// Obtém ou define a lista de proprietários associados ao condomínio.
        /// </summary>
        List<IProprietario> Proprietarios { get; set; }

        /// <summary>
        /// Obtém ou define a lista de reuniões agendadas no condomínio.
        /// </summary>
        List<IReuniao> Reunioes { get; set; }

        /// <summary>
        /// Obtém ou define a lista de documentos associados ao condomínio.
        /// </summary>
        List<IDocumento> Documentos { get; set; }
    }

    public interface IDocumento
    {
        /// <summary>
        /// Obtém ou define o nome do documento.
        /// </summary>
        string Nome { get; set; }

        /// <summary>
        /// Obtém ou define o tipo do documento.
        /// </summary>
        string Tipo { get; set; }

        /// <summary>
        /// Obtém ou define o conteúdo do documento.
        /// </summary>
        string Conteudo { get; set; }
    }

    public interface IReuniao
    {
        /// <summary>
        /// Obtém ou define a data da reunião.
        /// </summary>
        DateTime Data { get; set; }

        /// <summary>
        /// Obtém ou define a hora da reunião.
        /// </summary>
        TimeSpan Hora { get; set; }

        /// <summary>
        /// Obtém ou define o local da reunião.
        /// </summary>
        string Local { get; set; }

        /// <summary>
        /// Obtém ou define a lista de intervenientes na reunião.
        /// </summary>
        List<string> Intervenientes { get; set; }
    }
}
