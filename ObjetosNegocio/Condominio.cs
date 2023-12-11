using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosNegocio
{
    internal class Condominio
    {
        #region Attributes
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public List<string> Despesas { get; set; }
        public List<string> Imoveis { get; set; }
        public List<string> Proprietarios { get; set; }
        public List<string> Reunioes { get; set; }
        public List<string> Documentos { get; set; }

        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// Construtor predefinido.
        /// </summary>
        public Condominio(string nome, string endereco, List<string> despesas, List<string> imoveis, List<string> proprietarios, List<string> reunioes, List<string> documentos)
        {
            Nome = nome;
            Endereco = endereco;
            Despesas = despesas;
            Imoveis = imoveis;
            Proprietarios = proprietarios;
            Reunioes = reunioes;
            Documentos = documentos;

            Condominio meuCondominio = new Condominio("Nome do Condomínio", "Endereço do Condomínio", despesas, imoveis, proprietarios, reunioes, documentos);
        }

        #endregion

        #region Properties
        #endregion

        #region Overrides
        #endregion

        #region OtherMethods

        public void AdicionarDespesa(string despesa)
        {
            Despesas.Add(despesa);
        }

        public void AdicionarImovel(string imovel)
        {
            Imoveis.Add(imovel);
        }

        public void AdicionarProprietario(string proprietario)
        {
            Proprietarios.Add(proprietario);
        }

        public void AgendarReuniao(string reuniao)
        {
            Reunioes.Add(reuniao);
        }

        public void AdicionarDocumento(string documento)
        {
            Documentos.Add(documento);
        }
        #endregion

        #region Destrutor   
        ~Condominio()
        {

        }
        #endregion

        #endregion
    }
}
