using HealthLifeProject.Commons;
using HealthLifeProject.Entities;
using System.Collections.Generic;
using System.Linq;

namespace HealthLifeProject.Repository
{
    public class HospitalsCharitableContributionsRepository
    {
       private readonly HealthLifeDBContext _healthLifeDBContext;

        public HospitalsCharitableContributionsRepository(HealthLifeDBContext healthLifeDBContext)
        {
            _healthLifeDBContext = healthLifeDBContext;
        }
        /*internal void AddHospitalsCharitable(int benefactorID, int hospitalID, string card_number_of_benefactor, int amount, string notate)
        {
            _healthLifeDBContext.ClinicsCharitableContributions.Add(new ClinicsCharitableContributions() { benefactorID= benefactorID, hospitalID=hospitalID, card_number_of_benefactor= card_number_of_benefactor, amount = amount, notate= notate });
            _healthLifeDBContext.SaveChanges();
        }*/

        public bool AddHospitalCharitableContribution(HospitalsCharitableContributions contribution)
        {
            _healthLifeDBContext.Add(contribution);
            var HospitalContribution = _healthLifeDBContext.Hospitals.SingleOrDefault(o => o.Id == contribution.HospitalID);
                HospitalContribution.DonationAmount += contribution.Amount; ///???
            return _healthLifeDBContext.SaveChanges() == 1 ? true : false;
        }

        public bool DeleteHospitalsCharitableContributionByID(int contributionID)
        {
            HospitalsCharitableContributions contribution = _healthLifeDBContext.HospitalsCharitableContributions.Find(contributionID);
            _healthLifeDBContext.HospitalsCharitableContributions.Remove(contribution);
            return _healthLifeDBContext.SaveChanges() == 1 ? true : false;
        }

        public bool AddWardCharitableContribution(HospitalsCharitableContributions contribution)
        {
            _healthLifeDBContext.Add(contribution);
            var WardContribution = _healthLifeDBContext.Wards.SingleOrDefault(o => o.Id == contribution.WardID);
                WardContribution.DonationAmount += contribution.Amount; ///???
            return _healthLifeDBContext.SaveChanges() == 1 ? true : false;
        }

        public IEnumerable<HospitalsCharitableContributions> GetAllHospitalsWardsCharitable()
        {
            return _healthLifeDBContext.ClinicsCharitableContributions.OrderBy(o => o.Id).ToList();
        }

        public IEnumerable<HospitalsCharitableContributions> GetHospitalsWardsCharitableByBenefactor(int BenefactorID)
        {
            return _healthLifeDBContext.ClinicsCharitableContributions.Where(o => o.BenefactorID == BenefactorID).ToList();
        }
        public IEnumerable<HospitalsCharitableContributions> GetHospitalsCharitableByHospital(int HospitalID)
        {
            return _healthLifeDBContext.ClinicsCharitableContributions.Where(o => o.HospitalID == HospitalID).ToList();
        }
        public IEnumerable<HospitalsCharitableContributions> GetWardsCharitableByWards(int WardID)
        {
            return _healthLifeDBContext.ClinicsCharitableContributions.Where(o => o.WardID == WardID).ToList();
        }
        public IEnumerable<HospitalsCharitableContributions> GetHospitalsWardsCharitableByAmountLess(int Amount)
        {
            return _healthLifeDBContext.ClinicsCharitableContributions.Where(o => o.Amount <= Amount).ToList();
        }
        public IEnumerable<HospitalsCharitableContributions> GetHospitalsWardsCharitableByAmountMore(int Amount)
        {
            return _healthLifeDBContext.ClinicsCharitableContributions.Where(o => o.Amount >= Amount).ToList();
        }

    }
}
