using System;
using System.ComponentModel.DataAnnotations.Schema;

/// <summary>
/// Summary description for Class1
/// </summary>
/// 
namespace HealthLifeProject.Entities { 
    public class HospitalsPhotos
    {
        public int Id { set; get; }
        public string WayToPhoto { set; get; }
        public string Desc { set; get; }
        [ForeignKey("Hospitals")]
        public int HospitalID { set; get; }
        public virtual Hospitals Hospital { set; get; }
    }
}