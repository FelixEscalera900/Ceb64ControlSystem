namespace CEB64ControlSystem.Models.Abstractions
{
    public class DesactivableEntity : KeyedEntity
    {
        public bool Soft_deleted { get; set; }
        public DateOnly Delete_Date { get; set; }
    }
}
