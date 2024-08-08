using HealthLifeProject.Commons;
using HealthLifeProject.Entities;
using System.Collections.Generic;
using System.Linq;

namespace HealthLifeProject.Repository
{
    public class DiagnosesRepository
    {
        private readonly HealthLifeDBContext _healthLifeDBContext;

        public DiagnosesRepository(HealthLifeDBContext healthLifeDBContext)
        {
            _healthLifeDBContext = healthLifeDBContext;
        }

        /*internal void Diagnoses(string name, string descript)
        {
            _healthLifeDBContext.Diagnoses.Add(new Diagnoses() { nameDiagnosis= name, desc=descript });
            _healthLifeDBContext.SaveChanges();
        }*/

        public bool AddDiagnose(Diagnoses diagnose)
        {
            _healthLifeDBContext.Add(diagnose);
            return _healthLifeDBContext.SaveChanges() == 1 ? true : false;
        }

        public bool DeleteDiagnoseByID(int diagnoseID)
        {
            Diagnoses diagnose = _healthLifeDBContext.Diagnoses.Find(diagnoseID);
            _healthLifeDBContext.Diagnoses.Remove(diagnose);
            return _healthLifeDBContext.SaveChanges() == 1 ? true : false;
        }

        public List<Diagnoses> getAllDiagnoses()
        {
            return _healthLifeDBContext.Diagnoses.OrderBy(s => s.Id).ToList();
        }
    }
}
