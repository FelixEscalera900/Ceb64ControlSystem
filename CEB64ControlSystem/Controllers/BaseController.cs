using AutoMapper;
using CEB64ControlSystem.Data;
using CEB64ControlSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CEB64ControlSystem.Controllers
{
    public class BaseController : Controller
    {
        public readonly ApplicationDbContext _context;

        public BaseController(ApplicationDbContext context)
        {
            _context = context;
        }

        protected List<Semestre> GetPeriodoSemestres()
        {
            List<Semestre> semestres = _context.Periodos
                .Include(p => p.PeriodoTipo)
                .ThenInclude(t => t.Semestres)
                .FirstOrDefault(p => p.IsTheCurrentPeriodo)
                .PeriodoTipo.Semestres;

            return semestres;

        }
    }
}
