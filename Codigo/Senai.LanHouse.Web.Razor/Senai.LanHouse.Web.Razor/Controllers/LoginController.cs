using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Senai.LanHouse.Web.Razor.Domains;

namespace Senai.LanHouse.Web.Razor.Controllers
{
    public class LoginController : Controller
    {
        private readonly LanHouseContext _context;

        public LoginController(LanHouseContext context)
        {
            _context = context;
        }

        // GET: Login/Create
        public IActionResult Create()
        {
            HttpContext.Session.Clear();
            return View();
        }

        // POST: Login/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Email,Senha")] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                Usuario retorno = _context.Usuario.FirstOrDefault(x => x.Email == usuario.Email && x.Senha == usuario.Senha);

                if(retorno == null)
                {
                    ViewBag.Mensagem = "Usuário incorreto";
                    return View(usuario);
                }

                HttpContext.Session.SetString("email", usuario.Email);
                return RedirectToAction("Index", "RegistroDefeitos");
            }
            return View(usuario);
        }
       
    }
}
