using System;
using System.Collections.Generic;

namespace Senai.LanHouse.Web.Razor.Domains
{
    public partial class Usuario
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
