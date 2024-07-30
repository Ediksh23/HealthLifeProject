//using Google.Protobuf.WellKnownTypes;
using HealthLifeProject.Commons;
using HealthLifeProject.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        public List<Benefactors> getAllBenefactors()
        {
            return _healthLifeDBContext.Benefactors.OrderBy(s => s.Id).ToList();
        }
    }
}
