using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Senai.LanHouse.Web.Razor.Domains
{
    public partial class RegistroDefeito
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe uma data")]
        public DateTime DataDefeito { get; set; }

        public int? TipoEquipamentoId { get; set; }
        public int? DefeitoId { get; set; }
        public string Observacao { get; set; }

        public Defeito Defeito { get; set; }
        public TipoEquipamento TipoEquipamento { get; set; }
    }
}
