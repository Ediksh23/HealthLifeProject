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
        public bool AddWardsPhoto(WardsPhotos wardsPhoto)
        {
            _healthLifeDBContext.Add(wardsPhoto);
            return _healthLifeDBContext.SaveChanges() == 1 ? true : false;
        }
    }
}
