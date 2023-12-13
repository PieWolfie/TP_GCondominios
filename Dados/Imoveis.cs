﻿/*
 * 
 * Classe "Imoveis" - Dados
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
    /// Classe responsável por armazenar e gerenciar informações sobre imóveis.
    /// </summary>
    public class Imoveis
    {
        #region Atributos

        private List<ObjetosNegocio.Imovel> listaImoveis;

        #endregion

        #region Métodos

        #region Construtores

        /// <summary>
        /// Inicializa uma nova instância da classe Imoveis.
        /// </summary>
        public Imoveis()
        {
            listaImoveis = new List<ObjetosNegocio.Imovel>();
        }

        #endregion

        #region Propriedades
        #endregion

        #region Outros Métodos

        /// <summary>
        /// Adiciona um novo imóvel à lista.
        /// </summary>
        /// <param name="imovel">O imóvel a ser adicionado.</param>
        public void AdicionarImovel(ObjetosNegocio.Imovel imovel)
        {
            listaImoveis.Add(imovel);
        }

        /// <summary>
        /// Obtém a lista de todos os imóveis.
        /// </summary>
        /// <returns>A lista de imóveis.</returns>
        public List<ObjetosNegocio.Imovel> ObterImoveis()
        {
            return listaImoveis;
        }

        /// <summary>
        /// Obtém um imóvel com base no identificador único.
        /// </summary>
        /// <param name="idImovel">O identificador único do imóvel.</param>
        /// <returns>O imóvel correspondente ou null se não encontrado.</returns>
        public ObjetosNegocio.Imovel? ObterImovelPorId(int idImovel)
        {
            return listaImoveis.Find(imovel => imovel.IdImovel == idImovel);
        }

        #endregion

        #endregion
    }
}

