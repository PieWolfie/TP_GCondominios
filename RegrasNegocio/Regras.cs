/*
 * 
 * Classe "Regras" - Regras de Negócio
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
using Dados;
using ObjetosNegocio;
using Excecoes;

namespace RegrasNegocio
{
    public static class CondominioRegras
    {
        public static void ValidarCondominio(Condominio condominio)
        {
            if (string.IsNullOrWhiteSpace(condominio.Nome))
            {
                throw new CondominioException.NomeCondominioNuloOuVazioException();
            }

            if (string.IsNullOrWhiteSpace(condominio.Endereco))
            {
                throw new CondominioException.EnderecoCondominioNuloOuVazioException();
            }

            if (condominio.Despesas.Count == 0)
            {
                throw new CondominioException.DespesasCondominioVaziasException();
            }

            if (condominio.Imoveis.Count == 0)
            {
                throw new CondominioException.ImoveisCondominioVaziosException();
            }

            if (condominio.Proprietarios.Count == 0)
            {
                throw new CondominioException.ProprietariosCondominioVaziosException();
            }

            if (condominio.Reunioes.Count == 0)
            {
                throw new CondominioException.ReunioesCondominioVaziasException();
            }

            if (condominio.Documentos.Count == 0)
            {
                throw new CondominioException.DocumentosCondominioVaziosException();
            }
        }
    }

    public static class DespesaRegras
    {
        public static void ValidarDespesa(Despesa despesa)
        {
            if (string.IsNullOrWhiteSpace(despesa.Tipo))
            {
                throw new DespesaException.TipoDespesaNuloOuVazioException();
            }

            if (string.IsNullOrWhiteSpace(despesa.Imovel))
            {
                throw new DespesaException.ImovelDespesaNuloOuVazioException();
            }

            if (despesa.Valor <= 0)
            {
                throw new DespesaException.ValorDespesaInvalidoException();
            }

            if (despesa.DataVencimento < DateTime.Today)
            {
                throw new DespesaException.DataVencimentoDespesaPassadaException();
            }
        }
    }

    public static class ImovelRegras
    {
        public static void ValidarImovel(Imovel imovel)
        {
            if (string.IsNullOrWhiteSpace(imovel.Endereco))
            {
                throw new ImovelException.EnderecoImovelNuloOuVazioException();
            }

            if (imovel.Despesas.Count == 0)
            {
                throw new ImovelException.DespesasImovelVaziasException();
            }

            if (imovel.Proprietarios.Count == 0)
            {
                throw new ImovelException.ProprietariosImovelVaziosException();
            }
        }
    }

    public static class ProprietarioRegras
    {
        public static void ValidarProprietario(Proprietario proprietario)
        {
            if (string.IsNullOrWhiteSpace(proprietario.Nome))
            {
                throw new ProprietarioException.NomeProprietarioNuloOuVazioException();
            }

            if (string.IsNullOrWhiteSpace(proprietario.Contato))
            {
                throw new ProprietarioException.ContatoProprietarioNuloOuVazioException();
            }

            if (string.IsNullOrWhiteSpace(proprietario.Imovel))
            {
                throw new ProprietarioException.ImovelProprietarioNuloOuVazioException();
            }

            if (string.IsNullOrWhiteSpace(proprietario.Nif))
            {
                throw new ProprietarioException.NifProprietarioNuloOuVazioException();
            }
        }
    }

    public static class ReuniaoRegras
    {
        public static void ValidarReuniao(Reuniao reuniao)
        {
            if (reuniao.Data < DateTime.Now)
            {
                throw new ReuniaoException.DataReuniaoInvalidaException();
            }

            if (reuniao.Hora < TimeSpan.Zero || reuniao.Hora >= TimeSpan.FromDays(1))
            {
                throw new ReuniaoException.HoraReuniaoInvalidaException();
            }

            if (string.IsNullOrWhiteSpace(reuniao.Local))
            {
                throw new ReuniaoException.LocalReuniaoNuloOuVazioException();
            }

            if (reuniao.Intervenientes.Count == 0)
            {
                throw new ReuniaoException.IntervenientesReuniaoVaziosException();
            }
        }
    }

    public static class DocumentoRegras
    {
        public static void ValidarDocumento(Documento documento)
        {
            if (string.IsNullOrWhiteSpace(documento.Tipo))
            {
                throw new DocumentoException.TipoDocumentoNuloOuVazioException();
            }

            if (string.IsNullOrWhiteSpace(documento.Nome))
            {
                throw new DocumentoException.NomeDocumentoNuloOuVazioException();
            }

            if (string.IsNullOrWhiteSpace(documento.Conteudo))
            {
                throw new DocumentoException.ConteudoDocumentoNuloOuVazioException();
            }
        }
    }
}
