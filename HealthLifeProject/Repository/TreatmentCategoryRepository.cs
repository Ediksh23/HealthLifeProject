using HealthLifeProject.Commons;
using HealthLifeProject.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace HealthLifeProject.Repository
{
    public class TreatmentCategoryRepository
    {
        private readonly HealthLifeDBContext _healthLifeDBContext;

        public TreatmentCategoryRepository(HealthLifeDBContext healthLifeDBContext)
        {
            _healthLifeDBContext = healthLifeDBContext;
        }
        public bool AddTreatmentCategory(TreatmentCategory treatmentCategory)
        {
            _healthLifeDBContext.Add(treatmentCategory);
            return _healthLifeDBContext.SaveChanges() == 1 ? true : false;
        }

        public bool DeleteTreatmentCategoryByID(int categoryID)
        {
            TreatmentCategory category = _healthLifeDBContext.TreatmentCategory.Find(categoryID);
            _healthLifeDBContext.TreatmentCategory.Remove(category);
            return _healthLifeDBContext.SaveChanges() == 1 ? true : false;
        }

        public List<TreatmentCategory> getAllTreatmentCategory()
        {
            return _healthLifeDBContext.TreatmentCategory.OrderBy(s => s.Id).ToList();
        }
    }
}
