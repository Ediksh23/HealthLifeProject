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

        public bool AddDiagnos(Benefactors diagnos)
        {
            _healthLifeDBContext.Add(diagnos);
            return _healthLifeDBContext.SaveChanges() == 1 ? true : false;
        }
        public List<Diagnoses> getAllDiagnoses()
        {
            return _healthLifeDBContext.Diagnoses.OrderBy(s => s.Id).ToList();
        }
    }
}
