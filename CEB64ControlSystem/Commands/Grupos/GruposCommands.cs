using AutoMapper;
using CEB64ControlSystem.Data;
using CEB64ControlSystem.Models;
using CEB64ControlSystem.Queries.Grupos;
using CEB64ControlSystem.Queries.Periodos;
using CEB64ControlSystem.ViewModels.Grupos;

namespace CEB64ControlSystem.Commands.Grupos
{
    public class GruposCommands : Command<Grupo>, IGruposCommands
    {
        IPeriodoQueries _periodoQueries;

        public GruposCommands(ApplicationDbContext context, IMapper mapper, IPeriodoQueries periodoQueries, IGruposQueries gruposQueries) : base(context, mapper)
        {
            _periodoQueries = periodoQueries;
        }

        public int Create(CreateGrupoViewModel grupo)
        {
            Grupo grupoEntity = _mapper.Map<Grupo>(grupo);

            grupoEntity.PeriodoId = _periodoQueries.GetCurrentPeriodo().PeriodoId;

            _context.Add(grupoEntity);

            _context.SaveChanges();

            return grupoEntity.Id;
        }

        public void Update(EditGrupoViewModel grupoDto)
        {
            Grupo grupo = _context.Grupos.Find(grupoDto.Id);

            grupo.Name = grupoDto.Name;
            grupo.SemestreID = grupoDto.SemestreID;

            _context.SaveChanges();

        }

        public void Delete(int id)
        {
            Grupo grupo = _context.Grupos.Find(id);

            _context.Grupos.Remove(grupo);
            _context.SaveChanges();

        }

    }
}
