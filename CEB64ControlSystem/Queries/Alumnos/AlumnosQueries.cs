using AutoMapper;
using CEB64ControlSystem.Data;
using CEB64ControlSystem.Models;
using CEB64ControlSystem.ModelsDto;
using CEB64ControlSystem.Enums ;
using CEB64ControlSystem.ModelsDto.Common;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace CEB64ControlSystem.Queries.Alumnos
{
    public class AlumnosQueries : Query<AlumnoDto>, IAlumnosQueries
    {
        public AlumnosQueries(ApplicationDbContext context, IMapper mapper) : base(context, mapper)
        {

        }

        protected IQueryable<Alumno> BaseQuery()
        {
            return _context
                .Alumnos
                .Include(a => a.Estado)
                .Include(a => a.Grupo)
                .Include(a => a.Semestre)
                .Where(a => a.IdEstado == (int)AlumnoEstadoEnum.Alta);
        }

        public AlumnoDto Find(int Id)
        {
            Alumno alumno = BaseQuery().FirstOrDefault( a => a.Id == Id);

            return _mapper.Map<AlumnoDto>(alumno);
        }
        public List<AlumnoDto> FindMany()
        {

            return FindMany(new AlumnoDto());
        }
        public List<AlumnoDto> FindMany(AlumnoDto Filters)
        {
            List<Alumno> alumnos = BaseQuery()
                .Where(a =>
                    (Filters.SemestreId == 0 || a.SemestreId == Filters.SemestreId) &&
                    (Filters.GrupoId == 0 || a.GrupoId == Filters.GrupoId)
                )
                .ToList();

            List<AlumnoDto> alumnosDto = _mapper.Map<List<AlumnoDto>>(alumnos)
                .Where(a => 
                Filters.FullName == null || a.FullName.Contains(Filters.FullName))
                .ToList();

            return alumnosDto;
        }
        public EntityBasedModel GetEntityBasedModel<EntityBasedModel>(int Id) where EntityBasedModel :  new()
        {
            Alumno Alumno = _context.Alumnos.Find(Id);
            EntityBasedModel Model = _mapper.Map < EntityBasedModel>(Alumno);

            return Model;
        }
        public List<SelectOption> GetSelectList(AlumnoDto Filters)
        {
            return FindMany(Filters).Select(a => 
                new SelectOption()
                {
                    Id = a.Id,
                    Name = a.Name
                }
            ).ToList();
        }

    }
}
