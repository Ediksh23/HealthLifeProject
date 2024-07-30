using System;

/// <summary>
/// Summary description for Class1
/// </summary>
namespace HealthLifeProject.Entities { 
    public class PatientsCharitableContributions
    {
        public int Id { set; get; }
        public int BenefactorID { set; get; }
        public int PatientID { set; get; }
        public string Card_number_of_benefactor { set; get; }
        public int Amount { set; get; }
        public string Notate { set; get; }
        public virtual Benefactors Benefactor { get; set; }
        public virtual Patients Patient { get; set; }
    }
}