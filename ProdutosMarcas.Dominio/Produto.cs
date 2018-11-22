﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutosMarcas.Dominio
{
    public class Produto
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public int MarcaId { get; set; }
        public Marca Marca { get; set; }
    }
}
