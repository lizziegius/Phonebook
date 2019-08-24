using System.Data.Entity;

namespace mvcPhone.Models
{
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<mvcPhone.Models.Phone> Phones { get; set; }
    }
}