using AutoMapper;
using CEB64ControlSystem.Data;
using CEB64ControlSystem.ModelsDto;
using CEB64ControlSystem.ModelsDto.Common;
using Microsoft.EntityFrameworkCore;

namespace CEB64ControlSystem.Queries
{
    public interface IEntityQuery<DtoType> where DtoType : new()
    {
        public List<DtoType> FindMany();
        public  List<DtoType> FindMany(DtoType Filters);
        public  DtoType Find(int Id);
        public  EntityBasedModel GetEntityBasedModel<EntityBasedModel>(int Id) where EntityBasedModel : new();
        public  List<SelectOption> GetSelectList(DtoType Filters);

    }

}
