/*
 * 
 * Classe "Reuniao" - Objeto de Negócio
 * Fábio Fernandes - a22996@alunos.ipca.pt
 * Pedro Rocha - a23009@alunos.ipca.pt
 * LESI - POO
 * 
 */

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ObjetosNegocio
{   
    /// <summary>
    /// Representa uma reunião no contexto do sistema.
    /// </summary>
    [Serializable]
    public class Reuniao
    {
        #region Atributos

        /// <summary>
        /// Representa a data da reunião.
        /// </summary>
        private DateTime data;

        /// <summary>
        /// Representa a hora da reunião.
        /// </summary>
        private TimeSpan hora;

        /// <summary>
        /// Representa o local da reunião.
        /// </summary>
        private string local = string.Empty;

        /// <summary>
        /// Representa a lista de intervenientes na reunião.
        /// </summary>
        private List<string> intervenientes = new List<string>();

        /// <summary>
        /// Representa a ata da reunião.
        /// </summary>
        private string ata = string.Empty;

        #endregion

        #region Métodos

        #region Construtores

        /// <summary>
        /// Construtor padrão da classe Reuniao.
        /// </summary>
        public Reuniao()
        {
            intervenientes = new List<string>();
        }

        /// <summary>
        /// Inicializa uma nova instância da classe Reuniao com os parâmetros especificados.
        /// </summary>
        /// <param name="data">A data da reunião.</param>
        /// <param name="hora">A hora da reunião.</param>
        /// <param name="local">O local da reunião.</param>
        public Reuniao(DateTime data, TimeSpan hora, string local) : this()
        {
            Data = data;
            Hora = hora;
            Local = local;
        }

        #endregion

        #region Propriedades

        /// <summary>
        /// Obtém ou define a data da reunião.
        /// </summary>
        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }

        /// <summary>
        /// Obtém ou define a hora da reunião.
        /// </summary>
        public TimeSpan Hora
        {
            get { return hora; }
            set { hora = value; }
        }

        /// <summary>
        /// Obtém ou define o local da reunião.
        /// </summary>
        public string Local
        {
            get { return local; }
            set { local = value; }
        }

        /// <summary>
        /// Obtém ou define a lista de intervenientes na reunião.
        /// </summary>
        public List<string> Intervenientes
        {
            get { return intervenientes; }
            set { intervenientes = value; }
        }

        /// <summary>
        /// Obtém ou define a ata da reunião.
        /// </summary>
        public string Ata
        {
            get { return ata; }
            set { ata = value; }
        }

        #endregion

        #region Overrides
        #endregion

        #region Outros Métodos

        /// <summary>
        /// Agenda a reunião com a data, hora e local especificados.
        /// </summary>
        /// <param name="data">A data da reunião.</param>
        /// <param name="hora">A hora da reunião.</param>
        /// <param name="local">O local da reunião.</param>
        public void AgendarReuniao(DateTime data, TimeSpan hora, string local)
        {
            Data = data;
            Hora = hora;
            Local = local;
        }

        /// <summary>
        /// Adiciona um interveniente à lista de intervenientes na reunião.
        /// </summary>
        /// <param name="interveniente">O interveniente a ser adicionado.</param>
        public void AdicionarInterveniente(string interveniente)
        {
            Intervenientes.Add(interveniente);
        }

        /// <summary>
        /// Registra a ata da reunião.
        /// </summary>
        /// <param name="ata">A ata da reunião.</param>
        public void RegistarAta(string ata)
        {
            Ata = ata;
        }

        #endregion

        #region Destrutor
        #endregion

        #endregion
    }
}