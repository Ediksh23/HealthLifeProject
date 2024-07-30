using HealthLifeProject.Commons;
using HealthLifeProject.Entities;
using System.Collections.Generic;
using System.Linq;

namespace HealthLifeProject.Repository
{
    public class SurnamesRepository
    {
        private readonly HealthLifeDBContext _healthLifeDBContext;

        public SurnamesRepository(HealthLifeDBContext healthLifeDBContext)
        {
            _healthLifeDBContext = healthLifeDBContext;
        }

        /*internal void Surnames(string surname, string descript)
        {
            _healthLifeDBContext.Surnames.Add(new Surnames() { surname = surname, desc = descript });
            _healthLifeDBContext.SaveChanges();
        }*/
        public bool AddSurname(Surnames surname)
        {
            _healthLifeDBContext.Add(surname);
            return _healthLifeDBContext.SaveChanges() == 1 ? true : false;
        }
        public List<Surnames> getAllSurnames()
        {
            return _healthLifeDBContext.Surnames.OrderBy(s => s.Id).ToList();
        }
    }
}
