using HealthLifeProject.Commons;
using HealthLifeProject.Entities;

namespace HealthLifeProject.Repository
{
    public class HospitalsPhotosRepository
    {
        private readonly HealthLifeDBContext _healthLifeDBContext;

        public HospitalsPhotosRepository(HealthLifeDBContext healthLifeDBContext)
        {
            _healthLifeDBContext = healthLifeDBContext;
        }

        /*internal void HospitalsPhotos(int hospitalID, string way, string descript)
        {
            _healthLifeDBContext.HospitalsPhotos.Add(new HospitalsPhotos() { hospitalID= hospitalID, wayToPhoto = way, desc = descript });
            _healthLifeDBContext.SaveChanges();
        }*/
        public bool AddHospitalsPhoto(HospitalsPhotos photo)
        {
            _healthLifeDBContext.Add(photo);
            return _healthLifeDBContext.SaveChanges() == 1 ? true : false;
        }

        public bool DeleteHospitalsPhotoByID(int photoID)
        {
            HospitalsPhotos photo = _healthLifeDBContext.HospitalsPhotos.Find(photoID);
            _healthLifeDBContext.HospitalsPhotos.Remove(photo);
            return _healthLifeDBContext.SaveChanges() == 1 ? true : false;
        }
    }
}
