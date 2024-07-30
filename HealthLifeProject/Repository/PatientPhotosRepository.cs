using HealthLifeProject.Commons;
using HealthLifeProject.Entities;

namespace HealthLifeProject.Repository
{
    public class PatientPhotosRepository
    {
        private readonly HealthLifeDBContext _healthLifeDBContext;

        public PatientPhotosRepository(HealthLifeDBContext healthLifeDBContext)
        {
            _healthLifeDBContext = healthLifeDBContext;
        }

        /*internal void PatientPhotos(int patientID, string way, string descript)
        {
            _healthLifeDBContext.PatientPhotos.Add(new PatientPhotos() { patientID = patientID, wayToPhoto = way, desc = descript });
            _healthLifeDBContext.SaveChanges();
        }*/
        public bool AddPatientPhoto(PatientPhotos patientPhoto)
        {
            _healthLifeDBContext.Add(patientPhoto);
            return _healthLifeDBContext.SaveChanges() == 1 ? true : false;
        }
    }
}
