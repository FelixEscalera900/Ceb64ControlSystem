namespace CEB64ControlSystem.ViewModels
{
    public class Row
    {
        public Row()
        {
            Data = new List<string>();
        }
        public int Id { get; set; }
        public List<string> Data { get; set; }

    }
}
