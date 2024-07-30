using System.Collections.Generic;

namespace HealthLifeProject.Entities
{
    public class Subcategories
    {

        public int Id { set; get; }
        public string NameSubcategory { set; get; }
        public string Desc { set; get; }
        public List<Patients> Patients { set; get; }
    }
}
