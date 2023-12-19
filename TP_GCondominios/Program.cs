/*
 * 
 * Classe "Program" - Gestão de Condomínios
 * Fábio Fernandes - a22996@alunos.ipca.pt
 * Pedro Rocha - a23009@alunos.ipca.pt
 * LESI - POO
 * 
 */

using RegrasNegocio;
using ObjetosNegocio;
using Excecoes;
using System;

class Program
{
    static void Main()
    {
        // Criar condominio usando os dados fornecidos
        var condominio = new Condominio
        {
            Nome = "Condomínio A",
            Endereco = "Endereço 123"
        };

        // Criar proprietário usando os dados fornecidos
        var proprietario = new Proprietario
        {
            Nome = "João Silva",
            Contato = "987654321",
            Imovel = "Apartamento 101",
            Nif = "123456789"
        };

        // Criar imóvel usando os dados fornecidos
        var imovel = new Imovel { Endereco = "Rua ABC, 456" };

        // Criar despesa usando os dados fornecidos
        var despesa = new Despesa
        {
            Tipo = "Manutenção",
            Valor = 150.50m,
            DataVencimento = DateTime.Now.AddDays(30),
            EstadoPagamento = false,
            Imovel = "Apartamento 101"
        };

        // Criar reuniao usando os dados fornecidos
        var reuniao = new Reuniao
        {
            Data = DateTime.Now.AddDays(7),
            Hora = new TimeSpan(14, 30, 0),
            Local = "Sala de Condomínio",
            Intervenientes = new System.Collections.Generic.List<string> { "Membro1", "Membro2" }
        };

        // Criar documento usando os dados fornecidos
        var documento = new Documento
        {
            Nome = "Regulamento Interno",
            Tipo = "PDF",
            Conteudo = "Conteúdo do regulamento..."
        };

        try
        {
            // Validar e executar as regras de negócio para cada objeto
            ValidarEExecutar(() => CondominioRegras.ValidarCondominio(condominio));
            ValidarEExecutar(() => DespesaRegras.ValidarDespesa(despesa));
            ValidarEExecutar(() => ImovelRegras.ValidarImovel(imovel));
            ValidarEExecutar(() => ProprietarioRegras.ValidarProprietario(proprietario));
            ValidarEExecutar(() => ReuniaoRegras.ValidarReuniao(reuniao));
            ValidarEExecutar(() => DocumentoRegras.ValidarDocumento(documento));
        }
        catch (Exception ex)
        {
            // Tratar exceção genérica, se necessário
            Console.WriteLine($"Erro: {ex.Message}");
        }
    }

    /// <summary>
    /// Executa uma ação e trata exceções específicas de negócio.
    /// </summary>
    /// <param name="acao">Ação a ser executada.</param>
    static void ValidarEExecutar(Action acao)
    {
        try
        {
            acao.Invoke();
        }
        catch (CondominioException ex)
        {
            Console.WriteLine($"Erro de Condominio: {ex.Message}");
        }
        catch (DespesaException ex)
        {
            Console.WriteLine($"Erro de Despesa: {ex.Message}");
        }
        catch (ImovelException ex)
        {
            Console.WriteLine($"Erro de Imovel: {ex.Message}");
        }
        catch (ProprietarioException ex)
        {
            Console.WriteLine($"Erro de Proprietario: {ex.Message}");
        }
        catch (ReuniaoException ex)
        {
            Console.WriteLine($"Erro de Reuniao: {ex.Message}");
        }
        catch (DocumentoException ex)
        {
            Console.WriteLine($"Erro de Documento: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
    }
}