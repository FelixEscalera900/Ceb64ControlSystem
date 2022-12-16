using AutoMapper;
using CEB64ControlSystem.Models;
using CEB64ControlSystem.ModelsDto;

namespace CEB64ControlSystem.MappingProfiles
{
    public class AlumnosContactosMP : Profile
    {
        public AlumnosContactosMP()
        {
            CreateMap<AlumnoContacto, AlumnoContactoDto>()
                .ForMember(Dto => Dto.FullName, mp =>
                    mp.MapFrom(alumno => alumno.Name + " " + alumno.ApellidoPaterno + " " + alumno.ApellidoMaterno));

        }


    }
}
