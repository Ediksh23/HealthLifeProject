using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

/// <summary>
/// Summary description for Class1
/// </summary>
/// 

namespace HealthLifeProject.Entities
{
    public class Partners
    {
        public int Id { set; get; }
        
        public string NamePartners { set; get; }
        public int PartnersRepresentativesID { set; get; }//

        public string Notate { set; get; }

        //public virtual ContactPhones ContactPhones { set; get; }
        public virtual PartnersRepresentatives PartnersRepresentative { set; get; }
        public virtual Roles Role { set; get; }
    } 
}

