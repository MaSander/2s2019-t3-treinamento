using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Senai.LanHouse.Web.Razor.Domains
{
    public partial class Usuario
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o seu e-mail")]
        [EmailAddress(ErrorMessage = "Informe um e-mail valido")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe o seu e-mail")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
    }
}
