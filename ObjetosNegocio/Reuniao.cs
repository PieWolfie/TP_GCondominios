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
using System.Runtime.Serialization.Formatters.Binary;


namespace ObjetosNegocio
{
    [Serializable()]
    public class Reuniao : ISerializable
    {
        #region Atributos

        // Data da reunião
        private DateTime data;

        // Hora da reunião
        private TimeSpan hora;

        // Local da reunião
        private string local;

        // Lista de intervenientes na reunião
        private List<string> intervenientes;

        // Ata da reunião
        private string ata;

        #endregion

        #region Construtores

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

        #region ISerializable

        // Adicione este método para suportar serialização
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Data", Data);
            info.AddValue("Hora", Hora);
            info.AddValue("Local", Local);
            info.AddValue("Intervenientes", Intervenientes);
            info.AddValue("Ata", Ata);
        }

        // Adicione este construtor para suportar desserialização
        public Reuniao(SerializationInfo info, StreamingContext context)
        {
            Data = (DateTime)info.GetValue("Data", typeof(DateTime));
            Hora = (TimeSpan)info.GetValue("Hora", typeof(TimeSpan));
            Local = (string)info.GetValue("Local", typeof(string));
            Intervenientes = (List<string>)info.GetValue("Intervenientes", typeof(List<string>));
            Ata = (string)info.GetValue("Ata", typeof(string));
        }

        #endregion
    }
}
