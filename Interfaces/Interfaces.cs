using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IProprietario
    {
        #region Propriedades

        /// <summary>
        /// Obtém ou define o nome do proprietário.
        /// </summary>
        string Nome { get; set; }

        /// <summary>
        /// Obtém ou define o número de telefone do proprietário.
        /// </summary>
        string Telefone { get; set; }

        /// <summary>
        /// Obtém ou define o endereço de email do proprietário.
        /// </summary>
        string Email { get; set; }

        /// <summary>
        /// Obtém ou define o endereço do proprietário.
        /// </summary>
        string Endereco { get; set; }

        /// <summary>
        /// Obtém ou define o número de identificação fiscal do proprietário.
        /// </summary>
        string NIF { get; set; }

        #endregion
    }

    public interface IDespesa
    {
        #region Propriedades

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
        #endregion
    }

    public interface IImovel
    {
        #region Propriedades

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

        #endregion
    }

    public interface ICondominio
    {
        #region Propriedades

        /// <summary>
        /// Obtém ou define o nome do condomínio.
        ///  </summary>
        string Nome { get; set; }

        /// <summary>
        /// Obtém ou define a lista de imóveis associados ao condomínio.
        /// </summary>
        List<IImovel> Imoveis { get; set; }
        #endregion
    }

    public interface IDocumento
    {
        #region Propriedades

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
        byte[] Conteudo { get; set; }

        /// <summary>
        /// Obtém ou define o imóvel associado ao documento.
        /// </summary>
        string Imovel { get; set; }
        #endregion
    }

    public interface IReuniao
    {
        #region Propriedades

        /// <summary>
        /// Obtém ou define a data da reunião.
        /// </summary>
        DateTime Data { get; set; }

        /// <summary>
        /// Obtém ou define a lista de documentos associados à reunião.
        /// </summary>
        List<IDocumento> Documentos { get; set; }
        #endregion
    }
}
