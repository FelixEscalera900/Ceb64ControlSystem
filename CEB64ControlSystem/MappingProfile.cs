using AutoMapper;
using CEB64ControlSystem.Models;
using CEB64ControlSystem.ModelsDto;

namespace CEB64ControlSystem
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Grupo, GrupoDto>();
            CreateMap<Alumno, AlumnoDto>();
        } 

    }
}
