using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Senai.LanHouse.Web.Razor.Domains
{
    public partial class Defeito
    {
        public Defeito()
        {
            RegistroDefeito = new HashSet<RegistroDefeito>();
        }

        public int Id { get; set; }

        [Required(ErrorMessage = "Informe um defeito")]
        public string Nome { get; set; }

        public ICollection<RegistroDefeito> RegistroDefeito { get; set; }
    }
}
