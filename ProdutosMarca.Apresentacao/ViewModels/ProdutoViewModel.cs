﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutosMarca.Apresentacao.ViewModels
{
    public class ProdutoViewModel
    {
        public int Id { get; set; }
        public string  Nome { get; set; }
        public int MarcaId { get; set; }

        public string  Marca { get; set; }

    }
}
