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

        /// <summary>
        /// Exceção lançada quando um condomínio duplicado é adicionado à lista.
        /// </summary>
        public class CondominioDuplicadoException : CondominioException
        {
            public CondominioDuplicadoException(string nome, string endereco) : base($"Condomínio com nome {nome} e endereço {endereco} já existe na lista.")
            {
            
            }
        }

        /// <summary>
        /// Exceção lançada ao ocorrer um erro durante a gravação de condomínios.
        /// </summary>
        public class GravarCondominiosException : CondominioException
        {
            public GravarCondominiosException(string message) : base($"Erro ao gravar condomínios: {message}")
            {

            }
        }

        /// <summary>
        /// Exceção lançada ao ocorrer um erro durante o carregamento de condomínios.
        /// </summary>
        public class CarregarCondominiosException : CondominioException
        {
            public CarregarCondominiosException(string message) : base($"Erro ao carregar condomínios: {message}")
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


        /// <summary>
        /// Exceção lançada quando um documento duplicado é adicionado à lista.
        /// </summary>
        public class DocumentoDuplicadoException : DocumentoException
        {
            public DocumentoDuplicadoException(string nome) : base($"Documento com nome '{nome}' já existe na lista.")
            {
            
            }
        }

        /// <summary>
        /// Exceção lançada ao ocorrer um erro durante a gravação de documentos.
        /// </summary>
        public class GravarDocumentosException : DocumentoException
        {
            public GravarDocumentosException(string message) : base($"Erro ao gravar documentos: {message}")
            {

            }
        }

        /// <summary>
        /// Exceção lançada ao ocorrer um erro durante o carregamento de documentos.
        /// </summary>
        public class CarregarDocumentosException : DocumentoException
        {
            public CarregarDocumentosException(string message) : base($"Erro ao carregar documentos: {message}")
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

        /// <summary>
        /// Exceção lançada quando uma reunião duplicada é adicionada à lista.
        /// </summary>
        public class ReuniaoDuplicadaException : ReuniaoException
        {
            public ReuniaoDuplicadaException(DateTime data, TimeSpan hora) : base($"Já existe uma reunião agendada para a data {data} e hora {hora}.")
            {
            
            }
        }

        /// <summary>
        /// Exceção lançada ao ocorrer um erro durante a gravação de reuniões.
        /// </summary>
        public class GravarReunioesException : ReuniaoException
        {
            public GravarReunioesException(string message) : base($"Erro ao gravar reuniões: {message}")
            {

            }
        }

        /// <summary>
        /// Exceção lançada ao ocorrer um erro durante o carregamento de reuniões.
        /// </summary>
        public class CarregarReunioesException : ReuniaoException
        {
            public CarregarReunioesException(string message) : base($"Erro ao carregar reuniões: {message}")
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

        /// <summary>
        /// Exceção lançada quando um proprietário duplicado é adicionado à lista.
        /// </summary>
        public class ProprietarioDuplicadoException : ProprietarioException
        {
            public ProprietarioDuplicadoException(string nif) : base($"Proprietário com NIF {nif} já existe na lista.")
            {
            
            }
        }

        /// <summary>
        /// Exceção lançada ao ocorrer um erro durante a gravação de proprietários.
        /// </summary>
        public class GravarProprietariosException : ProprietarioException
        {
            public GravarProprietariosException(string message) : base($"Erro ao gravar proprietários: {message}")
            {

            }
        }

        /// <summary>
        /// Exceção lançada ao ocorrer um erro durante o carregamento de proprietários.
        /// </summary>
        public class CarregarProprietariosException : ProprietarioException
        {
            public CarregarProprietariosException(string message) : base($"Erro ao carregar proprietários: {message}")
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

        /// <summary>
        /// Exceção lançada quando uma despesa duplicada é adicionada à lista.
        /// </summary>
        public class DespesaDuplicadaException : DespesaException
        {
            public DespesaDuplicadaException(string tipo, decimal valor, DateTime dataVencimento) : base($"Despesa do tipo {tipo} com valor {valor} e data de vencimento {dataVencimento.ToShortDateString()} já existe na lista.")
            {
            
            }
        }

        /// <summary>
        /// Exceção lançada ao ocorrer um erro durante a gravação de despesas.
        /// </summary>
        public class GravarDespesasException : DespesaException
        {
            public GravarDespesasException(string message) : base($"Erro ao gravar despesas: {message}")
            {

            }
        }

        /// <summary>
        /// Exceção lançada ao ocorrer um erro durante o carregamento de despesas.
        /// </summary>
        public class CarregarDespesasException : DespesaException
        {
            public CarregarDespesasException(string message) : base($"Erro ao carregar despesas: {message}")
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

        /// <summary>
        /// Exceção lançada quando um imóvel duplicado é adicionado à lista.
        /// </summary>
        public class ImovelDuplicadoException : ImovelException
        {
            public ImovelDuplicadoException(int idImovel) : base($"Imóvel com ID {idImovel} já existe na lista.")
            {

            }
        }

        /// <summary>
        /// Exceção lançada ao ocorrer um erro durante a gravação de imóveis.
        /// </summary>
        public class GravarImoveisException : ImovelException
        {
            public GravarImoveisException(string message) : base($"Erro ao gravar imóveis: {message}")
            {

            }
        }

        /// <summary>
        /// Exceção lançada ao ocorrer um erro durante o carregamento de imóveis.
        /// </summary>
        public class CarregarImoveisException : ImovelException
        {
            public CarregarImoveisException(string message) : base($"Erro ao carregar imóveis: {message}")
            {

            }
        }
    }
}