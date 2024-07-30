using System;

/// <summary>
/// Summary description for Class1
/// </summary>
namespace HealthLifeProject.Entities { 
    public class WardsPhotos
    {
        public int Id { set; get; }
        public string WayToPhoto { set; get; }
        public string Desc { set; get; }
        public int WardID { set; get; }
        public virtual Wards Ward { set; get; }
    }
}