using CEB64ControlSystem.ModelsDto;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using System.Reflection;

namespace CEB64ControlSystem.ViewModels
{
    public class IdentityListViewModel
    {
        public List<Row> DataTable { get; set; }
        public List<string> Titles { get; set; }
        public string PluralName { get; set; }
        public string SingularName { get; set; }
        public string CreationRoute { get; set; }

        public IdentityListViewModel()
        {
            DataTable = new List<Row>();
            Titles = new List<string>();    
        }

    }
}
