using HealthLifeProject.Commons;
using HealthLifeProject.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace HealthLifeProject.Repository
{
    public class GenderRepository
    {
        private readonly HealthLifeDBContext _healthLifeDBContext;

        public GenderRepository(HealthLifeDBContext healthLifeDBContext)
        {
            _healthLifeDBContext = healthLifeDBContext;
        }

        /*internal void Sex(string name, string descript)
        {
            _healthLifeDBContext.Sex.Add(new Sex() { nameSex = name, desc = descript });
            _healthLifeDBContext.SaveChanges();
        }*/
        public bool AddGender(Gender gender)
        {
            _healthLifeDBContext.Add(gender);
            return _healthLifeDBContext.SaveChanges() == 1 ? true : false;
        }
        public List<Gender> getAllGender()
        {
            return _healthLifeDBContext.Gender.OrderBy(s => s.Id).ToList();
        }
    }
}
