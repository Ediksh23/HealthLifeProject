﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

/// <summary>
/// Summary description for Class1
/// </summary>
/// 

namespace HealthLifeProject.Entities
{
    public class Benefactors
    {
        public int Id { set; get; }

        [ForeignKey("Surnames")]
        public int SurnameID { set; get; }
        [ForeignKey("Names")]
        public int NameID { set; get; }//
        public string ContactPhone { set; get; }
        //public int phoneID { set; get; }
        public string Email { set; get; }
        public string Login { get; set; }
        public string Password { get; set; }
        public DateTime RegisterDate { get; set; } = DateTime.Now;
        public DateTime BirthDate { set; get; }
        [ForeignKey("Roles")]
        public int RoleID { set; get; }
        public string Notate { set; get; }

        //public virtual ContactPhones ContactPhones { set; get; }
        public virtual Roles Role { set; get; }
    } 
}

