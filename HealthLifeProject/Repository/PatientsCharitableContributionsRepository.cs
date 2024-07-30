using HealthLifeProject.Commons;
using HealthLifeProject.Entities;
using System.Collections.Generic;
using System.Linq;

namespace HealthLifeProject.Repository
{
    public class PatientsCharitableContributionsRepository
    {
        private readonly HealthLifeDBContext _healthLifeDBContext;
        public PatientsCharitableContributionsRepository(HealthLifeDBContext healthLifeDBContext)
        {
            _healthLifeDBContext = healthLifeDBContext;
        }
        /*internal void AddPatientsCharitable(int benefactorID, int patientID, string card_number_of_benefactor, int amount, string notate)
        {
            _healthLifeDBContext.PatientsCharitableContributions.Add(new PatientsCharitableContributions() { benefactorID = benefactorID, patientID = patientID, card_number_of_benefactor = card_number_of_benefactor, amount = amount, notate = notate });
            _healthLifeDBContext.SaveChanges();
        }*/
        public bool AddPatientsCharitable(PatientsCharitableContributions patientsCharitable)
        {
            _healthLifeDBContext.Add(patientsCharitable);
            return _healthLifeDBContext.SaveChanges() == 1 ? true : false;
        }

        public IEnumerable<PatientsCharitableContributions> GetAllPatientsCharitables()
        {
            return _healthLifeDBContext.PatientsCharitableContributions.OrderBy(o => o.Id).ToList();
        }

        public IEnumerable<PatientsCharitableContributions> GetPatientsCharitableByBenefactor(int benefactorID)
        {
            return _healthLifeDBContext.PatientsCharitableContributions.Where(o => o.BenefactorID == benefactorID).ToList();
        }
        public IEnumerable<PatientsCharitableContributions> GetPatientsCharitableByPatientID(int hospitalID)
        {
            return _healthLifeDBContext.PatientsCharitableContributions.Where(o => o.PatientID == hospitalID).ToList();
        }
        public IEnumerable<PatientsCharitableContributions> GetPatientsCharitableByAmountLess(int amount)
        {
            return _healthLifeDBContext.PatientsCharitableContributions.Where(o => o.Amount <= amount).ToList();
        }
        public IEnumerable<PatientsCharitableContributions> GetPatientsCharitableByAmountMore(int amount)
        {
            return _healthLifeDBContext.PatientsCharitableContributions.Where(o => o.Amount >= amount).ToList();
        }
    }
}
