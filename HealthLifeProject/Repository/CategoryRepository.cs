using HealthLifeProject.Commons;
using HealthLifeProject.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace HealthLifeProject.Repository
{
    public class CategoryRepository
    {
        private readonly HealthLifeDBContext _healthLifeDBContext;

        public CategoryRepository(HealthLifeDBContext healthLifeDBContext)
        {
            _healthLifeDBContext = healthLifeDBContext;
        }
        /*internal void AddCategory(string name, string descript)
        {
            _healthLifeDBContext.Category.Add(new Category() { NameCategory = name, Desc = descript });
            _healthLifeDBContext.SaveChanges();
        }*/
        public bool AddCategory(Category category)
        {
            _healthLifeDBContext.Add(category);
            return _healthLifeDBContext.SaveChanges() == 1 ? true : false;
        }

        public bool DeleteCategoryByID(int categoryID)
        {
            Category category = _healthLifeDBContext.Category.Find(categoryID);
            _healthLifeDBContext.Category.Remove(category);
            return _healthLifeDBContext.SaveChanges() == 1 ? true : false;
        }

        public List<Category> getAllCategory()
        {
            return _healthLifeDBContext.Category.OrderBy(s => s.Id).ToList();
        }
    }
}
