using AutoMapper;
using CEB64ControlSystem.Models;
using CEB64ControlSystem.ModelsDto;
using CEB64ControlSystem.ViewModels.Grupos;

namespace CEB64ControlSystem.MappingProfiles
{
    public class GruposMP : Profile
    {
        public GruposMP()
        {
            CreateMap<GrupoDto, Grupo>();
            CreateMap<Grupo, GrupoDto>()
    .       ForMember(
                Dto => Dto.Alumnos,
                o => o.MapFrom((grupo, grupoDto, i, context) =>
                    grupo.Alumnos.OrderBy(g => g.ApellidoPaterno)
                )
            )
            .ForMember(
                Dto => Dto.NumeroAlumnos,
                o => o.MapFrom(grupo => grupo.Alumnos.Count.ToString())
            );

            CreateMap<Grupo, EditGrupoViewModel>();
            CreateMap<CreateGrupoViewModel , Grupo>();

        }

    }
}
