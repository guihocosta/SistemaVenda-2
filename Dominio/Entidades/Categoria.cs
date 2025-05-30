﻿using System.ComponentModel.DataAnnotations;

namespace SistemaVenda.Dominio.Entidades
{
    public class Categoria
    {
        [Key]
        public int? Codigo { get; set; }
        public string Descricao { get; set; }
        public ICollection<Produto> Produtos { get; set; }

    }
}
