using AutoMapper;
using CEB64ControlSystem.Models;
using CEB64ControlSystem.ModelsDto;
using CEB64ControlSystem.ViewModels.Alumnos;

namespace CEB64ControlSystem.MappingProfiles
{
    public class AlumnosMP : Profile
    {
        public AlumnosMP()
        {
            CreateMap<Alumno, AlumnoDto>()
                .ForMember(Dto => Dto.FullName, mp =>
                    mp.MapFrom(alumno => alumno.Name + " " + alumno.ApellidoPaterno + " " + alumno.ApellidoMaterno ))
                .ForMember(Dto => Dto.NumeroDeLista, mp =>
                    mp.MapFrom(alumno => alumno.Grupo.Alumnos.FindIndex(a => a.Id == alumno.Id) + 1));

            CreateMap<Alumno, EditAlumnoViewModel>();
            CreateMap<EditAlumnoViewModel, Alumno >();

            CreateMap<CreateAlumnoViewModel, Alumno>();
            CreateMap<Alumno, CreateAlumnoViewModel >();
        }
        
    }
}
