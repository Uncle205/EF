namespace OnlineStoreEf
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class OnlineStore : DbContext
    {
        // Контекст настроен для использования строки подключения "OnlineStore" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "OnlineStoreEf.OnlineStore" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "OnlineStore" 
        // в файле конфигурации приложения.
        public OnlineStore()
            : base("name=OnlineStore")
        {
        }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Good> Goods { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Category> Categorys { get; set; }
 
        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}
