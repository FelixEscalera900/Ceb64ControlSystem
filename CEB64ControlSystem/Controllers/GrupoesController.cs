
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CEB64ControlSystem.Data;
using CEB64ControlSystem.Models;
using AutoMapper;
using CEB64ControlSystem.ModelsDto;
using CEB64ControlSystem.ViewModelFactories;
using CEB64ControlSystem.Queries.Grupos;
using CEB64ControlSystem.Queries.Semestres;
using CEB64ControlSystem.Commands.Grupos;
using CEB64ControlSystem.ViewModels.Grupos;

namespace CEB64ControlSystem.Controllers
{
    public class GrupoesController : Controller
    {
        private readonly ISemestreQueries _SemestreQueries;
        private readonly IGruposQueries _gruposQueries;
        private readonly IGruposCommands _gruposCommands;

        public GrupoesController(ISemestreQueries semestreQueries, IGruposQueries gruposQueries, IGruposCommands gruposCommands)
        {

            _SemestreQueries = semestreQueries;
            _gruposQueries = gruposQueries;
            _gruposCommands = gruposCommands;
        }

        // GET: Grupoes
        public async Task<IActionResult> Index(GruposListViewModel Model)
        {
            var Factory = new IdentityListViewModelFactory<GrupoDto>();

            Factory.Entities = _gruposQueries.FindMany(Model.Filters);

            Factory.ShowProperty(grupo => grupo.Name);
            Factory.ShowProperty(grupo => grupo.Semestre.Name);
            Factory.ShowProperty(grupo => grupo.NumeroAlumnos);

            Factory.FillModel(Model);
            
            Model.Semestres = _SemestreQueries.GetPeriodoSemestres();

            return View(Model);
        }

        // GET: Grupoes/Details/5
        public async Task<IActionResult> Details(int id)
        {

            GrupoDto grupo = _gruposQueries.Find(id);

            if (grupo == null)
            {
                return NotFound();
            }
            
            return View(grupo);
        }
        public IActionResult Create()
        {
            List<Semestre> semestres = _SemestreQueries.GetPeriodoSemestres();

            CreateGrupoViewModel ViewModel = new CreateGrupoViewModel()
            {
                SemestresSelect = new SelectList(semestres, "Id", "Name")
            };

            return View(ViewModel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,SemestreID")] CreateGrupoViewModel Model)
        {
            if (ModelState.IsValid)
            {
                _gruposCommands.Create(Model);

                return RedirectToAction(nameof(Index));
            }

            List<Semestre> semestres = _SemestreQueries.GetPeriodoSemestres();

            Model.SemestresSelect = new SelectList(semestres, "Id", "Name");

            return View(Model);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            GrupoDto grupo = _gruposQueries.Find(id.Value);

            return View(grupo);
        }

        public async Task<IActionResult> EditData(int Id)
        {
            EditGrupoViewModel Model = _gruposQueries.GetEntityBasedModel<EditGrupoViewModel>(Id);
            Model.Semestres = _SemestreQueries.GetPeriodoSemestres();

            return Json(Model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit([FromBody] EditGrupoViewModel Model)
        {
            if (ModelState.IsValid)
            {
                try
                {   
                    _gruposCommands.Update(Model);
                }
                catch (DbUpdateConcurrencyException)
                {
                    return NotFound();
                }
                return Ok();
            }
            return StatusCode(500);
        }

        // GET: Grupoes/Delete/5
        public async Task<IActionResult> Delete(int id)
        {


            if (_gruposQueries.Find(id).Alumnos.Count > 0)
                return Json(new { canBeDeleted = false });

            return Json(new {canBeDeleted = true});
        }

        // POST: Grupoes/Delete/5
        [HttpDelete, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int Id)
        {

            if (_gruposQueries.Find(Id).Alumnos.Count > 0)
                return BadRequest();

            _gruposCommands.Delete(Id);

            return Ok();
        }

    }
}
