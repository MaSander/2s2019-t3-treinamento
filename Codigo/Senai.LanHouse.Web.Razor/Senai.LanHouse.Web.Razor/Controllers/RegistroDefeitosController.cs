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
    public class RegistroDefeitosController : Controller
    {
        private readonly LanHouseContext _context;

        public RegistroDefeitosController(LanHouseContext context)
        {
            _context = context;
        }

        // GET: RegistroDefeitos
        public async Task<IActionResult> Index()
        {
            if (HttpContext.Session.GetString("email") == null)
            {
                return RedirectToAction("Create", "Login");
            }

            var lanHouseContext = _context.RegistroDefeito.Include(r => r.Defeito).Include(r => r.TipoEquipamento);
            return View(await lanHouseContext.ToListAsync());
        }

        // GET: RegistroDefeitos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (HttpContext.Session.GetString("email") == null)
            {
                return RedirectToAction("Create", "Login");
            }

            if (id == null)
            {
                return NotFound();
            }

            var registroDefeito = await _context.RegistroDefeito
                .Include(r => r.Defeito)
                .Include(r => r.TipoEquipamento)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (registroDefeito == null)
            {
                return NotFound();
            }

            return View(registroDefeito);
        }

        // GET: RegistroDefeitos/Create
        public IActionResult Create()
        {
            if (HttpContext.Session.GetString("email") == null)
            {
                return RedirectToAction("Create", "Login");
            }

            ViewData["DefeitoId"] = new SelectList(_context.Defeito, "Id", "Nome");
            ViewData["TipoEquipamentoId"] = new SelectList(_context.TipoEquipamento, "Id", "Nome");
            return View();
        }

        // POST: RegistroDefeitos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DataDefeito,TipoEquipamentoId,DefeitoId,Observacao")] RegistroDefeito registroDefeito)
        {
            if (ModelState.IsValid)
            {
                _context.Add(registroDefeito);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DefeitoId"] = new SelectList(_context.Defeito, "Id", "Nome", registroDefeito.DefeitoId);
            ViewData["TipoEquipamentoId"] = new SelectList(_context.TipoEquipamento, "Id", "Nome", registroDefeito.TipoEquipamentoId);
            return View(registroDefeito);
        }

        // GET: RegistroDefeitos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (HttpContext.Session.GetString("email") == null)
            {
                return RedirectToAction("Create", "Login");
            }

            if (id == null)
            {
                return NotFound();
            }

            var registroDefeito = await _context.RegistroDefeito.FindAsync(id);
            if (registroDefeito == null)
            {
                return NotFound();
            }
            ViewData["DefeitoId"] = new SelectList(_context.Defeito, "Id", "Nome", registroDefeito.DefeitoId);
            ViewData["TipoEquipamentoId"] = new SelectList(_context.TipoEquipamento, "Id", "Nome", registroDefeito.TipoEquipamentoId);
            return View(registroDefeito);
        }

        // POST: RegistroDefeitos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,DataDefeito,TipoEquipamentoId,DefeitoId,Observacao")] RegistroDefeito registroDefeito)
        {
            if (id != registroDefeito.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(registroDefeito);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RegistroDefeitoExists(registroDefeito.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["DefeitoId"] = new SelectList(_context.Defeito, "Id", "Nome", registroDefeito.DefeitoId);
            ViewData["TipoEquipamentoId"] = new SelectList(_context.TipoEquipamento, "Id", "Nome", registroDefeito.TipoEquipamentoId);
            return View(registroDefeito);
        }

        // GET: RegistroDefeitos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (HttpContext.Session.GetString("email") == null)
            {
                return RedirectToAction("Create", "Login");
            }

            if (id == null)
            {
                return NotFound();
            }

            var registroDefeito = await _context.RegistroDefeito
                .Include(r => r.Defeito)
                .Include(r => r.TipoEquipamento)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (registroDefeito == null)
            {
                return NotFound();
            }

            return View(registroDefeito);
        }

        // POST: RegistroDefeitos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var registroDefeito = await _context.RegistroDefeito.FindAsync(id);
            _context.RegistroDefeito.Remove(registroDefeito);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RegistroDefeitoExists(int id)
        {
            return _context.RegistroDefeito.Any(e => e.Id == id);
        }
    }
}
