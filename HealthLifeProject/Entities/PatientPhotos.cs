using System;
using System.ComponentModel.DataAnnotations.Schema;

/// <summary>
/// Summary description for Class1
/// </summary>
namespace HealthLifeProject.Entities { 
    public class PatientPhotos
    {
        public int Id { set; get; }
        public string WayToPhoto { set; get; }
        public string Desc { set; get; }
        [ForeignKey("Patients")]
        public int PatientID { set; get; }
        public virtual Patients Patient { set; get; }
    }
}