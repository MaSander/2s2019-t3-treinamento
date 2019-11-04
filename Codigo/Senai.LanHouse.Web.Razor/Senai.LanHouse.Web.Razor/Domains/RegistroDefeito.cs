using System;
using System.Collections.Generic;

namespace Senai.LanHouse.Web.Razor.Domains
{
    public partial class RegistroDefeito
    {
        public int Id { get; set; }
        public DateTime DataDefeito { get; set; }
        public int? TipoEquipamentoId { get; set; }
        public int? DefeitoId { get; set; }
        public string Observacao { get; set; }

        public Defeito Defeito { get; set; }
        public TipoEquipamento TipoEquipamento { get; set; }
    }
}
