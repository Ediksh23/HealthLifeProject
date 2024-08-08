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

        public bool AddPatientsCharitableContribution(PatientsCharitableContributions contribution)
        {
            var PatientContribution = _healthLifeDBContext.Patients.SingleOrDefault(o => o.Id == contribution.PatientID);
            if(PatientContribution.Fundraising_statusID == 1)
            {
                _healthLifeDBContext.Add(contribution);
                PatientContribution.DonationAmount += contribution.Amount; ///???
                return _healthLifeDBContext.SaveChanges() == 1 ? true : false;
            }
        }

        public bool DeletePatientsCharitableContributionByID(int contributionID)
        {
            PatientsCharitableContributions contribution = _healthLifeDBContext.PatientsCharitableContributions.Find(contributionID);
            _healthLifeDBContext.PatientsCharitableContributions.Remove(contribution);
            return _healthLifeDBContext.SaveChanges() == 1 ? true : false;
        }

        public IEnumerable<PatientsCharitableContributions> GetAllPatientsCharitable()
        {
            return _healthLifeDBContext.PatientsCharitableContributions.OrderBy(o => o.Id).ToList();
        }

        public IEnumerable<PatientsCharitableContributions> GetPatientsCharitableByBenefactor(int BenefactorID)
        {
            return _healthLifeDBContext.PatientsCharitableContributions.Where(o => o.BenefactorID == BenefactorID).ToList();
        }
        public IEnumerable<PatientsCharitableContributions> GetPatientsCharitableByPatientID(int HospitalID)
        {
            return _healthLifeDBContext.PatientsCharitableContributions.Where(o => o.PatientID == HospitalID).ToList();
        }
        public IEnumerable<PatientsCharitableContributions> GetPatientsCharitableByAmountLess(int Amount)
        {
            return _healthLifeDBContext.PatientsCharitableContributions.Where(o => o.Amount <= Amount).ToList();
        }
        public IEnumerable<PatientsCharitableContributions> GetPatientsCharitableByAmountMore(int Amount)
        {
            return _healthLifeDBContext.PatientsCharitableContributions.Where(o => o.Amount >= Amount).ToList();
        }
    }
}
