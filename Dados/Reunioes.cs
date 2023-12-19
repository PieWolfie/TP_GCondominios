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
using ObjetosNegocio;
using Excecoes;
using RegrasNegocio;
using System.IO;
using System.Text.Json;

namespace Dados
{
    /// <summary>
    /// Classe responsável por armazenar e gerenciar informações sobre reuniões.
    /// </summary>
    public class Reunioes
    {
        #region Atributos

        // Lista de reuniões
        private List<Reuniao> listaReunioes;

        #endregion

        #region Métodos

        #region Construtores

        /// <summary>
        /// Inicializa uma nova instância da classe Reuniões.
        /// </summary>
        public Reunioes()
        {
            listaReunioes = new List<Reuniao>();
        }

        #endregion

        #region Propriedades
        #endregion

        #region Outros Métodos

        /// <summary>
        /// Adiciona uma nova reunião à lista.
        /// </summary>
        /// <param name="reuniao">A reunião a ser adicionada.</param>
        /// <param name="lancaExcecao">Indica se deve lançar uma exceção em caso de reunião duplicada.</param>
        /// <exception cref="ReuniaoException.ReuniaoDuplicadaException">Lançada em caso de reunião duplicada.</exception>
        public void AdicionarReuniao(Reuniao reuniao, bool lancaExcecao = false)
        {
            if (!listaReunioes.Contains(reuniao))
            {
                if (lancaExcecao)
                {
                    throw new ReuniaoException.ReuniaoDuplicadaException(reuniao.Data, reuniao.Hora);
                }
            }
            else
            {
                ReuniaoRegras.ValidarReuniao(reuniao);
                listaReunioes.Add(reuniao);
            }
        }

        /// <summary>
        /// Obtém a lista de todas as reuniões.
        /// </summary>
        /// <returns>A lista de reuniões.</returns>
        public List<Reuniao> ObterReunioes()
        {
            return listaReunioes;
        }

        /// <summary>
        /// Obtém uma reunião com base na data e hora.
        /// </summary>
        /// <param name="data">A data da reunião.</param>
        /// <param name="hora">A hora da reunião.</param>
        /// <returns>A reunião correspondente ou null se não encontrada.</returns>
        public Reuniao? ObterReuniao(DateTime data, TimeSpan hora)
        {
            return listaReunioes.Find(r => r.Data == data && r.Hora == hora);
        }

        /// <summary>
        /// Grava a lista de reuniões em um arquivo usando serialização JSON.
        /// </summary>
        /// <param name="caminhoArquivo">O caminho do arquivo para salvar.</param>
        /// <exception cref="ReuniaoException.GravarReunioesException">Lançada em caso de erro ao gravar reuniões.</exception>
        public void GravarReunioes(string caminhoArquivo)
        {
            try
            {
                string jsonString = JsonSerializer.Serialize(listaReunioes);
                File.WriteAllText(caminhoArquivo, jsonString);
            }
            catch (Exception ex)
            {
                throw new ReuniaoException.GravarReunioesException(ex.Message);
            }
        }

        /// <summary>
        /// Carrega a lista de reuniões a partir de um arquivo usando desserialização JSON.
        /// </summary>
        /// <param name="caminhoArquivo">O caminho do arquivo para carregar.</param>
        /// <exception cref="ReuniaoException.CarregarReunioesException">Lançada em caso de erro ao carregar reuniões.</exception>
        public void CarregarReunioes(string caminhoArquivo)
        {
            try
            {
                string jsonString = File.ReadAllText(caminhoArquivo);
                listaReunioes = JsonSerializer.Deserialize<List<Reuniao>>(jsonString)!;
            }
            catch (Exception ex)
            {
                throw new ReuniaoException.CarregarReunioesException(ex.Message);
            }
        }

        #endregion

        #endregion
    }
}