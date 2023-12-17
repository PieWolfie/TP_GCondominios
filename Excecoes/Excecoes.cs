/*
 * 
 * Classe "Excecoes" - Excecoes
 * Fábio Fernandes - a22996@alunos.ipca.pt
 * Pedro Rocha - a23009@alunos.ipca.pt
 * LESI - POO
 * 
 */

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;


namespace Excecoes
{
    /// <summary>
    /// Exceção base para o domínio de Condomínio.
    /// </summary>
    public class CondominioException : Exception
    {
        public CondominioException(string message) : base(message)
        {

        }

        /// <summary>
        /// Exceção lançada quando o nome do condomínio é nulo ou vazio.
        /// </summary>
        public class NomeCondominioNuloOuVazioException : CondominioException
        {
            public NomeCondominioNuloOuVazioException() : base("O nome do condomínio não pode ser nulo ou vazio.")
            {

            }
        }

        /// <summary>
        /// Exceção lançada quando o endereço do condomínio é nulo ou vazio.
        /// </summary>
        public class EnderecoCondominioNuloOuVazioException : CondominioException
        {
            public EnderecoCondominioNuloOuVazioException() : base("O endereço do condomínio não pode ser nulo ou vazio.")
            {

            }
        }

        /// <summary>
        /// Exceção lançada quando a lista de despesas associadas ao condomínio está vazia.
        /// </summary>
        public class DespesasCondominioVaziasException : CondominioException
        {
            public DespesasCondominioVaziasException() : base("A lista de despesas associadas ao condomínio não pode estar vazia.")
            {

            }
        }

        /// <summary>
        /// Exceção lançada quando a lista de imóveis associados ao condomínio está vazia.
        /// </summary>
        public class ImoveisCondominioVaziosException : CondominioException
        {
            public ImoveisCondominioVaziosException() : base("A lista de imóveis associados ao condomínio não pode estar vazia.")
            {

            }
        }

        /// <summary>
        /// Exceção lançada quando a lista de proprietários associados ao condomínio está vazia.
        /// </summary>
        public class ProprietariosCondominioVaziosException : CondominioException
        {
            public ProprietariosCondominioVaziosException() : base("A lista de proprietários associados ao condomínio não pode estar vazia.")
            {

            }
        }

        /// <summary>
        /// Exceção lançada quando a lista de reuniões agendadas no condomínio está vazia.
        /// </summary>
        public class ReunioesCondominioVaziasException : CondominioException
        {
            public ReunioesCondominioVaziasException() : base("A lista de reuniões agendadas no condomínio não pode estar vazia.")
            {

            }
        }

        /// <summary>
        /// Exceção lançada quando a lista de documentos associados ao condomínio está vazia.
        /// </summary>
        public class DocumentosCondominioVaziosException : CondominioException
        {
            public DocumentosCondominioVaziosException() : base("A lista de documentos associados ao condomínio não pode estar vazia.")
            {

            }
        }
    }

    /// <summary>
    /// Exceção base para o domínio de Documento.
    /// </summary>
    public class DocumentoException : Exception
    {
        public DocumentoException(string message) : base(message)
        {

        }

        /// <summary>
        /// Exceção lançada quando o tipo do documento é nulo ou vazio.
        /// </summary>
        public class TipoDocumentoNuloOuVazioException : DocumentoException
        {
            public TipoDocumentoNuloOuVazioException() : base("O tipo do documento não pode ser nulo ou vazio.")
            {

            }
        }

        /// <summary>
        /// Exceção lançada quando o nome do documento é nulo ou vazio.
        /// </summary>
        public class NomeDocumentoNuloOuVazioException : DocumentoException
        {
            public NomeDocumentoNuloOuVazioException() : base("O nome do documento não pode ser nulo ou vazio.")
            {

            }
        }

        /// <summary>
        /// Exceção lançada quando o conteúdo do documento é nulo ou vazio.
        /// </summary>
        public class ConteudoDocumentoNuloOuVazioException : DocumentoException
        {
            public ConteudoDocumentoNuloOuVazioException() : base("O conteúdo do documento não pode ser nulo ou vazio.")
            {

            }
        }
    }

    /// <summary>
    /// Exceção base para o domínio de Reunião.
    /// </summary>
    public class ReuniaoException : Exception
    {
        public ReuniaoException(string message) : base(message)
        {

        }

        /// <summary>
        /// Exceção lançada quando a data da reunião está no passado.
        /// </summary>
        public class DataReuniaoInvalidaException : ReuniaoException
        {
            public DataReuniaoInvalidaException() : base("A data da reunião não pode estar no passado.")
            {

            }
        }

        /// <summary>
        /// Exceção lançada quando a hora da reunião é inválida.
        /// </summary>
        public class HoraReuniaoInvalidaException : ReuniaoException
        {
            public HoraReuniaoInvalidaException() : base("A hora da reunião é inválida.")
            {

            }
        }

        /// <summary>
        /// Exceção lançada quando o local da reunião é nulo ou vazio.
        /// </summary>
        public class LocalReuniaoNuloOuVazioException : ReuniaoException
        {
            public LocalReuniaoNuloOuVazioException() : base("O local da reunião não pode ser nulo ou vazio.")
            {

            }
        }

        /// <summary>
        /// Exceção lançada quando a lista de intervenientes na reunião está vazia.
        /// </summary>
        public class IntervenientesReuniaoVaziosException : ReuniaoException
        {
            public IntervenientesReuniaoVaziosException() : base("A lista de intervenientes na reunião não pode estar vazia.")
            {

            }
        }
    }

    /// <summary>
    /// Exceção base para o domínio de Proprietário.
    /// </summary>
    public class ProprietarioException : Exception
    {
        public ProprietarioException(string message) : base(message)
        {

        }

        /// <summary>
        /// Exceção lançada quando o nome do proprietário é nulo ou vazio.
        /// </summary>
        public class NomeProprietarioNuloOuVazioException : ProprietarioException
        {
            public NomeProprietarioNuloOuVazioException() : base("O nome do proprietário não pode ser nulo ou vazio.")
            {

            }
        }

        /// <summary>
        /// Exceção lançada quando o contato do proprietário é nulo ou vazio.
        /// </summary>
        public class ContatoProprietarioNuloOuVazioException : ProprietarioException
        {
            public ContatoProprietarioNuloOuVazioException() : base("O contato do proprietário não pode ser nulo ou vazio.")
            {

            }
        }

        /// <summary>
        /// Exceção lançada quando o imóvel associado ao proprietário é nulo ou vazio.
        /// </summary>
        public class ImovelProprietarioNuloOuVazioException : ProprietarioException
        {
            public ImovelProprietarioNuloOuVazioException() : base("O imóvel associado ao proprietário não pode ser nulo ou vazio.")
            {

            }
        }

        /// <summary>
        /// Exceção lançada quando o NIF do proprietário é nulo ou vazio.
        /// </summary>
        public class NifProprietarioNuloOuVazioException : ProprietarioException
        {
            public NifProprietarioNuloOuVazioException() : base("O NIF do proprietário não pode ser nulo ou vazio.")
            {

            }
        }
    }

    /// <summary>
    /// Exceção base para o domínio de Despesa.
    /// </summary>
    public class DespesaException : Exception
    {
        public DespesaException(string message) : base(message)
        {

        }

        /// <summary>
        /// Exceção lançada quando o tipo da despesa é nulo ou vazio.
        /// </summary>
        public class TipoDespesaNuloOuVazioException : DespesaException
        {
            public TipoDespesaNuloOuVazioException() : base("O tipo da despesa não pode ser nulo ou vazio.")
            {

            }
        }

        /// <summary>
        /// Exceção lançada quando o imóvel associado à despesa é nulo ou vazio.
        /// </summary>
        public class ImovelDespesaNuloOuVazioException : DespesaException
        {
            public ImovelDespesaNuloOuVazioException() : base("O imóvel associado à despesa não pode ser nulo ou vazio.")
            {

            }
        }

        /// <summary>
        /// Exceção lançada quando o valor da despesa é inválido (deve ser maior que zero).
        /// </summary>
        public class ValorDespesaInvalidoException : DespesaException
        {
            public ValorDespesaInvalidoException() : base("O valor da despesa deve ser maior que zero.")
            {

            }
        }

        /// <summary>
        /// Exceção lançada quando a data de vencimento da despesa é no passado.
        /// </summary>
        public class DataVencimentoDespesaPassadaException : DespesaException
        {
            public DataVencimentoDespesaPassadaException() : base("A data de vencimento da despesa não pode ser no passado.")
            {

            }
        }
    }

    /// <summary>
    /// Exceção base para o domínio de Imóvel.
    /// </summary>
    public class ImovelException : Exception
    {
        public ImovelException(string message) : base(message)
        {

        }

        /// <summary>
        /// Exceção lançada quando a lista de despesas associadas ao imóvel está vazia.
        /// </summary>
        public class DespesasImovelVaziasException : ImovelException
        {
            public DespesasImovelVaziasException() : base("A lista de despesas associadas ao imóvel não pode estar vazia.")
            {

            }
        }

        /// <summary>
        /// Exceção lançada quando a lista de proprietários associados ao imóvel está vazia.
        /// </summary>
        public class ProprietariosImovelVaziosException : ImovelException
        {
            public ProprietariosImovelVaziosException() : base("A lista de proprietários associados ao imóvel não pode estar vazia.")
            {

            }
        }

        /// <summary>
        /// Exceção lançada quando a lista de quotas associadas ao imóvel está vazia.
        /// </summary>
        public class QuotasImovelVaziasException : ImovelException
        {
            public QuotasImovelVaziasException() : base("A lista de quotas associadas ao imóvel não pode estar vazia.")
            {

            }
        }

        /// <summary>
        /// Exceção lançada quando o endereço do imóvel é nulo ou vazio.
        /// </summary>
        public class EnderecoImovelNuloOuVazioException : ImovelException
        {
            public EnderecoImovelNuloOuVazioException() : base("O endereço do imóvel não pode ser nulo ou vazio.")
            {

            }
        }
    }
}