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

        /*internal void AddHospitalsPhotos(int hospitalID, string way, string descript)
        {
            _healthLifeDBContext.HospitalsPhotos.Add(new HospitalsPhotos() { hospitalID= hospitalID, wayToPhoto = way, desc = descript });
            _healthLifeDBContext.SaveChanges();
        }*/

        public bool AddHospitalsPhoto(HospitalsPhotos hospitalsPhoto)
        {
            _healthLifeDBContext.Add(hospitalsPhoto);
            return _healthLifeDBContext.SaveChanges() == 1 ? true : false;
        }
    }
}
