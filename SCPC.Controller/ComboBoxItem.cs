using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SPCP.Controller
{
    public class ComboBoxItem
    {
        public int id {get; set;}
        public String descricao { get; set; }

        public ComboBoxItem(int id, String descricao)
        {
            this.id = id;
            this.descricao = descricao;
        }

        public ComboBoxItem(String descricao)
        {
            this.descricao = descricao;
        }

        public override String ToString()
        {
            return this.descricao;
        }
    }
}
