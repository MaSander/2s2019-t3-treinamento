using System;
using System.Collections.Generic;

namespace Senai.LanHouse.Web.Razor.Domains
{
    public partial class TipoEquipamento
    {
        public TipoEquipamento()
        {
            RegistroDefeito = new HashSet<RegistroDefeito>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }

        public ICollection<RegistroDefeito> RegistroDefeito { get; set; }
    }
}
