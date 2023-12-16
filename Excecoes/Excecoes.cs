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
using System.Text;
using System.Threading.Tasks;

namespace Excecoes
{
    public class CondominioException : Exception
    {
        public CondominioException(string message) : base(message) 
        {
        
        }

        public class NomeCondominioNuloOuVazioException : CondominioException
        {
            public NomeCondominioNuloOuVazioException() : base("O nome do condomínio não pode ser nulo ou vazio.") 
            { 
            
            }
        }

        public class EnderecoCondominioNuloOuVazioException : CondominioException
        {
            public EnderecoCondominioNuloOuVazioException() : base("O endereço do condomínio não pode ser nulo ou vazio.")
            {

            }
        }

        public class DespesasCondominioVaziasException : CondominioException
        {
            public DespesasCondominioVaziasException() : base("A lista de despesas associadas ao condomínio não pode estar vazia.")
            {

            }
        }

        public class ImoveisCondominioVaziosException : CondominioException
        {
            public ImoveisCondominioVaziosException() : base("A lista de imóveis associados ao condomínio não pode estar vazia.")
            {

            }
        }

        public class ProprietariosCondominioVaziosException : CondominioException
        {
            public ProprietariosCondominioVaziosException() : base("A lista de proprietários associados ao condomínio não pode estar vazia.")
            {

            }
        }

        public class ReunioesCondominioVaziasException : CondominioException
        {
            public ReunioesCondominioVaziasException() : base("A lista de reuniões agendadas no condomínio não pode estar vazia.")
            {

            }
        }

        public class DocumentosCondominioVaziosException : CondominioException
        {
            public DocumentosCondominioVaziosException() : base("A lista de documentos associados ao condomínio não pode estar vazia.")
            {

            }
        }
    }

    public class DocumentoException : Exception
    {
        public DocumentoException(string message) : base(message)
        {

        }

        public class TipoDocumentoNuloOuVazioException : DocumentoException
        {
            public TipoDocumentoNuloOuVazioException() : base("O tipo do documento não pode ser nulo ou vazio.")
            {

            }
        }

        public class NomeDocumentoNuloOuVazioException : DocumentoException
        {
            public NomeDocumentoNuloOuVazioException() : base("O nome do documento não pode ser nulo ou vazio.")
            {

            }
        }

        public class ConteudoDocumentoNuloOuVazioException : DocumentoException
        {
            public ConteudoDocumentoNuloOuVazioException() : base("O conteúdo do documento não pode ser nulo ou vazio.")
            {

            }
        }
    }

    public class ReuniaoException : Exception
    {
        public ReuniaoException(string message) : base(message)
        {

        }

        public class DataReuniaoInvalidaException : ReuniaoException
        {
            public DataReuniaoInvalidaException() : base("A data da reunião não pode estar no passado.")
            {

            }
        }

        public class HoraReuniaoInvalidaException : ReuniaoException
        {
            public HoraReuniaoInvalidaException() : base("A hora da reunião é inválida.")
            {

            }
        }

        public class LocalReuniaoNuloOuVazioException : ReuniaoException
        {
            public LocalReuniaoNuloOuVazioException() : base("O local da reunião não pode ser nulo ou vazio.")
            {

            }
        }

        public class IntervenientesReuniaoVaziosException : ReuniaoException
        {
            public IntervenientesReuniaoVaziosException() : base("A lista de intervenientes na reunião não pode estar vazia.")
            {

            }
        }
    }

    public class ProprietarioException : Exception
    {
        public ProprietarioException(string message) : base(message)
        {

        }

        public class NomeProprietarioNuloOuVazioException : ProprietarioException
        {
            public NomeProprietarioNuloOuVazioException() : base("O nome do proprietário não pode ser nulo ou vazio.")
            {

            }
        }

        public class ContatoProprietarioNuloOuVazioException : ProprietarioException
        {
            public ContatoProprietarioNuloOuVazioException() : base("O contato do proprietário não pode ser nulo ou vazio.")
            {

            }
        }

        public class ImovelProprietarioNuloOuVazioException : ProprietarioException
        {
            public ImovelProprietarioNuloOuVazioException() : base("O imóvel associado ao proprietário não pode ser nulo ou vazio.")
            {

            }
        }

        public class NifProprietarioNuloOuVazioException : ProprietarioException
        {
            public NifProprietarioNuloOuVazioException() : base("O NIF do proprietário não pode ser nulo ou vazio.")
            {

            }
        }
    }

    public class DespesaException : Exception
    {
        public DespesaException(string message) : base(message)
        {

        }

        public class TipoDespesaNuloOuVazioException : DespesaException
        {
            public TipoDespesaNuloOuVazioException() : base("O tipo da despesa não pode ser nulo ou vazio.")
            {

            }
        }

        public class ImovelDespesaNuloOuVazioException : DespesaException
        {
            public ImovelDespesaNuloOuVazioException() : base("O imóvel associado à despesa não pode ser nulo ou vazio.")
            {

            }
        }

        public class ValorDespesaInvalidoException : DespesaException
        {
            public ValorDespesaInvalidoException() : base("O valor da despesa deve ser maior que zero.")
            {

            }
        }

        public class DataVencimentoDespesaPassadaException : DespesaException
        {
            public DataVencimentoDespesaPassadaException() : base("A data de vencimento da despesa não pode ser no passado.")
            {

            }
        }
    }

    public class ImovelException : Exception
    {
        public ImovelException(string message) : base(message)
        {

        }

        public class DespesasImovelVaziasException : ImovelException
        {
            public DespesasImovelVaziasException() : base("A lista de despesas associadas ao imóvel não pode estar vazia.")
            {

            }
        }

        public class ProprietariosImovelVaziosException : ImovelException
        {
            public ProprietariosImovelVaziosException() : base("A lista de proprietários associados ao imóvel não pode estar vazia.")
            {

            }
        }
    }
}