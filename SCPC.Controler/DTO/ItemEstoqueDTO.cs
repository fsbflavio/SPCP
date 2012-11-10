﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SPCP.Model;
using System.Data;
using SPCP.Util;

namespace SPCP.Controler
{
    public class ItemEstoqueDTO
    {
        public int Id;
        public String Descricao;
        public int EstoqueMinimo;
        public UnidadeMedida UnidadeMedida;
        public int IdGrupoItemEstoque;
    }
}