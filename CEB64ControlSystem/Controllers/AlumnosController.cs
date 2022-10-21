
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CEB64ControlSystem.Data;
using CEB64ControlSystem.Models;

namespace CEB64ControlSystem.Controllers
{
    public class AlumnosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AlumnosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Alumnos
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Alumnos.Include(a => a.Estado).Include(a => a.Grupo).Include(a => a.Semestre);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Alumnos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Alumnos == null)
            {
                return NotFound();
            }

            var alumno = await _context.Alumnos
                .Include(a => a.Estado)
                .Include(a => a.Grupo)
                .Include(a => a.Semestre)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (alumno == null)
            {
                return NotFound();
            }

            return View(alumno);
        }

        // GET: Alumnos/Create
        public IActionResult Create()
        {
            ViewData["IdEstado"] = new SelectList(_context.AlumnoEstados, "Id", "Id");
            ViewData["GrupoId"] = new SelectList(_context.Grupos, "id", "id");
            ViewData["SemestreId"] = new SelectList(_context.Semestres, "Id", "Id");
            return View();
        }

        // POST: Alumnos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FechaNacimiento,FechaIngreso,FechaEgreso,GrupoId,SemestreId,IdEstado,Name,ApellidoPaterno,ApellidoMaterno,Direccion,NumeroTelefonico")] Alumno alumno)
        {
            if (ModelState.IsValid)
            {
                _context.Add(alumno);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdEstado"] = new SelectList(_context.AlumnoEstados, "Id", "Id", alumno.IdEstado);
            ViewData["GrupoId"] = new SelectList(_context.Grupos, "id", "id", alumno.GrupoId);
            ViewData["SemestreId"] = new SelectList(_context.Semestres, "Id", "Id", alumno.SemestreId);
            return View(alumno);
        }

        // GET: Alumnos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Alumnos == null)
            {
                return NotFound();
            }

            var alumno = await _context.Alumnos.FindAsync(id);
            if (alumno == null)
            {
                return NotFound();
            }
            ViewData["IdEstado"] = new SelectList(_context.AlumnoEstados, "Id", "Id", alumno.IdEstado);
            ViewData["GrupoId"] = new SelectList(_context.Grupos, "id", "id", alumno.GrupoId);
            ViewData["SemestreId"] = new SelectList(_context.Semestres, "Id", "Id", alumno.SemestreId);
            return View(alumno);
        }

        // POST: Alumnos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FechaNacimiento,FechaIngreso,FechaEgreso,GrupoId,SemestreId,IdEstado,Name,ApellidoPaterno,ApellidoMaterno,Direccion,NumeroTelefonico")] Alumno alumno)
        {
            if (id != alumno.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(alumno);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AlumnoExists(alumno.Id))
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
            ViewData["IdEstado"] = new SelectList(_context.AlumnoEstados, "Id", "Id", alumno.IdEstado);
            ViewData["GrupoId"] = new SelectList(_context.Grupos, "id", "id", alumno.GrupoId);
            ViewData["SemestreId"] = new SelectList(_context.Semestres, "Id", "Id", alumno.SemestreId);
            return View(alumno);
        }

        // GET: Alumnos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Alumnos == null)
            {
                return NotFound();
            }

            var alumno = await _context.Alumnos
                .Include(a => a.Estado)
                .Include(a => a.Grupo)
                .Include(a => a.Semestre)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (alumno == null)
            {
                return NotFound();
            }

            return View(alumno);
        }

        // POST: Alumnos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Alumnos == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Alumnos'  is null.");
            }
            var alumno = await _context.Alumnos.FindAsync(id);
            if (alumno != null)
            {
                _context.Alumnos.Remove(alumno);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AlumnoExists(int id)
        {
          return _context.Alumnos.Any(e => e.Id == id);
        }
    }
}
