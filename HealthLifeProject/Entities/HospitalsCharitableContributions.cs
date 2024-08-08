using System;
using System.Collections.Generic;

/// <summary>
/// Summary description for Class1
/// </summary>
/// 

namespace HealthLifeProject.Entities
{
    public class HospitalsCharitableContributions
    {
        public int Id { set; get; }
        public int BenefactorID { set; get; }
        public int HospitalID { set; get; }
        public int WardID { set; get; }
        public string Card_number_of_benefactor { set; get; }
        public string Bank_account_of_benefactor { set; get; }
        public int Amount { set; get; }
        public string Notate { set; get; }
        public virtual Benefactors Benefactor { get; set; }
        public virtual Hospitals Hospital { get; set; }
        public virtual Wards Ward { get; set; }
    }
}

