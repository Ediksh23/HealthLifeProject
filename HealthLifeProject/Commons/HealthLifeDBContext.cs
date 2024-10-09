using HealthLifeProject.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System;
using System.Reflection.Metadata;
using WebApp.Entities;

namespace HealthLifeProject.Commons
{
    public class HealthLifeDBContext : DbContext
    {
        // NZ: Add db

        public Microsoft.EntityFrameworkCore.DbSet<Benefactors> Benefactors { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Category> Category { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<TreatmentCategory> TreatmentCategory { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Cities> Cities { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<HospitalsCharitableContributions> ClinicsCharitableContributions { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<ContactPhones> ContactPhones { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Diagnoses> Diagnoses { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Entrances> Entrances { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<FundraisingStatuses> FundraisingStatuses { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Hospitals> Hospitals { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<HospitalsRepresentatives> HospitalsRepresentatives { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<HospitalsCharitableContributions> HospitalsCharitableContributions { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Houses> Houses { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Names> Names { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Patients> Patients { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<PatientsCharitableContributions> PatientsCharitableContributions { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<PartnersRepresentatives> PartnersRepresentatives { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Patronymics> Patronymics { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Positions> Positions { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Partners> Partners { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Roles> Roles { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Gender> Gender { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Streets> Streets { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<StreetTypes> StreetTypes { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Surnames> Surnames { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Wards> Wards { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<NavagateLink> NavagateLink { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Option> Option { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Events> Event { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<News> News { get; set; }

        public HealthLifeDBContext(DbContextOptions<HealthLifeDBContext> dbContextOptions) : base(dbContextOptions)
        {
            //Database.EnsureDeleted();
           .//Database.EnsureCreated(); // Створюємо базу даних при першому зверненні   Команда: EntityFrameworkCore\Add-migration  Initial

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Hospitals>()
               .HasMany(e => e.Wards)
               .WithOne(e => e.Hospital)
               .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Hospitals>()
               .HasMany(e => e.HospitalsRepresentatives)
               .WithOne(e => e.Hospital)
               .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Hospitals>()
              .HasMany(e => e.Patients)
              .WithOne(e => e.Hospital)
              .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Wards>()
              .HasMany(e => e.HospitalsRepresentatives)
              .WithOne(e => e.Ward)
              .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Wards>()
              .HasMany(e => e.Patients)
              .WithOne(e => e.Ward)
              .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Hospitals>()
                .HasMany(e => e.CharitableContributions)
                .WithOne(e => e.Hospital)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Wards>()
                .HasMany(e => e.CharitableContributions)
                .WithOne(e => e.Ward)
                .OnDelete(DeleteBehavior.Restrict);



            NavagateLink[] navagateLinks = new NavagateLink[]
             {
                 new NavagateLink(){Id = 1, Href="/", Title="Головна", Childs = null, Order=1, ParentId=null},
                 new NavagateLink(){Id = 2, Href="/about/index", Title="Про нас", Childs = null, Order=1, ParentId=null},
                 new NavagateLink(){Id = 3, Href="/about/index", Title="Пацієнти", Childs = null, Order=1, ParentId=null},
                 new NavagateLink(){Id = 4, Href="/about/index", Title="Категорії", Childs = null, Order=2, ParentId=3},
                 new NavagateLink(){Id = 5, Href="/about/index", Title="Напрямок лікування", Childs = null, Order=2, ParentId=3},
                 new NavagateLink(){Id = 6, Href="/about/index", Title="Стать", Childs = null, Order=2, ParentId=3},
                 new NavagateLink(){Id = 7, Href="/about/index", Title="Міста", Childs = null, Order=2, ParentId=3},
                 new NavagateLink(){Id = 8, Href="/about/index", Title="Медичні установи", Childs = null, Order=2, ParentId=3},
                 new NavagateLink(){Id = 9, Href="/about/index", Title="Відділення", Childs = null, Order=2, ParentId=3},
                 new NavagateLink(){Id = 10, Href="/about/index", Title="Діагнози", Childs = null, Order=3, ParentId=9},
                 new NavagateLink(){Id = 11, Href="/about/index", Title="Медичні установи", Childs = null, Order=1, ParentId=null},

             };
            modelBuilder.Entity<NavagateLink>().HasData(navagateLinks);

            Category[] categorys = new Category[]
             {
                  new Category(){Id = 1, NameCategory="Дорослі", Desc=""},
                  new Category(){Id = 2, NameCategory="Діти", Desc=""},
                  new Category(){Id = 3, NameCategory="Військові", Desc=""}
             };
            modelBuilder.Entity<Category>().HasData(categorys);

            TreatmentCategory[] treatmentCategory = new TreatmentCategory[]
            {
                  new TreatmentCategory(){Id = 1, NameTreatmentCategory="Лікування", Desc=""},
                  new TreatmentCategory(){Id = 2, NameTreatmentCategory="Реабілітація", Desc=""},
                  new TreatmentCategory(){Id = 3, NameTreatmentCategory="Протезування", Desc=""},
                  new TreatmentCategory(){Id = 4, NameTreatmentCategory="Підтимка життедіяльності", Desc=""}
            };
            modelBuilder.Entity<TreatmentCategory>().HasData(treatmentCategory);

            Gender[] gender = new Gender[]
            {
                  new Gender(){Id = 1, NameGender="Чоловік", Desc=""},
                  new Gender(){Id = 2, NameGender="Жінка", Desc=""}
            };
            modelBuilder.Entity<Gender>().HasData(gender);

            Cities[] cities = new Cities[]
           {
                  new Cities(){Id = 1, NameCity="Київ", Desc=""},
                  new Cities(){Id = 2, NameCity="Дніпро", Desc=""},
                  new Cities(){Id = 3, NameCity="Полтава", Desc=""},
                  new Cities(){Id = 4, NameCity="Харків", Desc=""},
                  new Cities(){Id = 5, NameCity="Львів", Desc=""}
           };
            modelBuilder.Entity<Cities>().HasData(cities);

            StreetTypes[] streetTypes = new StreetTypes[]
           {
                  new StreetTypes(){Id = 1, NameStreetTypes="вулиця", Desc=""},
                  new StreetTypes(){Id = 2, NameStreetTypes="провулок", Desc=""},
                  new StreetTypes(){Id = 3, NameStreetTypes="площа", Desc=""},
                  new StreetTypes(){Id = 4, NameStreetTypes="шое", Desc=""},
                  new StreetTypes(){Id = 5, NameStreetTypes="", Desc=""}
           };
            modelBuilder.Entity<StreetTypes>().HasData(streetTypes);

            Streets[] streets = new Streets[]
           {
                  new Streets(){Id = 1, NameStreet="Чорновола", StreetTypesId=1, Desc=""},
                  new Streets(){Id = 2, NameStreet="Салтівське", StreetTypesId=4, Desc=""},
                  new Streets(){Id = 3, NameStreet="Соборна", StreetTypesId=3, Desc=""},
                  new Streets(){Id = 4, NameStreet="Шевченка", StreetTypesId=1, Desc=""},
                  new Streets(){Id = 5, NameStreet="Амосова", StreetTypesId=1, Desc=""},
                  new Streets(){Id = 6, NameStreet="Миколайчука", StreetTypesId=1, Desc=""}
           };
            modelBuilder.Entity<Streets>().HasData(streets);

            Houses[] houses = new Houses[]
            {
                  new Houses(){Id = 1, NumbHouse="28/1", Desc=""},
                  new Houses(){Id = 2, NumbHouse="266", Desc=""},
                  new Houses(){Id = 3, NumbHouse="14", Desc=""},
                  new Houses(){Id = 4, NumbHouse="10", Desc=""},
                  new Houses(){Id = 5, NumbHouse="6", Desc=""},
                  new Houses(){Id = 6, NumbHouse="9", Desc=""}
             };
            modelBuilder.Entity<Houses>().HasData(houses);

            Entrances[] entrances = new Entrances[]
            {
                  new Entrances(){Id = 1, NumbEntrance=1, Desc=""},
                  new Entrances(){Id = 2, NumbEntrance=2, Desc=""},
                  new Entrances(){Id = 3, NumbEntrance=3, Desc=""},
                  new Entrances(){Id = 4, NumbEntrance=4, Desc=""}
             };
            modelBuilder.Entity<Entrances>().HasData(entrances);

            Hospitals[] hospital = new Hospitals[]
            {
                  new Hospitals(){Id = 1,
                      NameHospital="НДСЛ «Охматдит»",
                      CityID=1, StreetID=1, HouseID=1, EntranceID=1,
                      Linc="https://ohmatdyt.com.ua/",
                      Desc="НДСЛ «Охматдит» – багатопрофільний діагностично-лікувальний заклад, який надає спеціалізовану висококваліфіковану медичну допомогу дитячому населенню України. Найбільша дитяча лікарня в Україні. На сьогодні НДСЛ «Охматдит» МОЗ України – сучасна лікувально-діагностична установа, де виконуються реконструктивно-пластичні операції, пересадка кісткового мозку (в т.ч. від неродинного донора), хірургічна корекція складних вроджених вад розвитку у новонароджених дітей, виходжування за сучасними технологіями глибоко недоношених дітей, онконейрохірургія, діагностика та лікування ретинопатії новонароджених, функціонує потужний медико-генетичний центр для діагностики та лікування рідкісних спадкових та генетичних захворювань у дітей тощо."},
                  new Hospitals(){Id = 2,
                      NameHospital="КНП Харківської обласної ради «Обласна клінічна травматологічна лікарня»",
                      CityID=4, StreetID=2, HouseID=2, EntranceID=2,
                      Linc="https://oktl.kh.ua/",
                      Desc="На сьогоднішній день Харківська обласна клінічна травматологічна лікарня - це провідний центр по роботі з ОДС. Ретельно підібраний персонал проводить діагностику, лікування та реабілітацію пацієнтів з найрізноманітнішими клінічними картинами. Головним правилом клініки травматології та ортопедії є дотримання комплексу декомпрессіонних вправ на спеціалізованих тренажерах. Під кожен випадок нами розробляється індивідуальна програма."},
                  new Hospitals(){Id = 3,
                      NameHospital="БО ДОБФ «Лікарня ім. І.І. МЕЧНИКОВА»",
                      CityID=2, StreetID=3, HouseID=3, EntranceID=1,
                      Linc="https://oktl.kh.ua/",
                      Desc="Дніпропетровська обласна клінічна лікарня імені І. І. Мечникова[2]  — одна з найстаріших багатопрофільних лікувальних медичних установ України, обласний центр спеціалізованої хірургічної допомоги."},
                  new Hospitals(){Id = 4,
                      NameHospital="Обласна клінічна лікарня відновного лікування та діагностики",
                      CityID=3, StreetID=4, HouseID=4, EntranceID=1,
                      Linc="http://www.oklvld.pl.ua/",
                      Desc="Обласна клінічна лікарня відновного лікування та діагностики, яка заснована 11 лютого 1947 року, сьогодні є одним з найсучасніших  лікувально-профілактичних закладів області."},
                  new Hospitals(){Id = 5,
                      NameHospital="Інститут серцево-судинної хірургії (ІССХ) АМН України",
                      CityID=1, StreetID=5, HouseID=5, EntranceID=1,
                      Linc="https://amosovinstitute.org.ua/",
                      Desc="Історія Інституту починається з 1955 року, коли на базі 24-ї міської лікарні м. Києва М. М. Амосовим була відкрита перша в Україні спеціалізована клініка серцевої хірургії, яка в 1957 р. перейшла до Українського НДІ туберкульозу, в 1961 р. перейменованого в Київський НДІ туберкульозу і грудної хірургії. В 1983 р. ця клініка серцевої хірургії реорганізована в Київський НДІ серцево-судинної хірургії Міністерства охорони здоров’я України, з 1993 р. – Інститут серцево-судинної хірургії (ІССХ) АМН України."},
                  new Hospitals(){Id = 6,
                      NameHospital="Центр трансплантології Першого медоб'єднання Львова",
                      CityID=5, StreetID=6, HouseID=6, EntranceID=1,
                      Linc="https://emergency-hospital.lviv.ua/tsentry/tsentr-transplantolohii",
                      Desc="Центр трансплантології Першого медоб'єднання Львова — лідер за кількістю пересаджених органів в Україні. Функціонує з 2020 року. Відтоді тут виконано понад 250 трансплантацій нирок, печінки, серця, легень та підшлункової залози. \r\nУсі медичні послуги з трансплантації оплачуються державним коштом. Тому для пацієнта трансплантація БЕЗКОШТОВНА."}
             };
            modelBuilder.Entity<Hospitals>().HasData(hospital);

            Wards[] wards = new Wards[]
           {
                  new Wards(){Id = 1,
                      NameWard="Відділення воєнної та інноваційної кардіохірургії",
                      HospitalID=5, CityID=1, StreetID=5, HouseID=5, EntranceID=1,
                      Linc="https://amosovinstitute.org.ua/2023/07/06/viddilennya-ekstrenoyi-ta-nevidkladnoyi-kardiohirurgiyi/",
                      Desc="Історично це було перше відділення кардіо-торакальної хірургії на базі Київського НДІ серцево-судинної хірургії МОЗ України, засноване М.М. Амосовим. З моменту створення і по теперішній час кураторами відділу завжди були директори Інституту, академіки, – спершу М.М. Амосов, потім Г.В. Книшов, на теперішній час – В.В. Лазоришинець.\r\n\r\nЩорічно у відділенні оперують в середньому 600 пацієнтів. Хірургічна активність включає увесь спектр кардіохірургічних втручань: лікування ішемічної хвороби серця (як інтервенційне – експертні стентування стовбурових уражень, стентування при багатосудинному ураженні пацієнтів з високим кардіохірургічним ризиком та пацієнтів з обтяженою коморбідністю, так і хірургічне), критичних клапанних вад серця (набуті та вроджені), життєвозагрозливих порушень ритму серця, патології аорти (як ендоваскулярне, так і хірургічне), захворювання перикарду, плеври, міокарду (ГКМП, ДКМП, амілоїдоз, міокардити), хірургічне лікування аневризм лівого шлуночка та постінфарктні розриви міжшлуночкової перетинки. Більшість кардіохірургічних втручань з реваскуляризації міокарду відбуваються на працюючому серці (off-pump CABG у 96% випадків). У межах відділення виконуються також операції з міні-доступу (шунтування MIDCAB) та тотальна артеріальна реваскуляризація (TAR)."},
                  new Wards(){Id = 2,
                      NameWard="Відділення хірургічного лікування патології міокарда, трансплантації та механічної підтримки серця і легень",
                      HospitalID=5, CityID=1, StreetID=5, HouseID=5, EntranceID=1,
                      Linc="https://amosovinstitute.org.ua/2023/07/03/viddil-hirurgichnogo-likuvannya-sertsevoyi-nedostatnosti-ta-mehanichnoyi-pidtrimki-sertsya-i-legen/",
                      Desc="ОСНОВНІ НАПРЯМИ РОБОТИ:\r\n\r\nТрансплантація серця та робота над впровадженням в рутинну практику трансплантації комплексу легені-серце та імплантації пристроїв механічної підтримки кровообігу;\r\nОперативне, інтервенційне та терапевтичне лікування всіх варіантів кардіоміопатій та хронічної серцевої недостатності із застосуванням найсучасніших методик інвазивних та консервативних втручань;\r\nУнікальна операція Феррацці при гіпертрофічній кардіоміопатії з високими показниками якості життя у віддаленому періоді. Досягнуто найвищого європейського рівня виконаних операцій Феррацці за рік.\r\nТранскатетерна алкогольна септальна абляція, як альтернатива у пацієнтів з гіпертрофічною кардіоміопатією при наявності протипоказань до відкритих оперативних втручань;\r\nІмплантація ресинхронізаційних штучних водіїв ритму серця при кардіоміопатіях з важкими порушеннями серцевої провідності;\r\nПротезування та пластичні операції для корекція клапанних вад серця, у тому числі у пацієнтів зі зниженою фракцією викиду лівого шлуночка;\r\nЄвропейський підхід до стратегії медикаментозного лікування та хірургії. Більшість лікарів відділення пройшли тривалі стажування у провідних клініках Європи."},
                  new Wards(){Id = 3,
                      NameWard="Відділення хірургічного лікування вроджених вад серця у новонароджених та дітей молодшого віку",
                      HospitalID=5, CityID=1, StreetID=5, HouseID=5, EntranceID=1,
                      Linc="Відділення хірургічного лікування вроджених вад серця у новонароджених та дітей молодшого віку",
                      Desc="Відділення хірургічного лікування вроджених вад серця у новонароджених та дітей молодшого віку"},
                  new Wards(){Id = 4,
                      NameWard="Відділення дитячої нейрохірургії", HospitalID=1, CityID=1, StreetID=1, HouseID=1, EntranceID=1,
                      Linc="https://ohmatdyt.com.ua/viddilennya-nejrohirurgiyi/",
                      Desc="Відділення дитячої нейрохірургії створено  у 2018 році з метою покращення надання високоспеціалізованої медичної допомоги дітям з нейрохірургічною патологією. У відділенні надається висококваліфікована медична допомога дітям у віці від 0 до 18 років із різноманітною нейрохірургічною патологією. Відділення є клінічною базою кафедри дитячої хірургії Національного медичного університету ім. О.О. Богомольця."},
                  new Wards(){Id = 5,
                      NameWard="Відділення інтенсивної та еферентної терапії хронічних інтоксикацій зі стаціонаром денного перебування",
                      HospitalID=1, CityID=1, StreetID=1, HouseID=1, EntranceID=1,
                      Linc="HospitalID=1, CityID=1, StreetID=1, HouseID=1, EntranceID=1,",
                      Desc="Відділення інтенсивної терапії хронічних інтоксикацій складається з 25 ліжок з 4 ліжками денного стаціонару. У відділенні знаходяться на лікуванні діти від 0 до 18 років з термінальною стадією ниркової недостатності, які потребують проведення замісної ниркової терапії."},
                  new Wards(){Id = 6,
                      NameWard="Відділення відновлювального лікування\r\n",
                      HospitalID=1, CityID=1, StreetID=1, HouseID=1, EntranceID=1,
                      Linc="https://ohmatdyt.com.ua/viddilennya-vidnovnogo-likuvannya/",
                      Desc="Вiддiлення відновлювального лікування є одним iз пiдроздiлiв Національної дитячої спеціалізованої лiкарнi “Охматдит”. Основним завданням його с надання профілактичної, лікувальної та реабілітаційної допомоги дітям, які знаходяться на стаціонарному лікуванні."},
                  new Wards(){Id = 7,
                      NameWard="Відділення інтенсивної хіміотерапії",
                      HospitalID=1, CityID=1, StreetID=1, HouseID=1, EntranceID=1,
                      Linc="Відділення інтенсивної хіміотерапії",
                      Desc="Відділення інтенсивної хіміотерапії надає високоспеціалізовану консультативну та лікувальну медичну допомогу дітям  з різних регіонів України з онкогематологічними та гематологічними захворюваннями  на основі сучасних методів діагностики, комплексного лікування у відповідності до міжнародних стандартів діагностики та лікування дітей з онкогематологічними та гематологічними захворюваннями, затвердженими МОЗ України. У відділенні впроваджуються передові методи лікування гемобластозів, найбільш ефективні терапевтичні протоколи, пілотні програми, комбіновані технології лікування."}
           };
            modelBuilder.Entity<Wards>().HasData(wards);

            Surnames[] surnames = new Surnames[]
           {
                  new Surnames(){Id = 1, Surname="Мельник", Desc=""},
                  new Surnames(){Id = 2, Surname="Шевченко", Desc=""},
                  new Surnames(){Id = 3, Surname="Коваленко", Desc=""},
                  new Surnames(){Id = 4, Surname="Бондаренко", Desc=""},
                  new Surnames(){Id = 5, Surname="Бойко", Desc=""},
                  new Surnames(){Id = 6, Surname="Ткаченко", Desc=""},
                  new Surnames(){Id = 7, Surname="Кравченко", Desc=""},
                  new Surnames(){Id = 8, Surname="Ковальчук", Desc=""},
                  new Surnames(){Id = 9, Surname="Коваль", Desc=""},
                  new Surnames(){Id = 10, Surname="Олійник", Desc=""},
                  new Surnames(){Id = 11, Surname="Акименко", Desc=""},
                  new Surnames(){Id = 12, Surname="Бабченко", Desc=""},
                  new Surnames(){Id = 13, Surname="Багрій", Desc=""},
                  new Surnames(){Id = 14, Surname="Багрій", Desc=""},
                  new Surnames(){Id = 15, Surname="Максимейко", Desc=""},
                  new Surnames(){Id = 16, Surname="Сало", Desc=""},
                  new Surnames(){Id = 17, Surname="Грінка", Desc=""},
                  new Surnames(){Id = 18, Surname="Стопка", Desc=""}
            };
            modelBuilder.Entity<Surnames>().HasData(surnames);

            Names[] names = new Names[]
           {
                  new Names(){Id = 1, Name="Андрій", Desc=""},
                  new Names(){Id = 2, Name="Анна", Desc=""},
                  new Names(){Id = 3, Name="Артем", Desc=""},
                  new Names(){Id = 4, Name="Вікторія", Desc=""},
                  new Names(){Id = 5, Name="Богдан", Desc=""},
                  new Names(){Id = 6, Name="Єва", Desc=""},
                  new Names(){Id = 7, Name="Давид", Desc=""},
                  new Names(){Id = 8, Name="Злата", Desc=""},
                  new Names(){Id = 9, Name="Данило", Desc=""},
                  new Names(){Id = 10, Name="Катерина", Desc=""},
                  new Names(){Id = 11, Name="Дмитро", Desc=""},
                  new Names(){Id = 12, Name="Мирослава", Desc=""},
                  new Names(){Id = 13, Name="Максим", Desc=""},
                  new Names(){Id = 14, Name="Марія", Desc=""},
                  new Names(){Id = 15, Name="Матвій", Desc=""},
                  new Names(){Id = 16, Name="Мілана", Desc=""},
                  new Names(){Id = 17, Name="Марк", Desc=""},
                  new Names(){Id = 18, Name="Софія", Desc=""},
                  new Names(){Id = 19, Name="Микола", Desc=""},
                  new Names(){Id = 20, Name="Соломія", Desc=""},
                  new Names(){Id = 21, Name="Олександр", Desc=""},
                  new Names(){Id = 22, Name="Джульєта", Desc=""},
                  new Names(){Id = 23, Name="Відар", Desc=""},
                  new Names(){Id = 24, Name="Юстінія", Desc=""},
                  new Names(){Id = 25, Name="Ілай", Desc=""},
                  new Names(){Id = 26, Name="Марина", Desc=""},
                  new Names(){Id = 27, Name="Іван", Desc=""},
                  new Names(){Id = 28, Name="Жива", Desc=""},
                  new Names(){Id = 29, Name="Василь", Desc=""},
                  new Names(){Id = 30, Name="Ольга", Desc=""}

            };
            modelBuilder.Entity<Names>().HasData(names);

            Patronymics[] patronymics = new Patronymics[]
            {
                  new Patronymics(){Id = 1, Patronymic="Миколайович", Desc=""},
                  new Patronymics(){Id = 2, Patronymic="Миколаївна", Desc=""},
                  new Patronymics(){Id = 3, Patronymic="Володимирович", Desc=""},
                  new Patronymics(){Id = 4, Patronymic="Володимирівна", Desc=""},
                  new Patronymics(){Id = 5, Patronymic="Олександрович", Desc=""},
                  new Patronymics(){Id = 6, Patronymic="Олександрівна", Desc=""},
                  new Patronymics(){Id = 7, Patronymic="Іванович", Desc=""},
                  new Patronymics(){Id = 8, Patronymic="Іванівна", Desc=""},
                  new Patronymics(){Id = 9, Patronymic="Васильович", Desc=""},
                  new Patronymics(){Id = 10, Patronymic="Василівна", Desc=""},
                  new Patronymics(){Id = 11, Patronymic="Сергійович", Desc=""},
                  new Patronymics(){Id = 12, Patronymic="Сергіївна", Desc=""},
                  new Patronymics(){Id = 13, Patronymic="Вікторович", Desc=""},
                  new Patronymics(){Id = 14, Patronymic="Вікторівна", Desc=""},
                  new Patronymics(){Id = 15, Patronymic="Михайлович", Desc=""},
                  new Patronymics(){Id = 16, Patronymic="Михайлівна", Desc=""}
            };
            modelBuilder.Entity<Patronymics>().HasData(patronymics);

            Roles[] role = new Roles[]
            {
                  new Roles(){Id = 1,
                      NameRole="admin",
                      Desc="Адміністратор з повними правами дотупа"},
                  new Roles(){Id = 2,
                      NameRole="hospitalsRepresent",
                      Desc="Предтавник медичного закладу, має доступ на створення нової картки пацієнта та перегляду всіх зборів його мадичного закладу"},
                  new Roles(){Id = 3,
                      NameRole="partner",
                      Desc="Предтавни партнера, має дотуп на перегляд всіх зборів, та окремо зборів, яким було надано допомогу даним партнером"},
                  new Roles(){Id = 4,
                      NameRole="benefactorRegistered",
                      Desc="БлагодійникЮ, що зареєструвався на платформі. Має дотуп на перегляд всіх актуальних зборів, та окремо зборів, яким було надано допомогу даним благодійником(в тому числі  закритих)"},
                  new Roles(){Id = 5,
                      NameRole="benefactorGuest",
                      Desc="БлагодійникЮ, що не зареєструваний на платформі. Має дотуп на перегляд всіх актуальних зборів" }
            };
            modelBuilder.Entity<Roles>().HasData(role);

            Positions[] position = new Positions[]
            {
                  new Positions(){Id = 1, NamePositions="Лікар", Desc=""},
                  new Positions(){Id = 2, NamePositions="Лікар-лаборант", Desc=""},
                  new Positions(){Id = 3, NamePositions="Лікар-інтерн", Desc=""},
                  new Positions(){Id = 4, NamePositions="Лікар-методист", Desc=""},
                  new Positions(){Id = 5, NamePositions="Лікар-стажист", Desc=""},
                  new Positions(){Id = 6, NamePositions="Лаборант", Desc=""},
                  new Positions(){Id = 7, NamePositions="Сестра медична", Desc=""},
                  new Positions(){Id = 8, NamePositions="Фельдшер", Desc=""},
                  new Positions(){Id = 9, NamePositions="Реєстратор медичний", Desc=""},
                  new Positions(){Id = 10, NamePositions="Молодша медична сестра", Desc=""},
                  new Positions(){Id = 11, NamePositions="Старша медична сестра", Desc=""}
            };
            modelBuilder.Entity<Positions>().HasData(position);

            HospitalsRepresentatives[] hospitalsRepresentative = new HospitalsRepresentatives[]
            {
                  new HospitalsRepresentatives(){Id = 1,
                      SurnameID=16, NameID=14, PatronymicID=8,
                      CityID=1,
                      HospitalID=1, WardID=4,
                      PositionID=3, RoleID=2,
                      ContactPhone="0678943567", Email="Hosp1ward1@gmail.com",
                      Login ="Hosp1ward1", Password="Hosp1ward1",
                      GenderID=2, BirthDate= new DateTime(1987,05,09), Notate=""},
                  new HospitalsRepresentatives(){Id = 2,
                      SurnameID=8, NameID=6, PatronymicID=16,
                      CityID=1,
                      HospitalID=1, WardID=5,
                      PositionID=8, RoleID=2,
                      ContactPhone="0665483157", Email="Hosp1ward2@gmail.com",
                      Login ="Hosp1ward2", Password="Hosp1ward2",
                      GenderID=2, BirthDate= new DateTime(1989,11,01), Notate=""},
                  new HospitalsRepresentatives(){Id = 3,
                      SurnameID=11, NameID=13, PatronymicID=15,
                      CityID=1,
                      HospitalID=1, WardID=6,
                      PositionID=2, RoleID=2, ContactPhone="0667842357", Email="Hosp1ward3@gmail.com",
                      Login ="Hosp1ward3", Password="Hosp1ward3",
                      GenderID=1, BirthDate= new DateTime(1974,03,12), Notate=""},
                  new HospitalsRepresentatives(){Id = 4,
                      SurnameID=6, NameID=12, PatronymicID=14,
                      CityID=1,
                      HospitalID=1, WardID=7,
                      PositionID=7, RoleID=2,
                      ContactPhone="0554236987", Email="Hosp1ward4@gmail.com",
                      Login ="Hosp1ward4", Password="Hosp1ward4",
                      GenderID=2, BirthDate= new DateTime(1969,02,08), Notate=""},
                  new HospitalsRepresentatives(){Id = 5,
                      SurnameID=4, NameID=8, PatronymicID=10,
                      CityID=4,
                      HospitalID=2, WardID=null,
                      PositionID=5, RoleID=2,
                      ContactPhone="0654215854", Email="Hosp2@gmail.com",
                      Login ="Hosp2", Password="Hosp2",
                      GenderID=1, BirthDate= new DateTime(1968,11,11), Notate=""},
                  new HospitalsRepresentatives(){Id = 6,
                      SurnameID=9, NameID=2, PatronymicID=8,
                      CityID=2,
                      HospitalID=3, WardID=null,
                      PositionID=6, RoleID=2,
                      ContactPhone="0993265789", Email="Hosp3@gmail.com",
                      Login ="Hosp3", Password="Hosp3",
                      GenderID=2, BirthDate= new DateTime(1975,12,12), Notate=""},
                  new HospitalsRepresentatives(){Id = 7,
                      SurnameID=5, NameID=4, PatronymicID=6,
                      CityID=3,
                      HospitalID=4, WardID=null,
                      PositionID=1, RoleID=2,
                      ContactPhone="", Email="Hosp4@gmail.com",
                      Login ="Hosp4", Password="Hosp4",
                      GenderID=2, BirthDate= new DateTime(1975,07,04), Notate=""},
                  new HospitalsRepresentatives(){Id = 8,
                      SurnameID=13, NameID=5, PatronymicID=11,
                      CityID=1,
                      HospitalID=5, WardID=1,
                      PositionID=4, RoleID=2,
                      ContactPhone="0954615795", Email="Hosp5ward1@gmail.com",
                      Login ="Hosp5ward1", Password="Hosp5ward1",
                      GenderID=1, BirthDate= new DateTime(1979,10,12), Notate=""},
                  new HospitalsRepresentatives(){Id = 9,
                      SurnameID=10, NameID=16, PatronymicID=12,
                      CityID=1,
                      HospitalID=5, WardID=2,
                      PositionID=9, RoleID=2,
                      ContactPhone="0553491267", Email="Hosp5ward2@gmail.com",
                      Login ="Hosp5ward1", Password="Hosp5ward1",
                      GenderID=2, BirthDate= new DateTime(1985,08,01), Notate=""},
                  new HospitalsRepresentatives(){Id = 10,
                      SurnameID=7, NameID=18, PatronymicID=10,
                      CityID=1,
                      HospitalID=5, WardID=3,
                      PositionID=11, RoleID=2,
                      ContactPhone="0684815123", Email="Hosp5ward3@gmail.com",
                      Login ="Hosp5ward3", Password="Hosp5ward3",
                      GenderID=2, BirthDate= new DateTime(1990,06,09), Notate=""},
                  new HospitalsRepresentatives(){Id = 11,
                      SurnameID=12, NameID=2, PatronymicID=14,
                      CityID=5,
                      HospitalID=6, WardID=null,
                      PositionID=10, RoleID=2,
                      ContactPhone="0501278456", Email="Hosp6@gmail.com",
                      Login ="Hosp6", Password="Hosp6",
                      GenderID=2, BirthDate= new DateTime(1989,03,09), Notate=""}
             };
            modelBuilder.Entity<HospitalsRepresentatives>().HasData(hospitalsRepresentative);

            Diagnoses[] diagnose = new Diagnoses[]
           {
                  new Diagnoses(){Id = 1, NameDiagnosis="Проникаюче поранення суглоба", Desc=""},
                  new Diagnoses(){Id = 2, NameDiagnosis="Вибухове поранення множинне лівої нижньої кінціки", Desc=""},
                  new Diagnoses(){Id = 3, NameDiagnosis="Проникаюче поранення живота", Desc=""},
                  new Diagnoses(){Id = 4, NameDiagnosis="Аномалія Ебштейна", Desc=""},
                  new Diagnoses(){Id = 5, NameDiagnosis="Тетрада Фалло", Desc=""},
                  new Diagnoses(){Id = 6, NameDiagnosis="Кардіоміопатія", Desc=""},
                  new Diagnoses(){Id = 7, NameDiagnosis="Проникаюче поранення грудної порожнини", Desc=""},
                  new Diagnoses(){Id = 8, NameDiagnosis="Хронічна серцева недостатность", Desc=""},
                  new Diagnoses(){Id = 9, NameDiagnosis="Мієлодиспластичний синдром", Desc=""},
                  new Diagnoses(){Id = 10, NameDiagnosis="Апластична анемія", Desc=""},
                  new Diagnoses(){Id = 11, NameDiagnosis="Хронічна ниркова  недостатність (ХНН V)", Desc=""},
                  new Diagnoses(){Id = 12, NameDiagnosis="Пухлина головного мозку", Desc=""},
                  new Diagnoses(){Id = 13, NameDiagnosis="Пухлина головного мозку", Desc=""},
                  new Diagnoses(){Id = 14, NameDiagnosis="Гідроцефалія набута", Desc=""},
                  new Diagnoses(){Id = 15, NameDiagnosis="Вроджена дисплазія тазостегнових суглобів", Desc=""},
                  new Diagnoses(){Id = 16, NameDiagnosis="Травма спинного мозку і хребта", Desc=""},
                  new Diagnoses(){Id = 17, NameDiagnosis="Хронічний гепатит С", Desc=""},
                  new Diagnoses(){Id = 18, NameDiagnosis="Лейкемія", Desc=""},
                  new Diagnoses(){Id = 19, NameDiagnosis="Гостаю лімфобластна лейкемія", Desc=""},
                  new Diagnoses(){Id = 20, NameDiagnosis="Обширні опіки", Desc=""},
                  new Diagnoses(){Id = 21, NameDiagnosis="Інсульт", Desc=""}

           };
            modelBuilder.Entity<Diagnoses>().HasData(diagnose);

            FundraisingStatuses[] fundraisingStatus = new FundraisingStatuses[]
           {
                  new FundraisingStatuses(){Id = 1,
                      NameFundraisingStatus="Актуально",
                      Desc="Відкритий, мета збору не досягнуа, час збору не завершився"},
                  new FundraisingStatuses(){Id = 2,
                      NameFundraisingStatus="Призупинено",
                      Desc="Призупинений через певні об'єктивні причини"},
                  new FundraisingStatuses(){Id = 3,
                      NameFundraisingStatus="Завершено",
                      Desc="Завершено недосягнувши Мети"},
                  new FundraisingStatuses(){Id = 4,
                      NameFundraisingStatus="Закрито",
                      Desc="Мета досягнуа, збір закрито"}
           };
            modelBuilder.Entity<FundraisingStatuses>().HasData(fundraisingStatus);

            Patients[] patient = new Patients[]
            {
                
                  new Patients(){Id = 1,
                      SurnameID=1,
                      NameID=7,
                      PatronymicID=7,
                      GenderID=1,
                      CategoryID=3, TreatmentCategoryID=1,  DiagnosisID=1,
                      CityID=5, HospitalID=4, WardID=null,
                      FeeAmount=180000,
                      Bank_card_number="1568456978544123", Bank_account="UA010000001568456978544123", Inn="1568456978", FundraisingStatusID=1,
                      BirthDate = new DateTime(1990,03,05),
                      Descript_patient_and_disease="Лікування наслідків поранення для захисника Давида",
                      Notate="При виконанні бойового завдання на Донецькому напрямі, Давид отримав важке проникаюче поранення суглоба. " +
                      "Без відповідного лікування Давид не зможе ходити. " +
                      "Для відновлення функцій кінцівки захисник потребує оперативного втручання з подальшим лікування. Операція буде зроблена в центрі трансплантології Першого медоб'єднання Львова."},
                  new Patients(){Id = 2,
                      SurnameID=4,
                      NameID=10,
                      PatronymicID=2,
                      GenderID=2,
                      CategoryID=1, TreatmentCategoryID=1,  DiagnosisID=8,
                      CityID=2, HospitalID=5, WardID=2,
                      FeeAmount=230000,
                      Bank_card_number="1246796423589124", Bank_account="UA010000001246796423589124", Inn="1246796423", FundraisingStatusID=2,
                      BirthDate = new DateTime(1982,02,07),
                      Descript_patient_and_disease="Лікування сердцевої недотатності для Каті",
                      Notate="Катерині був поставлений діагноз Хронічна серцева недостатность. " +
                      "Лікування відбувається в Відділенні хірургічного лікування патології міокарда, трансплантації та механічної підтримки серця і легень Інституту серцево-судинної хірургії (ІССХ) АМН України"},
                  new Patients(){Id = 3,
                      SurnameID=7,
                      NameID=1,
                      PatronymicID=9,
                      GenderID=1,
                      CategoryID=3, TreatmentCategoryID=3,  DiagnosisID=2,
                      CityID=1, HospitalID=6, WardID=null,
                      FeeAmount=600000,
                      Bank_card_number="4563789542631284", Bank_account="UA010000004563789542631284", Inn="4563789542", FundraisingStatusID=1,
                      BirthDate = new DateTime(1991,06,08),
                      Descript_patient_and_disease="Протезування для захисника Андрія",
                      Notate="При виконанні бойового завдання під Часовим Яром, Андрій отримав важке Вибухове поранення множинне лівої нижньої кінціки. " +
                      "Йому необхідне лікування та протезування після ампутації кінцівки. Операція буде зроблена в  Центрі трансплантології Першого медоб'єднання Львова"},
                  new Patients(){Id = 4,
                      SurnameID=11,
                      NameID=2,
                      PatronymicID=8,
                      GenderID=2,
                      CategoryID=2, TreatmentCategoryID=2,  DiagnosisID=5,
                      CityID=3, HospitalID=5, WardID=3,
                      FeeAmount=250000,
                      Bank_card_number="2596345678412578", Bank_account="UA010000002596345678412578", Inn="2596345678", FundraisingStatusID=4,
                      BirthDate = new DateTime(2023,06,08),
                      Descript_patient_and_disease="Реабілітація для маленької Ані",
                      Notate="Анні поставили важкий діагноз Тетрада Фалло. Наразі дитина потребує довготривалої та дуже коштовної реабілітації. " +
                      "Реабілітація відбуваєья в відділення хірургічного лікування вроджених вад серця у новонароджених та дітей молодшого віку Інституту серцево-судинної хірургії (ІССХ) АМН України"},
                  new Patients(){Id = 5,
                      SurnameID=5,
                      NameID=4,
                      PatronymicID=6,
                      GenderID=2,
                      CategoryID=2, TreatmentCategoryID=1,  DiagnosisID=10,
                      CityID=1, HospitalID=1, WardID=7,
                      FeeAmount=400000,
                      Bank_card_number="5489632452478965", Bank_account="UA010000005489632452478965", Inn="5489632452", FundraisingStatusID=1,
                      BirthDate = new DateTime(2019,08,09),
                      Descript_patient_and_disease="Лікування апластичної анімії для маленької Віки",
                      Notate="У Вікторії виявили Апластичну анемію. " +
                      "Лікування дитини довготривале та дуже дороге.  Лікування відбувається в Відділенні інтенсивної хіміотерапії НДСЛ «Охматдит»"},
                  new Patients(){Id = 6,
                      SurnameID=3,
                      NameID=8,
                      PatronymicID=4,
                      GenderID=2,
                      CategoryID=2, TreatmentCategoryID=1,  DiagnosisID=12,
                      CityID=4, HospitalID=1, WardID=4,
                      FeeAmount=360000,
                      Bank_card_number="2587963245617896", Bank_account="UA010000002587963245617896", Inn="2587963245", FundraisingStatusID=3,
                      BirthDate = new DateTime(2018,05,09),
                      Descript_patient_and_disease="Операція з видалення пухлини головного мозку для Злаочки",
                      Notate="У Злати виявили Пухлину головного мозку. Дитина поребує перації та довготривалого та дуже дорогого лікування. \" +\r\n                      \"Операція буде проведена в Відділені дитячої нейрохірургії НДСЛ «Охматдит»"},
                  new Patients(){Id = 7,
                      SurnameID=2,
                      NameID=9,
                      PatronymicID=3,
                      GenderID=1,
                      CategoryID=3, TreatmentCategoryID=1,  DiagnosisID=3,
                      CityID=5, HospitalID=3, WardID=null,
                      FeeAmount=170000,
                      Bank_card_number="2574128956122345", Bank_account="UA010000002574128956122345", Inn="2574128956", FundraisingStatusID=1,
                      BirthDate = new DateTime(1988,06,07),
                      Descript_patient_and_disease="Лікування наслідків поранення захисника Данила",
                      Notate="При виконанні бойового завдання на Донеччині, Данило отримав Проникаюче поранення живота. " +
                      "Неообхідне термінове оперативне втручання для відновлення роботи органів черевної порожнини та подальше лікування. " +
                      "Операція та лікування будуть здійснені в БО ДОБФ «Лікарня ім. І.І. МЕЧНИКОВА»"},
                  new Patients(){Id = 8,
                      SurnameID=13,
                      NameID=5,
                      PatronymicID=11,
                      GenderID=1,
                      CategoryID=2, TreatmentCategoryID=2,  DiagnosisID=14,
                      CityID=3, HospitalID=1, WardID=6,
                      FeeAmount=90000,
                      Bank_card_number="2893567817393719", Bank_account="UA010000002893567817393719", Inn="2893567817", FundraisingStatusID=1,
                      BirthDate = new DateTime(2018,08,04),
                      Descript_patient_and_disease="Реабілітація після лікування Гідроцефалії набутої для Богданчика",
                      Notate="У Богдана виявили Гідроцефалію набуту. Реабілітація дитини довготривала та дуже дорога. " +
                      "Лікування відбувається в Відділенні відновлювального лікування НДСЛ «Охматдит»"},
                  new Patients(){Id = 9,
                      SurnameID=6,
                      NameID=9,
                      PatronymicID=5,
                      GenderID=1,
                      CategoryID=2, TreatmentCategoryID=1,  DiagnosisID=11,
                      CityID=1, HospitalID=1, WardID=5,
                      FeeAmount=350000,
                      Bank_card_number="7595426215354868", Bank_account="UA010000007595426215354868", Inn="7595426215", FundraisingStatusID=4,
                      BirthDate = new DateTime(2021,06,07),
                      Descript_patient_and_disease="Ліування Хронічної ниркової недостатності (ХНН V) для Данилка",
                      Notate="У Данила виявили Хронічну ниркова  недостатність (ХНН V). Лікування дитини довготривале та дуже дороге." +
                      " Лікування відбувається в Відділенні інтенсивної та еферентної терапії хронічних інтоксикацій зі стаціонаром денного перебування НДСЛ «Охматдит»"},
                  new Patients(){Id = 10,
                      SurnameID=8,
                      NameID=6,
                      PatronymicID=10,
                      GenderID=2,
                      CategoryID=2, TreatmentCategoryID=1,  DiagnosisID=4,
                      CityID=4, HospitalID=5, WardID=3,
                      FeeAmount=620000,
                      Bank_card_number="2165784598542345", Bank_account="UA010000002165784598542345", Inn="2165784598", FundraisingStatusID=1,
                      BirthDate = new DateTime(2024,02,05),
                      Descript_patient_and_disease="Ліування Аномалії Ебштейна для Євочки",
                      Notate="У Єва виявили Аномалію Ебштейна." +
                      " Лікування відбувається у Відділенні хірургічного лікування вроджених вад серця у новонароджених та дітей молодшого віку Інститут серцево-судинної хірургії (ІССХ) АМН України"},
                  new Patients(){Id = 11,
                      SurnameID=9,
                      NameID=11,
                      PatronymicID=15,
                      GenderID=1,
                      CategoryID=3, TreatmentCategoryID=1,  DiagnosisID=7,
                      CityID=5, HospitalID=5, WardID=1,
                      FeeAmount=420000,
                      Bank_card_number="2596368514857452", Bank_account="UA010000002596368514857452", Inn="2596368514", FundraisingStatusID=3,
                      BirthDate = new DateTime(1990,06,07),
                      Descript_patient_and_disease="Операція на сердці для захиника Дмитра",
                      Notate="Перебуваючи на позиції, Дмитро отримав Проникаюче поранення грудної порожнини. " +
                      "Йому необхідна операція на сердці. Операція та подальша реабілітація будуть здійснені в Відділенні воєнної та інноваційної кардіохірургії " +
                      "Інституту серцево-судинної хірургії (ІССХ) АМН України"},
                  new Patients(){Id = 12,
                      SurnameID=11,
                      NameID=14,
                      PatronymicID=12,
                      GenderID=2,
                      CategoryID=2, TreatmentCategoryID=2,  DiagnosisID=9,
                      CityID=1, HospitalID=1, WardID=6,
                      FeeAmount=120000,
                      Bank_card_number="3694561275429863", Bank_account="UA010000003694561275429863", Inn="3694561275", FundraisingStatusID=1,
                      BirthDate = new DateTime(2011,09,08),
                      Descript_patient_and_disease="Реабілітація після лікування Мієлодиспластичного синдрому для Марійки",
                      Notate="Марії поставили діагноз Мієлодиспластичний синдром.  Лікування дитини довготривале та дуже дороге.  " +
                      "Лікування відбувається в Відділенні відновлювального лікування НДСЛ «Охматдит»"},
                  new Patients(){Id = 13,
                      SurnameID=14,
                      NameID=12,
                      PatronymicID=16,
                      GenderID=2,
                      CategoryID=2, TreatmentCategoryID=1,  DiagnosisID=9,
                      CityID=2, HospitalID=1, WardID=7,
                      FeeAmount=460000,
                      Bank_card_number="3644552388964543", Bank_account="UA010000003644552388964543", Inn="3644552388", FundraisingStatusID=1,
                      BirthDate = new DateTime(2017,06,02),
                      Descript_patient_and_disease="Лікування Мієлодиспластичного синдрому для Мирославочки»",
                      Notate="Мирославі поставили діагноз Мієлодиспластичний синдром. Лікування дитини довготривале та дуже дороге. " +
                      "Лікування відбувається в Відділенні інтенсивної хіміотерапії НДСЛ «Охматдит»"},
                  new Patients(){Id = 14,
                      SurnameID=12,
                      NameID=16,
                      PatronymicID=14,
                      GenderID=2,
                      CategoryID=2, TreatmentCategoryID=1,  DiagnosisID=13,
                      CityID=4, HospitalID=1, WardID=4,
                      FeeAmount=600000,
                      Bank_card_number="5645122378896554", Bank_account="UA010000005645122378896554", Inn="5645122378", FundraisingStatusID=1,
                      BirthDate = new DateTime(2017,03,08),
                      Descript_patient_and_disease="Оперування Пухлини головного мозку для Міланочки",
                      Notate="У Мілани виявили Пухлину головного мозку. Їй терміново необхідна складна операція. " +
                      "Лікування відбувається в Відділенні дитячої нейрохірургії НДСЛ «Охматдит»"},
                  new Patients(){Id = 15,
                      SurnameID=16,
                      NameID=13,
                      PatronymicID=13,
                      GenderID=1,
                      CategoryID=1, TreatmentCategoryID=2,  DiagnosisID=8,
                      CityID=1, HospitalID=5, WardID=2,
                      FeeAmount=60000,
                      Bank_card_number="2585963674148213", Bank_account="UA010000002585963674148213", Inn="2585963674", FundraisingStatusID=1,
                      BirthDate = new DateTime(1987,04,09),
                      Descript_patient_and_disease="Реабілітація після довготривалого лікування Хронічної серцевої недостатністі для Максима",
                      Notate="Максиму поставили діагноз Хронічна серцева недостатность. Лікування дитини довготривале та дуже дороге. " +
                      "Лікування відбувається в Відділенні хірургічного лікування патології міокарда, трансплантації та механічної підтримки серця і легень " +
                      "Інститут серцево-судинної хірургії (ІССХ) АМН України"},
                  new Patients(){Id = 16,
                      SurnameID=15,
                      NameID=19,
                      PatronymicID=11,
                      GenderID=1,
                      CategoryID=1, TreatmentCategoryID=4,  DiagnosisID=8,
                      CityID=2, HospitalID=5, WardID=2,
                      FeeAmount=120000,
                      Bank_card_number="3695784365214896", Bank_account="UA010000003695784365214896", Inn="3695784365", FundraisingStatusID=1,
                      BirthDate = new DateTime(1964,05,06),
                      Descript_patient_and_disease="Підтримка житедіялноті для Миколи з діагнозом Хронічна серцева недостатність",
                      Notate="Миколі поставили діагноз  Хронічна серцева недостатность. Лікування дитини довготривале та дуже дороге. " +
                      "Лікування відбувається в Відділенні хірургічного лікування патології міокарда, трансплантації та механічної підтримки серця і легень  " +
                      "Інститут серцево-судинної хірургії (ІССХ) АМН України"},
                  new Patients(){Id = 17,
                      SurnameID=17,
                      NameID=11,
                      PatronymicID=9,
                      GenderID=1,
                      CategoryID=3, TreatmentCategoryID=2,  DiagnosisID=2,
                      CityID=2, HospitalID=4, WardID=null,
                      FeeAmount=70000,
                      Bank_card_number="6456532123575455", Bank_account="UA010000006456532123575455", Inn="6456532123", FundraisingStatusID=1,
                      BirthDate = new DateTime(1986,06,07),
                      Descript_patient_and_disease="Реабілітація для захисника Дмитра після протезування",
                      Notate="Дмитро Вибухове поранення множинне лівої нижньої кінцівки  Йому необхідне лікування та реабілітація після протезування. " +
                      "Лікування відбувається в Обласній клінічній лікарня відновного лікування та діагностики"},
                  new Patients(){Id = 18,
                      SurnameID=12,
                      NameID=15,
                      PatronymicID=7,
                      GenderID=1,
                      CategoryID=3, TreatmentCategoryID=2,  DiagnosisID=3,
                      CityID=2, HospitalID=3, WardID=null,
                      FeeAmount=150000,
                      Bank_card_number="7645289634567812", Bank_account="UA010000007645289634567812", Inn="7645289634", FundraisingStatusID=2,
                      BirthDate = new DateTime(1988,08,07),
                      Descript_patient_and_disease="Реабілітація після тяжкої операції для захиника Матвія",
                      Notate="Виконуючи бойове завдання, Матвій отримав тяжке Проникаюче поранення живота. " +
                      "Він потрибує проведення реабілітації після важкої та коштовної операції. Реабілітація буде в БО ДОБФ «Лікарня ім. І.І. МЕЧНИКОВА»"},
                  new Patients(){Id = 19,
                      SurnameID=14,
                      NameID=16,
                      PatronymicID=8,
                      GenderID=2,
                      CategoryID=1, TreatmentCategoryID=1,  DiagnosisID=11,
                      CityID=5, HospitalID=6, WardID=null,
                      FeeAmount=700000,
                      Bank_card_number="6587128953869784", Bank_account="UA010000006587128953869784", Inn="6587128953", FundraisingStatusID=1,
                      BirthDate = new DateTime(1988,06,09),
                      Descript_patient_and_disease="Транплантація нирки для Мілані",
                      Notate="Мілані поставили тяжкий діагноз Хронічна ниркова недостатність (ХНН V). " +
                      "Лікування дитини довготривале та дуже дороге, потрібна транплантація нирки. " +
                      "Операція та лікування відбувається в Центрі трансплантології Першого медоб'єднання Львова"},
                  new Patients(){Id = 20,
                      SurnameID=6,
                      NameID=25,
                      PatronymicID=11,
                      GenderID=1,
                      CategoryID=3, TreatmentCategoryID=2,  DiagnosisID=7,
                      CityID=4, HospitalID=2, WardID=null,
                      FeeAmount=100000,
                      Bank_card_number="7542152686425378", Bank_account="UA010000007542152686425378", Inn="7542152686", FundraisingStatusID=1,
                      BirthDate = new DateTime(1993,06,07),
                      Descript_patient_and_disease="Реабілітація піля пранення грудної порожнини для захисника Ілая",
                      Notate="Перебуваючи на позиції, Ілай отримав Проникаюче поранення грудної порожнини. " +
                      "Захиснику необхідне двготривале та коштовне лікування та відновлення. Реабілітація відбувається в КНП Харківської обласної ради " +
                      "«Обласна клінічна травматологічна лікарня»"},
                  new Patients(){Id = 21,
                      SurnameID=6,
                      NameID=26,
                      PatronymicID=14,
                      GenderID=2,
                      CategoryID=2, TreatmentCategoryID=1,  DiagnosisID=15,
                      CityID=2, HospitalID=4, WardID=null,
                      FeeAmount=1200000,
                      Bank_card_number="45698523412694527", Bank_account="UA0100000045698523412694527", Inn="45698523412", FundraisingStatusID=4,
                      BirthDate = new DateTime(2018,05,10),
                      Descript_patient_and_disease="Операція і терапія для Марини",
                      Notate="Мета: Підтримати 5-річну Марину, яка страждає на вроджену дисплазію тазостегнових суглобів. " +
                      "Для проведення операції та спеціалізованої терапії необхідно зібрати 1,200,000 грн. " +
                      "Лікування буде проходити в Чернігівській дитячій лікарні."},
                   new Patients(){Id = 22,
                      SurnameID=17,
                      NameID=11,
                      PatronymicID=11,
                      GenderID=1,
                      CategoryID=3, TreatmentCategoryID=3,  DiagnosisID=2,
                      CityID=1, HospitalID=6, WardID=null,
                      FeeAmount=100000,
                      Bank_card_number="3694562153486297", Bank_account="UA010000003694562153486297", Inn="3694562153", FundraisingStatusID=4,
                      BirthDate = new DateTime(2060,08,11),
                      Descript_patient_and_disease="Протезування для ветерана АТО Дмитра",
                      Notate="Мета: Допомогти 64-річному ветерану АТО Дмитру, який втратив ногу внаслідок бойових дій, отримати сучасний протез. " +
                      "Для цього необхідно зібрати 100,000 грн. Протезування буде проводитися в спеціалізованому центрі Центра трансплантології Першого медоб'єднання Львова"},
                   new Patients(){Id = 23,
                      SurnameID=12,
                      NameID=12,
                      PatronymicID=16,
                      GenderID=2,
                      CategoryID=3, TreatmentCategoryID=2,  DiagnosisID=16,
                      CityID=4, HospitalID=2, WardID=null,
                      FeeAmount=800000,
                      Bank_card_number="3694562153486297", Bank_account="UA010000003694562153486297", Inn="3694562153", FundraisingStatusID=1,
                      BirthDate = new DateTime(2094,06,02),
                      Descript_patient_and_disease="Реабілітація поранення для Мирослави",
                      Notate="Мета: Допомогти 30-річній Мирославі, військовій, яка отримала важке поранення спини з пошкодженням хребта внаслідок бойових дій, " +
                      "пройти повноцінну реабілітацію. " +
                      "Для цього необхідно зібрати 800,000 грн. Лікування та реабілітація проводитимуться в КНП Харківської обласної ради «Обласна клінічна травматологічна лікарня»."},
                    new Patients(){Id = 24,
                      SurnameID=9,
                      NameID=27,
                      PatronymicID=9,
                      GenderID=1,
                      CategoryID=1, TreatmentCategoryID=1,  DiagnosisID=17,
                      CityID=5, HospitalID=3, WardID=null,
                      FeeAmount=720000,
                      Bank_card_number="56982149563275483", Bank_account="UA0100000056982149563275483", Inn="56982149563", FundraisingStatusID=1,
                      BirthDate = new DateTime(2096,04,08),
                      Descript_patient_and_disease="Курс лікування для Івана",
                      Notate="Мета: Допомогти 28-річному Івану пройти курс лікування противірусними препаратами для боротьби з хронічним гепатитом С. " +
                      "Потрібно зібрати 720,000 грн. Лікування буде проводитися у БО ДОБФ «Лікарня ім. І.І. МЕЧНИКОВА»"},
                     new Patients(){Id = 25,
                      SurnameID=3,
                      NameID=21,
                      PatronymicID=3,
                      GenderID=1,
                      CategoryID=1, TreatmentCategoryID=1,  DiagnosisID=18,
                      CityID=1, HospitalID=1, WardID=7,
                      FeeAmount=200000,
                      Bank_card_number="4619534875124673", Bank_account="UA010000004619534875124673", Inn="4619534875", FundraisingStatusID=1,
                      BirthDate = new DateTime(2018,06,07),
                      Descript_patient_and_disease="Лікування онкології для Олександра",
                      Notate="Мета: Зібрати кошти на лікування 6-річного Олександра, який бореться з лейкемією. " +
                      "Необхідно зібрати 200,000 грн на проведення хіміотерапії та подальшу реабілітацію. " +
                      "Лікування проводиться в Відділенні інтенсивної хіміотерапії НДСЛ «Охматдит»"},
                     new Patients(){Id = 26,
                      SurnameID=6,
                      NameID=14,
                      PatronymicID=4,
                      GenderID=2,
                      CategoryID=1, TreatmentCategoryID=1,  DiagnosisID=19,
                      CityID=4, HospitalID=3, WardID=null,
                      FeeAmount=100000,
                      Bank_card_number="2369751243957854", Bank_account="UA010000002369751243957854", Inn="2369751243", FundraisingStatusID=1,
                      BirthDate = new DateTime(2087,03,01),
                      Descript_patient_and_disease="Реабілітація для Марії",
                      Notate="Мета: Підтримати 37-річну Марію, яка бореться з гострою лімфобластною лейкемією. " +
                      "Для проходження хіміотерапії та підтримуючої терапії необхідно зібрати 100000. Лікування буде проводитися у БО ДОБФ «Лікарня ім. І.І. МЕЧНИКОВА»"},
                     new Patients(){Id = 27,
                      SurnameID=6,
                      NameID=29,
                      PatronymicID=1,
                      GenderID=1,
                      CategoryID=1, TreatmentCategoryID=1,  DiagnosisID=20,
                      CityID=1, HospitalID=6, WardID=null,
                      FeeAmount=250000,
                      Bank_card_number="2698756412357698", Bank_account="UA010000002698756412357698", Inn="2698756412", FundraisingStatusID=1,
                      BirthDate = new DateTime(2020,04,09),
                      Descript_patient_and_disease="Лікування важких опіків для Василя",
                      Notate="Мета: Зібрати 250,000 грн для 4-річного Василя, який постраждав від пожежі. Кошти необхідні для проведення кількох етапів пластичних операцій та тривалої реабілітації. " +
                      "Лікування буде проводитися у Центр трансплантології Першого медоб'єднання Львова"},
                     new Patients(){Id = 28,
                      SurnameID=10,
                      NameID=30,
                      PatronymicID=12,
                      GenderID=2,
                      CategoryID=1, TreatmentCategoryID=2,  DiagnosisID=21,
                      CityID=7, HospitalID=4, WardID=null,
                      FeeAmount=100000,
                      Bank_card_number="5674215963548246", Bank_account="UA010000005674215963548246", Inn="5674215963", FundraisingStatusID=1,
                      BirthDate = new DateTime(2066,04,08),
                      Descript_patient_and_disease="Реабілітація після інсульту для Ольги",
                      Notate="Мета: Зібрати 100,000 грн для реабілітації 58-річної Ольги, яка перенесла важкий інсульт. Кошти підуть на курс відновлювальної терапії та спеціальні тренажери. " +
                      "Реабілітація проходитиме в Обласній клінічній лікарні відновного лікування та діагностики"}
            };
            modelBuilder.Entity<Patients>().HasData(patient);

            Benefactors[] benefactor = new Benefactors[]
            {
                  new Benefactors(){Id = 1,
                      SurnameID=15,
                      NameID=7,
                      BirthDate = new DateTime(1998,03,06),
                      ContactPhone="0958675421", Email="Benefactor1@gmail.com",
                      Login ="Benefactor1", Password="Benefactor1",
                      RoleID=4 },
                  new Benefactors(){Id = 2,
                      SurnameID=1,
                      NameID=12,
                      BirthDate = new DateTime(1993,08,08),
                      ContactPhone="0558675469", Email="Benefactor2@gmail.com",
                      Login ="Benefactor2", Password="Benefactor2",
                      RoleID=4 },
                  new Benefactors(){Id = 3,
                      SurnameID=6,
                      NameID=14,
                      BirthDate = new DateTime(1989,01,01),
                      ContactPhone="0667845123", Email="Benefactor3@gmail.com",
                      Login ="Benefactor3", Password="Benefactor3",
                      RoleID=4 },
                  new Benefactors(){Id = 4,
                      SurnameID=11,
                      NameID=12,
                      BirthDate = new DateTime(2002,04,06),
                      ContactPhone="0963584756", Email="Benefactor4@gmail.com",
                      Login ="Benefactor4", Password="Benefactor4",
                      RoleID=4 },
            };
            modelBuilder.Entity<Benefactors>().HasData(benefactor);


            Partners[] partner = new Partners[]
           {
                  new Partners(){Id = 1,
                      NamePartners="Tabletochki",
                      Linc="https://tabletochki.org/?utm_source=google.g&utm_medium=cpc&utm_campaign=18598589187&utm_term=tabletochki&utm_content=628336089002&gad_source=1&gclid=CjwKCAjw_ZC2BhAQEiwAXSgClq_iiioQDMNQ8LrMTTn4MRMp1Cw8BC4HbtP8KWXMON5MttAnlqWVFRoCoygQAvD_BwE",
                      Notate="Лікування раку складне і тривале. Та навіть під час війни «Таблеточки» залишаються поруч із сім’ями, які зіткнулись з дитячим раком, на кожному етапі. Обстеження, придбання ліків в Україні та за кордоном, психологічна та паліативна підтримка, соціальна реабілітація, проживання біля лікарні — по цю та іншу адресну допомогу можна звернутися до фонду."
                  },
                  new Partners(){Id = 2,
                      NamePartners="ZERO Prostate Cancer",
                      Linc="https://zerocancer.org/",
                      Notate="Ми разом подолаємо рак простати\r\nОтримайте доступ до життєво необхідної інформації та підтримки, зв’яжіться з іншими в спільноті хворих на рак передміхурової залози та вживайте заходів, щоб ZERO від раку простати."
                  },
                  new Partners(){Id = 3,
                      NamePartners="UNICEF",
                      Linc="https://www.unicef.org/ukraine/",
                      Notate="ЮНІСЕФ працює у 190 країнах і територіях для охоплення найуразливіших дітей та молоді, які найбільше потребують допомоги. Організація працюємо над тим, щоб зберегти їхні життя. Захистити їхні права. Уберегти їх від шкоди. Дати їм дитинство, в якому вони будуть захищеними, здоровими та освіченими. Дати їм рівні можливості реалізувати свій потенціал, щоб одного дня вони могли зробити світ кращим."
                  },
                  new Partners(){Id = 4,
                      NamePartners="Livestrong",
                      Linc="https://livestrong.org/how-we-help/livestrong-at-the-ymca/",
                      Notate="Livestrong надає підтримку для вирішення проблем, з якими щодня стикаються люди, хворі на рак. Розбираючи складні теми, надаючи покрокові вказівки та створюючи програми, які покращують якість вашого життя, незалежно від ваших щоденних завдань, Livestrong тут, щоб допомогти."
                  },
                  new Partners(){Id = 5,
                      NamePartners="Ridni",
                      Linc="https://ridni.org.ua/?gad_source=1&gclid=CjwKCAjw_ZC2BhAQEiwAXSgCls6FKpoSHuN_lOSC02vxHQ1X2xiij4U47olk0g9AqA44zJKgV5hViRoCS6QQAvD_BwE",
                      Notate="Подолання сирітства та розвиток інституту сім’ї.\r\n\r\nПрацюють заради того, щоб кожна дитина зростала у люблячій сім 'ї з духовними цінностями та мала щасливе майбутнє. Для цього організація надає дітям та дорослим психологічну, соціальну, освітню підтримку. Забезпечує консультаційний супровід усиновлювачів, батьків-вихователів дитячих будинків сімейного типу та прийомних сімей."
                  },

            };
            modelBuilder.Entity<Partners>().HasData(partner);

            PartnersRepresentatives[] partnersRepresentative = new PartnersRepresentatives[]
          {
                  new PartnersRepresentatives(){Id = 1,
                      SurnameID=6,
                      NameID=3,
                      PatronymicID=7,
                      BirthDate = new DateTime(1997,06,06),
                      ContactPhone="0668912435", Email="Partner1@gmail.com",
                      Login ="Partner1", Password="Partner1",
                      PartnerID=1,
                      RoleID=3 },
                  new PartnersRepresentatives(){Id = 2,
                      SurnameID=12,
                      NameID=8,
                      PatronymicID=10,
                      BirthDate = new DateTime(2001,07,05),
                      ContactPhone="0672536149", Email="Partner2@gmail.com",
                      Login ="Partner2", Password="Partner2",
                      PartnerID=2,
                      RoleID=3 },
                  new PartnersRepresentatives(){Id = 3,
                      SurnameID=11,
                      NameID=4,
                      PatronymicID=12,
                      BirthDate = new DateTime(1996,03,08),
                      ContactPhone="0964528753", Email="Partner3@gmail.com",
                      Login ="Partner3", Password="Partner3",
                      PartnerID=3,
                      RoleID=3 },
                  new PartnersRepresentatives(){Id = 4,
                      SurnameID=5,
                      NameID=6,
                      PatronymicID=8,
                      BirthDate = new DateTime(2002,04,06),
                      ContactPhone="0995873654", Email="Partner4@gmail.com",
                      Login ="Partner4", Password="Partner4",
                      PartnerID=4,
                      RoleID=3 },
                  new PartnersRepresentatives(){Id = 5,
                      SurnameID=1,
                      NameID=4,
                      PatronymicID=8,
                      BirthDate = new DateTime(2001,01,05),
                      ContactPhone="0975249875", Email="Partner5@gmail.com",
                      Login ="Partner5", Password="Partner5",
                      PartnerID=5,
                      RoleID=3 }
            };
            modelBuilder.Entity<PartnersRepresentatives>().HasData(partnersRepresentative);

            Events[] events = new Events[]
            {
                  new Events(){Id = 1,
                      NameEvent="Благодійний марафон",
                      EventDate = new DateTime(2024,06,06),
                      Desc="Благодійний марафон на підтримку дітей з хронічними захворюваннями" },
                  new Events(){Id = 2,
                      NameEvent="Благодійна ярмарка",
                      EventDate = new DateTime(2024,04,09),
                      Desc="Благодійна ярмарка на підтримку ветеранів" },
                  new Events(){Id = 3,
                      NameEvent="Благодійна виавка",
                      EventDate = new DateTime(2024,05,03),
                      Desc="Благодійна витавка україньких хзудожникв на підтримку онкохворих діток" },
                  new Events(){Id = 4,
                      NameEvent="Благодійна ярмарка",
                      EventDate = new DateTime(2024,07,09),
                      Desc="Благодійна ярмарка на підтримку військових, що потребують протезування" },
                  new Events(){Id = 5,
                      NameEvent="Благдійний марафон",
                      EventDate = new DateTime(2024,08,11),
                      Desc="Благдійний марафон на підтримку жінок, що боряться з ракомгрудей" },
            };
            modelBuilder.Entity<Events>().HasData(events);

            News[] news = new News[]
            {
                  new News(){Id = 1,
                      NameNewі="Як зробити свій внесок: детальний гайд по донатах через додаток",
                      Desc="Для того, щоб полегшити процес пожертвування, ми інтегрували у додаток кілька способів оплати, таких як Apple Pay, Google Pay та Приват24. " +
                      "Це дозволяє зробити донат у кілька кліків, не виходячи з додатку. У цій новині ви знайдете детальний посібник з використання цих платіжних систем, крок за кроком, " +
                      "щоб упевнитися, що ваш внесок буде зроблено швидко і безпечно. " +
                      "Ми також розповімо, як захищаються ваші персональні дані, і чому наш додаток є надійним вибором для благодійників." },
                  new News(){Id = 2,
                      NameNewі="Тиждень благодійності: акції та заходи по всій країні",
                      Desc="Наступного місяця ми організуємо Тиждень благодійності, протягом якого відбудеться серія акцій та заходів на підтримку медичних закладів по всій країні. " +
                      "У цей період ви зможете взяти участь у різноманітних ініціативах, зробити свій внесок та отримати подарунки від наших партнерів. " +
                      "У цій новині ви дізнаєтесь про програму Тижня благодійності, заходи, що будуть проводитися, і як можна долучитися до кожного з них." },
                  new News(){Id = 3,
                      NameNewі="Благодійний аукціон на підтримку лікування ветеранів",
                      Desc="Приєднуйтесь до нашого благодійного аукціону, де ви зможете придбати унікальні предмети, послуги та враження, надані відомими людьми та організаціями. " +
                      "Всі зібрані кошти підуть на лікування та реабілітацію ветеранів, які постраждали під час служби. " +
                      "У цій новині ми розповімо про лоти, які будуть представлені на аукціоні, умови участі та як ви можете долучитися до підтримки цієї важливої ініціативи." },
                  new News(){Id = 4,
                      NameNewі="Історії успіху: як ваші пожертви допомогли врятувати життя",
                      Desc="Немає нічого більш надихаючого, ніж реальні історії пацієнтів, яким вдалося отримати необхідне лікування завдяки вашій підтримці. Ми збираємо та публікуємо ці історії, щоб показати, як важливо бути небайдужим. " +
                      "У кожній історії розповідається про шлях пацієнта, від діагнозу до отримання лікування, а також про те, як зібрані кошти допомогли змінити його життя на краще. " +
                      "У цьому розділі ви знайдете найзворушливіші історії успіху, які демонструють силу співчуття та доброти." },
                  new News(){Id = 5,
                      NameNewі="Благодійний онлайн-забіг: долучайтеся з будь-якої точки світу",
                      Desc="Для тих, хто не може взяти участь у марафоні особисто, ми організували благодійний онлайн-забіг, де ви можете пройти або пробігти свою дистанцію в будь-якій точці світу. " +
                      "Всі кошти, зібрані через наш додаток під час цього заходу, підуть на підтримку лікування пацієнтів. " +
                      "У цій новині ми розкажемо, як взяти участь в онлайн-забігу, які умови та які нагороди чекають на учасників." },
                  new News(){Id = 6,
                      NameNewі="Концерт на підтримку пацієнтів: музика, що дарує надію",
                      Desc="Ми раді анонсувати благодійний концерт, усі зібрані кошти з якого підуть на підтримку пацієнтів, що потребують невідкладного лікування. У концерті візьмуть участь відомі музиканти та виконавці, які вирішили підтримати нашу ініціативу. " +
                      "Глядачі зможуть робити пожертви через наш додаток під час заходу. " +
                      "Ця новина розповідає про програму концерту, артистів, що виступатимуть, і як ваш внесок може врятувати життя." },
                  new News(){Id = 7,
                      NameNewі="Результати зборів: інформування донорів про завершення кампаній",
                      Desc="Кожен благодійник має право знати, як були використані його кошти. Ми запровадили систему інформування, яка дозволяє донору отримати повідомлення після завершення збору коштів на лікування. " +
                      "Ви отримаєте лист з подякою від пацієнта або медичного закладу, де буде зазначено, скільки коштів було зібрано та як вони були використані. " +
                      "Це додає прозорості процесу та підвищує довіру до нашого додатку. " +
                      "У цьому розділі ви дізнаєтесь, як саме працює ця система, і як вона сприяє прозорості та відповідальності." },
                  new News(){Id = 8,
                      NameNewі="Нова можливість для благодійників: отримуйте листівки-подяки від пацієнтів",
                      Desc="У відповідь на вашу щедрість ми додали нову функцію в додаток – можливість отримати персоналізовану листівку-подяку від пацієнта, якого ви підтримали. Після здійснення донату, якщо ви не виберете анонімний спосіб, ви можете обрати опцію отримати листівку на свою електронну пошту, месенджер або соціальну мережу. " +
                      "Листівка буде створена від імені пацієнта, з подякою за внесок на його ім’я. " +
                      "Ця функція створена для того, щоб підсилити взаємодію між благодійниками та пацієнтами, а також додати ще більше позитивних емоцій у процес донатів. " +
                      "У цьому розділі ми пояснимо, як працює ця опція, і як вона може бути використана." },
                  new News(){Id = 9,
                      NameNewі="Новий додаток для допомоги хворим",
                      Desc="З радістю повідомляємо про запуск нашого інноваційного додатку, призначеного для збору коштів на лікування, реабілітацію, протезування та підтримку життєдіяльності хворих. " +
                      "Цей додаток дозволяє легко та безпечно робити донати, відслідковувати хід збору коштів та отримувати інформацію про пацієнтів, які потребують допомоги. " +
                      "Завантажуйте додаток сьогодні та допоможіть тим, хто цього потребує!" },
                  new News(){Id = 10,
                      NameNewі="Благодійний марафон на підтримку хворих дітей",
                      Desc="Запрошуємо вас взяти участь у нашому благодійному марафоні, присвяченому збору коштів для лікування хворих дітей. Подія відбудеться у центральному парку міста 25 липня. " +
                      "На вас чекають цікаві конкурси, концерти та можливість особисто поспілкуватися з родинами, які потребують допомоги. " +
                      "Усі зібрані кошти будуть спрямовані на лікування та реабілітацію дітей. Долучайтесь до марафону та допоможіть дітям отримати шанс на здорове майбутнє!" },
                  new News(){Id = 11,
                      NameNewі="Нове відділення для реабілітації",
                      Desc="З гордістю повідомляємо про відкриття нового відділення для реабілітації дітей у нашій партнерській лікарні. " +
                      "Завдяки вашій підтримці та зібраним коштам, відділення обладнано найсучаснішою технікою та готове приймати маленьких пацієнтів. " +
                      "Ми вдячні всім, хто долучився до збору коштів та зробив це можливим. Разом ми можемо творити дива!" },
                  new News(){Id = 12,
                      NameNewі="Благодійний ярмарок для підтримки дітей-сиріт",
                      Desc="Запрошуємо всіх на благодійний ярмарок, який відбудеться 15 листопада на головній площі міста. " +
                      "На ярмарку будуть представлені різноманітні товари ручної роботи, смаколики та інші цікаві речі. Всі зібрані кошти будуть спрямовані на підтримку дітей-сиріт, які потребують допомоги. " +
                      "Приходьте на ярмарок, робіть покупки та допомагайте дітям отримати кращі умови для життя та розвитку." },

            };
            modelBuilder.Entity<News>().HasData(news);
            PatientsCharitableContributions[] patientsCharitableContributions = new PatientsCharitableContributions[]
             {
                  new PatientsCharitableContributions(){Id = 1, 
                      BenefactorID=1,
                      PatientID = 9,
                      Amount=75000
                      },
                  new PatientsCharitableContributions(){Id = 2,
                      BenefactorID=2,
                      PatientID = 9,
                      Amount=125000
                      },
                  new PatientsCharitableContributions(){Id = 3,
                      BenefactorID=3,
                      PatientID = 9,
                      Amount=100000
                      },
                  new PatientsCharitableContributions(){Id = 4,
                      BenefactorID=4,
                      PatientID = 9,
                      Amount=20000 
                      },
                  new PatientsCharitableContributions(){Id = 5,
                      BenefactorID=2,
                      PatientID = 9,
                      Amount=30000
                      },
                  new PatientsCharitableContributions(){Id = 6,
                      BenefactorID=3,
                      PatientID = 11,
                      Amount=50000
                      },
                  new PatientsCharitableContributions(){Id = 7,
                      BenefactorID=1,
                      PatientID = 2,
                      Amount=20000
                      },
                  new PatientsCharitableContributions(){Id = 8,
                      BenefactorID=4,
                      PatientID = 4,
                      Amount=120000
                      },
                   new PatientsCharitableContributions(){Id = 9,
                      BenefactorID=3,
                      PatientID = 4,
                      Amount=80000
                      },
                    new PatientsCharitableContributions(){Id = 10,
                      BenefactorID=1,
                      PatientID = 4,
                      Amount=50000
                      },
                     new PatientsCharitableContributions(){Id = 11,
                      BenefactorID=2,
                      PatientID = 6,
                      Amount=10000
                      },
                      new PatientsCharitableContributions(){Id = 12,
                      BenefactorID=4,
                      PatientID = 6,
                      Amount=70000
                      },
                      new PatientsCharitableContributions(){Id = 13,
                      BenefactorID=4,
                      PatientID = 21,
                      Amount=200000
                      },
                      new PatientsCharitableContributions(){Id = 14,
                      BenefactorID=2,
                      PatientID = 21,
                      Amount=300000
                      },
                      new PatientsCharitableContributions(){Id = 15,
                      BenefactorID=1,
                      PatientID = 21,
                      Amount=400000
                      },
                      new PatientsCharitableContributions(){Id = 16,
                      BenefactorID=3,
                      PatientID = 21,
                      Amount=150000
                      },
                      new PatientsCharitableContributions(){Id = 17,
                      BenefactorID=2,
                      PatientID = 21,
                      Amount=150000
                      },
                      new PatientsCharitableContributions(){Id = 18,
                      BenefactorID=3,
                      PatientID = 22,
                      Amount=60000
                      },
                      new PatientsCharitableContributions(){Id = 19,
                      BenefactorID=2,
                      PatientID = 22,
                      Amount=15000
                      },
                      new PatientsCharitableContributions(){Id = 20,
                      BenefactorID=1,
                      PatientID = 22,
                      Amount=5000
                      },
                      new PatientsCharitableContributions(){Id = 21,
                      BenefactorID=4,
                      PatientID = 22,
                      Amount=15000
                      },
                      new PatientsCharitableContributions(){Id = 22,
                      BenefactorID=1,
                      PatientID = 22,
                      Amount=5000
                      },
             };
            modelBuilder.Entity<Category>().HasData(categorys);

        }
    }
}
