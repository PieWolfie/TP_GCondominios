/*
 * 
 * Classe "Proprietarios" - Dados
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
using ObjetosNegocio;

namespace Dados
{
    /// <summary>
    /// Classe responsável por armazenar e gerenciar informações sobre proprietários.
    /// </summary>
    public class Proprietarios
    {
        #region Atributos
        //É uma lista privada pois armazena os proprietários.
        private List<Proprietario> listaProprietarios;

        #endregion

        #region Métodos

        #region Contrutores
        /// <summary> 
        /// Construtor padrão que inicializa a lista de proprietários.
        /// </summary>
        public Proprietarios()
        {
            listaProprietarios = new List<Proprietario>();
        }
        #endregion

        #region Propriedades
        #endregion

        #region Overrides
        #endregion

        #region Outros Métodos
        /// <summary>
        /// Adiciona um novo proprietário à lista.
        /// </summary>
        /// <param name="proprietario">O proprietário a ser adicionado.</param>
        public void AdicionarProprietario(Proprietario proprietario)
        {
            listaProprietarios.Add(proprietario);
        }

        /// <summary>
        /// Obtém uma cópia da lista de proprietários.
        /// </summary>
        /// <returns>Lista de proprietários.</returns>
        public List<Proprietario> ObterProprietarios()
        {
            //Retorna uma cópia da lista para evitar modificações externas.
            return new List<Proprietario>(listaProprietarios);
        }

        /// <summary>
        /// Registra a presença de um proprietário em uma reunião.
        /// </summary>
        /// <param name="proprietario">O proprietário que está presente na reunião.</param>
        public void PresenciarReuniao(Proprietario proprietario)
        {
            proprietario.PresenciarReuniao();
        }

        #endregion

        #endregion
    }
}