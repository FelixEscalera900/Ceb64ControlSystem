using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CEB64ControlSystem.Data;
using CEB64ControlSystem.Models;
using CEB64ControlSystem.ViewModels;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using AutoMapper;
using CEB64ControlSystem.ModelsDto;

namespace CEB64ControlSystem.Controllers
{
    public class GrupoesController : BaseController
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GrupoesController(ApplicationDbContext context, IMapper mapper):base(context)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: Grupoes
        public async Task<IActionResult> Index()
        {
            var grupos = _context.Grupos
                .Include(g => g.Periodo)
                .Include(g => g.PlanEstudio)
                .Include(g => g.Semestre)
                .Include(g => g.Alumnos)
                .ToList();

            var dto = _mapper.Map<List<GrupoDto>>(grupos);

            return View(dto);
        }

        // GET: Grupoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Grupos == null)
            {
                return NotFound();
            }

            var grupo = await _context.Grupos
                .Include(g => g.Periodo)
                .Include(g => g.PlanEstudio)
                .Include(g => g.Semestre)
                .Include(a => a.Alumnos)
                .Include(g => g.Asignaturas)
                .FirstOrDefaultAsync(m => m.id == id);
            if (grupo == null)
            {
                return NotFound();
            }
            
            return View(_mapper.Map<GrupoDto>(grupo));
        }

        // GET: Grupoes/Create
        public IActionResult Create()
        {
            var semestres = GetPeriodoSemestres();

            var ViewModel = new CreateGrupoViewModel()
            {
                SemestresSelect = new SelectList(semestres, "Id", "Name")
            };

            return View(ViewModel);
        }

        // POST: Grupoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,SemestreID")] CreateGrupoViewModel grupo)
        {
            if (ModelState.IsValid)
            {
                Grupo grupoEntity = grupo;

                grupoEntity.PeriodoId = _context.Periodos.FirstOrDefault(p => p.IsTheCurrentPeriodo).PeriodoId;

                _context.Add(grupoEntity);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            return View(grupo);
        }

        // GET: Grupoes/Edit/5EditModel
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Grupos == null)
            {
                return NotFound();
            }

            return View(new Grupo());
        }

        public async Task<IActionResult> EditData(int? id)
        {
            if (id == null || _context.Grupos == null)
            {
                return NotFound();
            }
            var grupo = _context.Grupos.Include(g => g.Semestre).FirstOrDefault(g => g.SemestreID == id);

            EditGrupoViewModel Model = _mapper.Map<EditGrupoViewModel>(grupo);
            Model.Semestres = GetPeriodoSemestres();

            return Ok(Model);
        }

            [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Name,SemestreID")] Grupo grupo)
        {
            if (id != grupo.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {


                try
                {
                    _context.Update(grupo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GrupoExists(grupo.id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return Ok();
            }

            return NotFound();

        }

        // GET: Grupoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Grupos == null)
            {
                return NotFound();
            }

            var grupo = await _context.Grupos
                .Include(g => g.Periodo)
                .Include(g => g.PlanEstudio)
                .Include(g => g.Semestre)
                .FirstOrDefaultAsync(m => m.id == id);
            if (grupo == null)
            {
                return NotFound();
            }

            return View(grupo);
        }

        // POST: Grupoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Grupos == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Grupos'  is null.");
            }
            var grupo = await _context.Grupos.FindAsync(id);
            if (grupo != null)
            {
                _context.Grupos.Remove(grupo);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GrupoExists(int id)
        {
          return _context.Grupos.Any(e => e.id == id);
        }
    }
}
