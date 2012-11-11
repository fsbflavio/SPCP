using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SPCP.Model;

namespace SPCP.Controller
{
    public class FichaProdutoControl
    {
        public DataTable CarregaGrid(int id)
        {
            FichaProduto f = new FichaProduto();
            return (f.CarregaGrid(id));
        }
    }
}
