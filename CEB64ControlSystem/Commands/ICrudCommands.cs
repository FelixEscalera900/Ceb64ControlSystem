using CEB64ControlSystem.ModelsDto;

namespace CEB64ControlSystem.Commands
{
    public interface ICrudCommands<UpdateModel, CreateModel>
    {
        public int Create(CreateModel NewAlumnoDto);
        public void Delete(int Id);

        public void Update(UpdateModel ModifiedAlumnoDto);

    }
}
