using HealthLifeProject.Commons;
using HealthLifeProject.Entities;
using System.Collections.Generic;
using System.Linq;

namespace HealthLifeProject.Repository
{
    public class ClinicsCharitableContributionsRepository
    {
       private readonly HealthLifeDBContext _healthLifeDBContext;

        public ClinicsCharitableContributionsRepository(HealthLifeDBContext healthLifeDBContext)
        {
            _healthLifeDBContext = healthLifeDBContext;
        }
        /*internal void AddClinicsCharitable(int benefactorID, int hospitalID, string card_number_of_benefactor, int amount, string notate)
        {
            _healthLifeDBContext.ClinicsCharitableContributions.Add(new ClinicsCharitableContributions() { benefactorID= benefactorID, hospitalID=hospitalID, card_number_of_benefactor= card_number_of_benefactor, amount = amount, notate= notate });
            _healthLifeDBContext.SaveChanges();
        }*/

        public bool AddClinicsCharitable(Benefactors clinicsCharitable)
        {
            _healthLifeDBContext.Add(clinicsCharitable);
            return _healthLifeDBContext.SaveChanges() == 1 ? true : false;
        }

        public IEnumerable<ClinicsCharitableContributions> GetClinicsCharitable()
        {
            return _healthLifeDBContext.ClinicsCharitableContributions.OrderBy(o => o.Id).ToList();
        }

        public IEnumerable<ClinicsCharitableContributions> GetClinicsCharitableByBenefactor(int benefactorID)
        {
            return _healthLifeDBContext.ClinicsCharitableContributions.Where(o => o.BenefactorID == benefactorID).ToList();
        }
        public IEnumerable<ClinicsCharitableContributions> GetClinicsCharitableByHospital(int hospitalID)
        {
            return _healthLifeDBContext.ClinicsCharitableContributions.Where(o => o.HospitalID == hospitalID).ToList();
        }
        public IEnumerable<ClinicsCharitableContributions> GetClinicsCharitableByAmountLess(int amount)
        {
            return _healthLifeDBContext.ClinicsCharitableContributions.Where(o => o.Amount <= amount).ToList();
        }
        public IEnumerable<ClinicsCharitableContributions> GetClinicsCharitableByAmountMore(int amount)
        {
            return _healthLifeDBContext.ClinicsCharitableContributions.Where(o => o.Amount >= amount).ToList();
        }

    }
}
