using HealthLifeProject.Commons;
using HealthLifeProject.Entities;
using System.Collections.Generic;
using System.Linq;

namespace HealthLifeProject.Repository
{
    public class SubcategoriesRepository
    {
        private readonly HealthLifeDBContext _healthLifeDBContext;

        public SubcategoriesRepository(HealthLifeDBContext healthLifeDBContext)
        {
            _healthLifeDBContext = healthLifeDBContext;
        }
        //        internal void Category(string name, string descript)
        //        {
        //            _healthLifeDBContext.Category.Add(new Category() { NameCategory = name, Desc = descript });
        //            _healthLifeDBContext.SaveChanges();
        //        }
        public bool AddSubcategory(Subcategories subcategory)
        {
            _healthLifeDBContext.Add(subcategory);
            return _healthLifeDBContext.SaveChanges() == 1 ? true : false;
        }
        public List<Subcategories> getAllSubcategories()
        {
            return _healthLifeDBContext.Subcategories.OrderBy(s => s.Id).ToList();
        }
    }
}
