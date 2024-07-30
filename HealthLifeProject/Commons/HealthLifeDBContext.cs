//using Google.Protobuf.WellKnownTypes;
using HealthLifeProject.Entities;
using Microsoft.EntityFrameworkCore;
//using System.Data.Entity;
using System.Reflection.Emit;

namespace HealthLifeProject.Commons
{
    public class HealthLifeDBContext : DbContext
    {

        // NZ: Add db
        public DbSet<Benefactors> Benefactors { get; set; }
        public DbSet<DirectionOfHelp> DirectionOfHelp { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Subcategories> Subcategories { get; set; }
        public DbSet<Cities> Cities { get; set; }
        public DbSet<ClinicsCharitableContributions> ClinicsCharitableContributions { get; set; }
        public DbSet<ContactPhones> ContactPhones { get; set; }
        public DbSet<Diagnoses> Diagnoses { get; set; }
        public DbSet<Entrances> Entrances { get; set; }
        public DbSet<FundraisingStatuses> FundraisingStatuses { get; set; }
        public DbSet<Hospitals> Hospitals { get; set; }
        public DbSet<HospitalsPhotos> HospitalsPhotos { get; set; }
        public DbSet<HospitalsRepresentatives> HospitalsRepresentatives { get; set; }
        public DbSet<Houses> Houses { get; set; }
        public DbSet<Names> Names { get; set; }
        public DbSet<NavagateLink> Navagates { get; set; }
        public DbSet<PatientPhotos> PatientPhotos { get; set; }
        public DbSet<Patients> Patients { get; set; }
        public DbSet<PatientsCharitableContributions> PatientsCharitableContributions { get; set; }
        public DbSet<Patronymics> Patronymics { get; set; }
        public DbSet<Positions> Positions { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Gender> Gender { get; set; }
        public DbSet<Streets> Streets { get; set; }
        public DbSet<Surnames> Surnames { get; set; }
        public DbSet<Wards> Wards { get; set; }
        public DbSet<WardsPhotos> WardsPhotos { get; set; }

        // NZ: 
        public HealthLifeDBContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        //OnModelCreation
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer(@"Data Source=Komputer;Initial Catalog=veterinaryClinic;Integrated Security=True");
            dbContextOptionsBuilder.EnableSensitiveDataLogging(true);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            /*modelBuilder.Entity<Option>().HasIndex(p => p.Name).IsUnique();
            modelBuilder.Entity<Benefactors>().HasIndex(p => p.ContactPhone).IsUnique();*/


            /* NavagateLink[] navagateLinks = new NavagateLink[]
             {
                 new NavagateLink(){Id = 1, Href="/", Title="Головна", Childs = null, Order=1, ParentId=null},
                 new NavagateLink(){Id = 2, Href="/about/index", Title="Познайомимось", Childs = null, Order=5, ParentId=null},
                 new NavagateLink(){Id = 3, Href="/about/index", Title="Контакти", Childs = null, Order=1, ParentId=2},
             };

             modelBuilder.Entity<NavagateLink>().HasData(navagateLinks);*/

            DirectionOfHelp[] directionOfHelp = new DirectionOfHelp[]
            {
                new DirectionOfHelp(){Id=1,  NameDirection="Допомога пацієнтам", Desc="Допомога людині на лікування, реабілітацію, протезування або підтримку життедіяльності"},
                new DirectionOfHelp(){Id=2,  NameDirection="Допомога лікарням", Desc="Домога лікарням на загальні потреби/ ремонтні роботи, обладнання, витратні матеріали для пацієнтів, ліки для пацієнтів, збір на якусь певну мету"}
            };
            modelBuilder.Entity<DirectionOfHelp>().HasData(directionOfHelp);

            Category[] categories = new Category[]
            {
                new Category(){Id=1,  NameCategory="Дорослі", Desc="Пацієнти старше 18 років"},
                new Category(){Id=2,  NameCategory="Діти", Desc="Пацієнти до 18 років"},
                new Category(){Id=3,  NameCategory="Військові", Desc="Пацієнти, що набули або погіршили стан захворювання під час проходження військової служби"}
            };
            modelBuilder.Entity<Category>().HasData(categories);

            Subcategories[] subcategories = new Subcategories[]
            {
                new Subcategories(){Id=1,  NameSubcategory="Лікування", Desc="Допомога на лікування або порятунок життя пацієнта"},
                new Subcategories(){Id=2,  NameSubcategory="Реабілітація", Desc="Допомога на реабілітацію після проходження лікування або протезування"},
                new Subcategories(){Id=3,  NameSubcategory="Протезування", Desc="Допомога на протезування"},
                new Subcategories(){Id=4,  NameSubcategory="Підтримка життедіяльності", Desc="Допомога на підтримку життедіяльності невиліковно хворих пацієнтів"}
            };
            modelBuilder.Entity<Subcategories>().HasData(subcategories);

            Gender[] gender = new Gender[]
            {
                new Gender(){Id=1,  NameGender="Чоловік"},
                new Gender(){Id=2,  NameGender="Жінка"}
            };
            modelBuilder.Entity<Gender>().HasData(gender);

            /*Diagnoses[] diagnoses = new Diagnoses[]
            {
                new Diagnoses(){Id=1,  NameDiagnosis="", Desc=""},
                new Diagnoses(){Id=2,  NameDiagnosis="", Desc=""},
                new Diagnoses(){Id=2,  NameDiagnosis="", Desc=""},
                new Diagnoses(){Id=2,  NameDiagnosis="", Desc=""},
                new Diagnoses(){Id=2,  NameDiagnosis="", Desc=""},
                new Diagnoses(){Id=2,  NameDiagnosis="", Desc=""},
                new Diagnoses(){Id=2,  NameDiagnosis="", Desc=""},
                new Diagnoses(){Id=2,  NameDiagnosis="", Desc=""},
                new Diagnoses(){Id=2,  NameDiagnosis="", Desc=""},
                new Diagnoses(){Id=3,  NameDiagnosis="", Desc=""}
            };
            modelBuilder.Entity<Diagnoses>().HasData(diagnoses);*/
        }
    }
}
