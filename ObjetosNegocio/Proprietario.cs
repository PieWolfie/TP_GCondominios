using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosNegocio
{
    internal class Proprietario
    {
        #region Attributes
        public string Nome { get; set; }
        public string Contato { get; set; }
        public string Imovel { get; set; }
        public string Nif { get; set; }
        public List<string> HistoricoPagamentos { get; private set; }
        public List<string> PresencasReunioes { get; private set; }

        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// Construtor predefinido.
        /// </summary>
        public Proprietario(string nome, string contato, string imovel, string nif)
        {
            Nome = nome;
            Contato = contato;
            Imovel = imovel;
            Nif = nif;
            HistoricoPagamentos = new List<string>();
            PresencasReunioes = new List<string>();
        }

        #endregion

        #region Properties
        #endregion

        #region Overrides
        #endregion

        #region OtherMethods

        public void RealizarPagamento(decimal valor)
        {
            string mensagem = $"Pagamento de {valor:C} realizado com sucesso em {DateTime.Now}.";
            HistoricoPagamentos.Add(mensagem);
            //Console.WriteLine(mensagem);
        }

        public void VisualizarHistorico()
        {
            //Console.WriteLine($"\n--- Histórico de pagamentos de {Nome} ---");
            foreach (string pagamento in HistoricoPagamentos)
            {
                //Console.WriteLine(pagamento);
            }
        }

        public void PresenciarReuniao()
        {
            string mensagem = $"Presença na reunião realizada em {DateTime.Now}.";
            PresencasReunioes.Add(mensagem);
            //Console.WriteLine(mensagem);
        }
        #endregion

        #region Destrutor
        ~Proprietario()
        {
            
        }
        #endregion

        #endregion
    }
}
