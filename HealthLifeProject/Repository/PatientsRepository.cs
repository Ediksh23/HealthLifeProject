using HealthLifeProject.Commons;
using HealthLifeProject.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace HealthLifeProject.Repository
{
    public class PatientsRepository
    {
        private readonly HealthLifeDBContext _healthLifeDBContext;

        public PatientsRepository(HealthLifeDBContext healthLifeDBContext)
        {
            _healthLifeDBContext = healthLifeDBContext;
        }
        /*internal void Patients(int surnameID, int nameID, int patronymicID, DateTime birthDate,  int sexID, int cityID, int hospitalID, int wardID, int categoryID, int diagnosisID, string bank_account, string bank_card_number, int inn, int fundraising_statusID, string notate)
        {
            _healthLifeDBContext.Patients.Add(new Patients() { surnameID = surnameID,  nameID= nameID, patronymicID = patronymicID, birthDate = birthDate, sexID = sexID, cityID = cityID, hospitalID = hospitalID, wardID = wardID,
                categoryID = categoryID,diagnosisID = diagnosisID, bank_account = bank_account, bank_card_number= bank_card_number, inn=inn,  fundraising_statusID= fundraising_statusID, notate = notate});
            _healthLifeDBContext.SaveChanges();
        }*/
        public bool AddPatient(Patients patient)
        {
            _healthLifeDBContext.Add(patient);
            return _healthLifeDBContext.SaveChanges() == 1 ? true : false;
        }

        public IEnumerable<Patients> GetAllPatients()
        {
            return _healthLifeDBContext.Patients.OrderBy(o => o.Id).ToList();
        }
        public IEnumerable<Patients> GetPatientsBySurnameID(int surnameID)
        {
            return _healthLifeDBContext.Patients.Where(o => o.SurnameID == surnameID).ToList();
        }
        public IEnumerable<Patients> GetPatientsBySexID(int genderID)
        {
            return _healthLifeDBContext.Patients.Where(o => o.GenderID == genderID).ToList();
        }
        public IEnumerable<Patients> GetPatientsByHospitalID(int hospitalID)
        {
            return _healthLifeDBContext.Patients.Where(o => o.HospitalID == hospitalID).ToList();
        }
        public IEnumerable<Patients> GetPatientsByWardID(int wardID)
        {
            return _healthLifeDBContext.Patients.Where(o => o.WardID == wardID).ToList();
        }
        public IEnumerable<Patients> GetPatientsByCategoryID(int categoryID)
        {
            return _healthLifeDBContext.Patients.Where(o => o.CategoryID == categoryID).ToList();
        }
        public IEnumerable<Patients> GetPatientsByDiagnosisID(int diagnosisID)
        {
            return _healthLifeDBContext.Patients.Where(o => o.DiagnosisID == diagnosisID).ToList();
        }
        public IEnumerable<Patients> GetPatientsByCityID(int cityID)
        {
            return _healthLifeDBContext.Patients.Where(o => o.CityID == cityID).ToList();
        }
       // public IEnumerable<Patients> GetPatientsByAge(int Age)
      //  {

            //return _healthLifeDBContext.Patients.Where( == Age).ToList();
      //  }
    }
}
