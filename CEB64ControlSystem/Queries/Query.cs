using AutoMapper;
using CEB64ControlSystem.Data;

namespace CEB64ControlSystem.Queries
{
    public abstract class Query<Type>
    {
        protected readonly ApplicationDbContext _context;
        protected readonly IMapper _mapper;

        public Query( ApplicationDbContext context, IMapper mapper) 
        {
            _context = context;
            _mapper = mapper;
        }


    }
}
