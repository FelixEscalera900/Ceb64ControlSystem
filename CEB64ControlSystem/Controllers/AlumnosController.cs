
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CEB64ControlSystem.ViewModelFactories;
using CEB64ControlSystem.ModelsDto;
using CEB64ControlSystem.Queries.Alumnos;
using CEB64ControlSystem.Queries.Semestres;
using CEB64ControlSystem.ViewModels.Alumnos;
using CEB64ControlSystem.Queries.Grupos;
using CEB64ControlSystem.Commands.Alumnos;
using CEB64ControlSystem.ModelsDto.Common;

namespace CEB64ControlSystem.Controllers
{
    public class AlumnosController : Controller
    {
        IAlumnosQueries _alumnosQueries;
        ISemestreQueries _semestresQueries;
        IGruposQueries _gruposQueries;
        IAlumnosCommands _alumnosCommands;

        public AlumnosController(IAlumnosQueries alumnosQueries, ISemestreQueries semestresQueries, IGruposQueries gruposQueries, Commands.Alumnos.IAlumnosCommands alumnosCommands)
        {
            _alumnosQueries = alumnosQueries;
            _semestresQueries = semestresQueries;
            _gruposQueries = gruposQueries;
            _alumnosCommands = alumnosCommands;

        }

        // GET: Alumnos
        public async Task<IActionResult> Index(AlumnosListViewModel Model)
        {
            var Factory = new IdentityListViewModelFactory<AlumnoDto>();

            Factory.Entities = _alumnosQueries.FindMany(Model.Filters);

            Factory.ShowProperty(a => a.FullName);
            Factory.ShowProperty(a => a.Semestre.Name);
            Factory.ShowProperty(a => a.Grupo.Name);
            Factory.ShowProperty(a => a.NumeroDeLista);


            Factory.FillModel(Model);

            Model.Semestres = _semestresQueries.GetPeriodoSemestres();
            Model.Grupos = _gruposQueries.FindMany(new GrupoDto { SemestreID = Model.Filters.SemestreId });

            return View(Model);

        }

        // GET: Alumnos/Details/5
        public async Task<IActionResult> Details(int Id)
        {
            AlumnoDto Model = _alumnosQueries.Find(Id);

            if (Model == null)
                return NotFound();
           
            return View(Model);
        }

        public IActionResult Create()
        {

            CreateAlumnoViewModel Model = new CreateAlumnoViewModel();

            Model.Semestres = _semestresQueries.GetPeriodoSemestres();

            return View(Model);
        }

        public ActionResult CreateInitialData()
        {
            return Json(_semestresQueries.GetPeriodoSemestres());
        }

        public async Task<ActionResult> Grupos(int Id)
        {
            List<SelectOption> Grupos = _gruposQueries.GetSelectList(new GrupoDto { SemestreID = Id });

            return Json(Grupos);
        }

        // POST: Alumnos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([FromBody] CreateAlumnoViewModel Model)
        {

            if (!ModelState.IsValid)
            {
                Model.Semestres = _semestresQueries.GetPeriodoSemestres();

                return BadRequest();
            }

            _alumnosCommands.Create(Model);

            return Ok();
        }

        // GET: Alumnos/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            EditAlumnoViewModel Model = 
                _alumnosQueries.GetEntityBasedModel<EditAlumnoViewModel>(id);

            Model.SemestresSelect = new SelectList(_semestresQueries.GetPeriodoSemestres(), "Id", "Name");
            Model.GruposSelect = new SelectList(_gruposQueries.FindMany(new GrupoDto { SemestreID = Model.SemestreId }), "Id", "Name");

            return View(Model);
        }

        // POST: Alumnos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FechaNacimiento,FechaIngreso,FechaEgreso,GrupoId,SemestreId,IdEstado,Name,ApellidoPaterno,ApellidoMaterno,Direccion,NumeroTelefonico")] EditAlumnoViewModel Model)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    _alumnosCommands.Update(Model);

                }
                catch (DbUpdateConcurrencyException)
                {

                        return NotFound();

                }
                return RedirectToAction(nameof(Index));

            }

            Model.SemestresSelect = new SelectList(_semestresQueries.GetPeriodoSemestres(), "Id", "Name");
            Model.GruposSelect = new SelectList(_gruposQueries.FindMany(new GrupoDto { SemestreID = Model.SemestreId }), "Id", "Name");

            return View(Model);
        }

        // POST: Alumnos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {


            _alumnosCommands.Delete(id);

            return RedirectToAction(nameof(Index));
        }
    }
}
