namespace CEB64ControlSystem.ModelsDto
{
    public class DesactivableDto : KeyedDto
    {
        public bool Soft_deleted { get; set; }
        public DateOnly Delete_Date { get; set; }
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
