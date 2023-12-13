/*
 * 
 * Classe "Condominios" - Dados
 * Fábio Fernandes - a22996@alunos.ipca.pt
 * Pedro Rocha - a23009@alunos.ipca.pt
 * LESI - POO
 * 
 */

using System;
using System.Collections.Generic;
using ObjetosNegocio;

namespace Dados
{
    /// <summary>
    /// Classe responsável por armazenar e gerenciar informações sobre condomínios.
    /// </summary>
    public class Condominios
    {
        #region Atributos

        private List<ObjetosNegocio.Condominio> listaCondominios;

        #endregion

        #region Métodos

        #region Construtores

        /// <summary>
        /// Inicializa uma nova instância da classe Condominios.
        /// </summary>
        public Condominios()
        {
            listaCondominios = new List<ObjetosNegocio.Condominio>();
        }

        #endregion

        #region Propriedades
        #endregion

<<<<<<< HEAD
<<<<<<< HEAD
=======
        #region Overrides
        #endregion

>>>>>>> Criação das classes da camada de Dados
=======
        #region Overrides
        #endregion

>>>>>>> Classe exceções terminada
        #region Outros Métodos

        /// <summary>
        /// Adiciona um novo condomínio à lista.
        /// </summary>
        /// <param name="condominio">O condomínio a ser adicionado.</param>
        public void AdicionarCondominio(ObjetosNegocio.Condominio condominio)
        {
            listaCondominios.Add(condominio);
        }

        /// <summary>
        /// Obtém a lista de todos os condomínios.
        /// </summary>
        /// <returns>A lista de condomínios.</returns>
        public List<ObjetosNegocio.Condominio> ObterCondominios()
        {
            return listaCondominios;
        }

        /// <summary>
        /// Obtém um condomínio com base no nome.
        /// </summary>
        /// <param name="nome">O nome do condomínio.</param>
        /// <returns>O condomínio correspondente ou null se não encontrado.</returns>
        public ObjetosNegocio.Condominio? ObterCondominioPorNome(string nome)
        {
            return listaCondominios.Find(condominio => condominio.Nome == nome);
        }

        #endregion

<<<<<<< HEAD
<<<<<<< HEAD
=======
        #region Destrutor
        #endregion

>>>>>>> Criação das classes da camada de Dados
=======
        #region Destrutor
        #endregion

>>>>>>> Classe exceções terminada
        #endregion
    }
}

