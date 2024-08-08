using HealthLifeProject.Commons;
using HealthLifeProject.Entities;
using System.Collections.Generic;
using System.Linq;

namespace HealthLifeProject.Repository
{
    public class GenderRepository
    {
        private readonly HealthLifeDBContext _healthLifeDBContext;

        public GenderRepository(HealthLifeDBContext healthLifeDBContext)
        {
            _healthLifeDBContext = healthLifeDBContext;
        }

        public bool AddGender(Gender gender)
        {
            _healthLifeDBContext.Add(gender);
            return _healthLifeDBContext.SaveChanges() == 1 ? true : false;
        }

        public bool DeleteGenderByID(int genderID)
        {
            Gender gender = _healthLifeDBContext.Gender.Find(genderID);
            _healthLifeDBContext.Gender.Remove(gender);
            return _healthLifeDBContext.SaveChanges() == 1 ? true : false;
        }

        public List<Gender> getAllGender()
        {
            return _healthLifeDBContext.Gender.OrderBy(s => s.Id).ToList();
        }
    }
}
