using HealthLifeProject.Commons;
using HealthLifeProject.Entities;

namespace HealthLifeProject.Repository
{
    public class WardsPhotosRepository
    {
        private readonly HealthLifeDBContext _healthLifeDBContext;

        public WardsPhotosRepository(HealthLifeDBContext healthLifeDBContext)
        {
            _healthLifeDBContext = healthLifeDBContext;
        }

        /*internal void WardsPhotos(int patientID, string way, string descript)
        {
            _healthLifeDBContext.WardsPhotos.Add(new WardsPhotos() { wardID = patientID, wayToPhoto = way, desc = descript });
            _healthLifeDBContext.SaveChanges();
        }*/

        public bool AddWardsPhoto(WardsPhotos photo)
        {
            _healthLifeDBContext.Add(photo);
            return _healthLifeDBContext.SaveChanges() == 1 ? true : false;
        }

        public bool DeleteWardsPhotoByID(int photoID)
        {
            WardsPhotos photo = _healthLifeDBContext.WardsPhotos.Find(photoID);
            _healthLifeDBContext.WardsPhotos.Remove(photo);
            return _healthLifeDBContext.SaveChanges() == 1 ? true : false;
        }
    }
}
