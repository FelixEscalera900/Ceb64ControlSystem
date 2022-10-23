using AutoMapper;
using CEB64ControlSystem.Models;
using CEB64ControlSystem.ModelsDto;
using CEB64ControlSystem.ViewModels;

namespace CEB64ControlSystem
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Grupo, GrupoDto>();
            CreateMap<Grupo, EditGrupoViewModel>();
            CreateMap<Alumno, AlumnoDto>();
        } 

    }
}
