using CEB64ControlSystem.ModelsDto;
using CEB64ControlSystem.ViewModels;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using System.Reflection;

namespace CEB64ControlSystem.ViewModelFactories
{
    public class IdentityListViewModelFactory<Entity> where Entity : KeyedDto 
    {
        protected Dictionary<string, Expression<Func<Entity, string>>> EntityDictionary { get; set; }
        public List<Entity> Entities { get; set; }

        public IdentityListViewModelFactory()
        {
            EntityDictionary = new Dictionary<string, Expression<Func<Entity, string>>>();
            Entities = new List<Entity>();
        }
        public void ShowProperty(Expression<Func<Entity, string>> SourceEntity)
        {
            MemberExpression member = SourceEntity.Body as MemberExpression;

            MemberInfo Property = member.Member;

            DisplayAttribute displayNameContainer = Property
                .GetCustomAttributes(typeof(DisplayAttribute))
                .Cast<DisplayAttribute>()
                .FirstOrDefault();

            string displayName;

            if (displayNameContainer == null)
                displayName = Property.Name;
            else
                displayName = displayNameContainer.Name;

            EntityDictionary.Add(displayName, SourceEntity);

        }

        private List<Row> GetDataTable()
        {
            List < Row > DataTable = new List<Row>();

            foreach (Entity SourceEntity in Entities)
            {
                Row Row = new Row();
                Row.Id = SourceEntity.Id;

                foreach (KeyValuePair<string, Expression<Func<Entity, string>>> entry in EntityDictionary)
                {

                    Func<Entity, string> PropertyGetter = entry.Value.Compile();

                    Row.Data.Add(PropertyGetter(SourceEntity));

                }

                DataTable.Add(Row);
            }

            return DataTable;
        }

        public void FillModel(IdentityListViewModel Model) 
        {

            Model.DataTable = GetDataTable();
            Model.Titles = new List<string>(EntityDictionary.Keys);

        }

        public ModelType CreateModel<ModelType> () where ModelType : IdentityListViewModel, new()
        {
            ModelType Model = new ModelType();

            Model.DataTable = GetDataTable();
            Model.Titles = new List<string>(EntityDictionary.Keys);

            return Model;
        }

    }
}
