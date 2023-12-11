using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosNegocio
{
    /// <summary>
    /// Representa uma reunião no contexto do sistema.
    /// </summary>
    public class Reuniao
    {
        #region Atributos

        /// <summary>
        /// Obtém ou define a data da reunião.
        /// </summary>
        public DateTime Data { get; set; }

        /// <summary>
        /// Obtém ou define a hora da reunião.
        /// </summary>
        public TimeSpan Hora { get; set; }

        /// <summary>
        /// Obtém ou define o local da reunião.
        /// </summary>
        public string Local { get; set; }

        /// <summary>
        /// Obtém ou define a lista de intervenientes na reunião.
        /// </summary>
        public List<string> Intervenientes { get; set; }

        /// <summary>
        /// Obtém ou define a ata da reunião.
        /// </summary>
        public string Ata { get; set; }

        #endregion

        #region Construtor

        /// <summary>
        /// Inicializa uma nova instância da classe Reuniao com os parâmetros especificados.
        /// </summary>
        /// <param name="data">A data da reunião.</param>
        /// <param name="hora">A hora da reunião.</param>
        /// <param name="local">O local da reunião.</param>
        public Reuniao(DateTime data, TimeSpan hora, string local)
        {
            Data = data;
            Hora = hora;
            Local = local;
            Intervenientes = new List<string>();
            Ata = string.Empty;
        }

        #endregion

        #region Métodos

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
    }
}

