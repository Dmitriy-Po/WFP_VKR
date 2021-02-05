namespace TestCodeFirst
{
    using DataContext;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class CodeFirstContext : DbContext
    {
        // Контекст настроен для использования строки подключения "CodeF" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "TestCodeFirst.CodeF" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "CodeF" 
        // в файле конфигурации приложения.
        public CodeFirstContext()
            : base(/*"name=CodeFirstContext"*/"CodeFirstCOntextSQLExpress")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<ПланПроизводстваПоМесяцам>()
                .HasMany(h => h.ПланПроизводстваПоДням)
                .WithRequired(w => w.ПланПроизводстваПоМесяцам)
                .WillCascadeOnDelete(true);

            modelBuilder
                .Entity<ПланПроизводстваПоДням>()
                .HasMany(h => h.ДневнаяНормаНаУстановку)
                .WithRequired(w => w.ПланПроизводстваПоДням)
                .WillCascadeOnDelete(true);

            //base.OnModelCreating(modelBuilder);
            //modelBuilder
            //    .Entity<Устройство>()
            //    .HasRequired(e => e.ВыбранноеСостояниеУстройства)
            //    .WithRequiredDependent(e => e.УстройствоFK);

            //modelBuilder
            //    .Entity<ВыбранноеСостояниеУстройства>()
            //    .HasRequired(e => e.УстройствоFK)
            //    .WithRequiredPrincipal(e => e.ВыбранноеСостояниеУстройства);

            //modelBuilder
            //    .Entity<ВыбранноеСостояниеУстройства>()
            //    .HasRequired(e => e.ПланНормативныйТехнологический)
            //    .WithRequiredPrincipal(e => e.ВыбранноеСостояниеУстройства);

            //modelBuilder
            //    .Entity<ПланНормативныйТехнологический>()
            //    .HasRequired(e => e.ВыбранноеСостояниеУстройства)
            //    .WithRequiredDependent(e => e.ПланНормативныйТехнологический);
        }

        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        //public virtual DbSet<Агрегат> АгрегатSet { get; set; }
        //public virtual DbSet<ПланНормативныйТехнологический> ПланНормативныйТехнологическийSet { get; set; }
        //public virtual DbSet<ВыбранноеСостояниеУстройства> ВыбранноеСостояниеУстройстваSet { get; set; }
        public virtual DbSet<Справочник> СправочникSet { get; set; }
        public virtual DbSet<Установка> УстановкаSet { get; set; }
        public virtual DbSet<СиловойАгрегатВУстановке> СиловойАгрегатВУстройствеSet { get; set; }
        public virtual DbSet<ФактическоеПотребление> ФактическоеПотреблениеSet { get; set; }
        public virtual DbSet<РежимРаботыАгрегата> РежимРаботыАгрегатаSet { get; set; }

        public virtual DbSet<ПланПроизводстваПоМесяцам> ПланПроизводстваПоМесяцамSet { get; set; }
        public virtual DbSet<СправочникРесурсов> СправочникРесурсовSet { get; set; }
        public virtual DbSet<ПланПроизводстваПоДням> ПланПроизводстваПоДнямSet { get; set; }
        public virtual DbSet<ДневнаяНормаНаУстановку> ДневнаяНормаНаУстановкуSet { get; set; }
        public virtual DbSet<УстановкаРежимРесурс> УстройствоРежимРесурсSet { get; set; }
        public virtual DbSet<РежимРаботыУстановки> РежимРаботыУстановкиSet { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}