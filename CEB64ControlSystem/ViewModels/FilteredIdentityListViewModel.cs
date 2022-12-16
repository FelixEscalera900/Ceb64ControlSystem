namespace CEB64ControlSystem.ViewModels
{
    public class FilteredIdentityListViewModel <Entity> : IdentityListViewModel
    {

        public Entity Filters { get; set; }

    }
}
