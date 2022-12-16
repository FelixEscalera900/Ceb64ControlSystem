using AutoMapper;
using CEB64ControlSystem.Data;

namespace CEB64ControlSystem.Commands
{
    public class Command<Type>
    {
        protected readonly ApplicationDbContext _context;
        protected readonly IMapper _mapper;

        public Command(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
    
    }
}
