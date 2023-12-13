/*
 * 
 * Classe "Reunioes" - Dados
 * Fábio Fernandes - a22996@alunos.ipca.pt
 * Pedro Rocha - a23009@alunos.ipca.pt
 * LESI - POO
 * 
 */

using System;
using System.Collections.Generic;

namespace Dados
{
    /// <summary>
    /// Classe responsável por armazenar e gerenciar informações sobre reuniões.
    /// </summary>
    public class Reunioes
    {
        #region Atributos

        private List<ObjetosNegocio.Reuniao> reunioes;

        #endregion

        #region Métodos

        #region Construtores

        /// <summary>
        /// Inicializa uma nova instância da classe Reunioes.
        /// </summary>
        public Reunioes()
        {
            reunioes = new List<ObjetosNegocio.Reuniao>();
        }

        #endregion

        #region Propriedades
        #endregion

        #region Outros Métodos

        /// <summary>
        /// Adiciona uma nova reunião à lista.
        /// </summary>
        /// <param name="reuniao">A reunião a ser adicionada.</param>
        public void AdicionarReuniao(ObjetosNegocio.Reuniao reuniao)
        {
            reunioes.Add(reuniao);
        }

        /// <summary>
        /// Obtém a lista de todas as reuniões.
        /// </summary>
        /// <returns>A lista de reuniões.</returns>
        public List<ObjetosNegocio.Reuniao> ObterReunioes()
        {
            return reunioes;
        }

        /// <summary>
        /// Obtém uma reunião com base na data e hora.
        /// </summary>
        /// <param name="data">A data da reunião.</param>
        /// <param name="hora">A hora da reunião.</param>
        /// <returns>A reunião correspondente ou null se não encontrada.</returns>
        public ObjetosNegocio.Reuniao? ObterReuniao(DateTime data, TimeSpan hora)
        {
            return reunioes.Find(r => r.Data == data && r.Hora == hora);
        }

        #endregion

        #endregion
    }
}


