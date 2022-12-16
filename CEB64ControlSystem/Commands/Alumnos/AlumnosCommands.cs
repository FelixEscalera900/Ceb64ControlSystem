using AutoMapper;
using CEB64ControlSystem.Data;
using CEB64ControlSystem.Models;
using CEB64ControlSystem.ModelsDto;
using CEB64ControlSystem.Queries.Alumnos;
using CEB64ControlSystem.ViewModels.Alumnos;

namespace CEB64ControlSystem.Commands.Alumnos
{
    public class AlumnosCommands : Command<AlumnoDto>,IAlumnosCommands
    {
        public IAlumnosQueries _alumnosQueries;
        public AlumnosCommands(ApplicationDbContext context, IMapper mapper, IAlumnosQueries alumnosQueries) : base(context, mapper)
        {
            _alumnosQueries = alumnosQueries;
        }

        public int Create(CreateAlumnoViewModel NewAlumnoDto)
        {
            Alumno NewAlumno = _mapper.Map<Alumno>(NewAlumnoDto);
            _context.Add(NewAlumno);
            _context.SaveChanges();

            return NewAlumno.Id;

        }

        public void Delete(int Id)
        {
            Alumno AlumnoToDelete = _context.Alumnos.Find(Id);
            _context.Remove(AlumnoToDelete);
            _context.SaveChanges();
            
        }

        public void Update(EditAlumnoViewModel ModifiedAlumnoDto)
        {

            Alumno AlumnoFromDatabase = _context.Alumnos.Find(ModifiedAlumnoDto.Id);
            _mapper.Map<EditAlumnoViewModel, Alumno>(ModifiedAlumnoDto, AlumnoFromDatabase);

            _context.SaveChanges();
        }
    }
}
