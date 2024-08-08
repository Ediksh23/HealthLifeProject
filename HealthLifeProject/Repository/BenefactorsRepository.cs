using HealthLifeProject.Commons;
using HealthLifeProject.Entities;
using System.Collections.Generic;
using System.Linq;

namespace HealthLifeProject.Repository
{
    public class BenefactorsRepository
    {
        private readonly HealthLifeDBContext _healthLifeDBContext;

        public BenefactorsRepository(HealthLifeDBContext healthLifeDBContext)
        {
            _healthLifeDBContext = healthLifeDBContext;
        }

        public bool AddBenefactor(Benefactors benefactor)
        {
            _healthLifeDBContext.Add(benefactor);
            return _healthLifeDBContext.SaveChanges() == 1 ? true : false;
        }

        public bool DeleteBenefactorByID(int benefactorID)
        {
            Benefactors benefactor = _healthLifeDBContext.Benefactors.Find(benefactorID);
            _healthLifeDBContext.Benefactors.Remove(benefactor);
            return _healthLifeDBContext.SaveChanges() == 1 ? true : false;
        }

        public List<Benefactors> getAllBenefactors()
        {
            return _healthLifeDBContext.Benefactors.OrderBy(s => s.Id).ToList();
        }

        public Benefactors GetBenefactorByEmail(string email)
        {
            Benefactors benefactor = _healthLifeDBContext.Benefactors.FirstOrDefault(u => u.Email == email);
            return benefactor;
        }

    }
}
