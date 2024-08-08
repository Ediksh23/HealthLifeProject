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

        /*internal void AddPatientPhotos(int patientID, string way, string descript)
        {
            _healthLifeDBContext.PatientPhotos.Add(new PatientPhotos() { patientID = patientID, wayToPhoto = way, desc = descript });
            _healthLifeDBContext.SaveChanges();
        }*/

        public bool AddPatientPhoto(PatientPhotos photo)
        {
            _healthLifeDBContext.Add(photo);
            return _healthLifeDBContext.SaveChanges() == 1 ? true : false;
        }

        public bool DeletePatientPhotoByID(int photoID)
        {
            PatientPhotos photo = _healthLifeDBContext.PatientPhotos.Find(photoID);
            _healthLifeDBContext.PatientPhotos.Remove(photo);
            return _healthLifeDBContext.SaveChanges() == 1 ? true : false;
        }
    }
}
