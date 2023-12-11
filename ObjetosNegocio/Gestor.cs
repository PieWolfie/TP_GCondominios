using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosNegocio
{
    internal class Gestor
    {
        #region Atributos
        public int CondominioSelecionado { get; set; }
        #endregion

        #region Métodos

        #region Construtores
        #endregion

        #region Propriedades
        #endregion

        #region Overrides   
        #endregion

        #region Outros métodos
        public void ListaCondominios()
        {
            foreach (var condominio in Condominios)
            {
                Console.WriteLine(condominio);
            }
        }

        public void AdicionarCondominio()
        {
            //
        }

        public void RemoverCondominio()
        {
            //
        }

        public void SelecionarCondominio()
        {
            //
        }

        public void Pagamentos()
        {
            //
        }

        public void MarcarReunioes()
        {
            //
        }

        public void RemoverReunioes()
        {
            //
        }

        public void AdicionarDocumentos()
        {
            //
        }

        public void RemoverDocumentos()
        {
            //  
        }

        #endregion
        
        #endregion  
    }
}
