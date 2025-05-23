﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutosApp.Domain.Entites
{
    ///<summary>
    /// Modelo de entidade de domínio para Produto.
    /// </summary>
    public class Produto
    {
        #region Propriedades 

        public Guid? Id { get; set; }
        public string? Nome { get; set; }
        public decimal? Preco { get; set; }
        public int? Quantidade { get; set; }
        public DateTime? DataHoraCriacao { get; set; }
        public bool? Ativo {  get; set; }
        public Guid? CategoriaId { get; set; }

        #endregion

        #region

        public Categoria? Categoria { get; set; }

        #endregion
    }
}
