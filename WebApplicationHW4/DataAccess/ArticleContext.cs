namespace WebApplicationHW4.DataAccess
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ArticleContext : DbContext
    {
        // Контекст настроен для использования строки подключения "ArticleContext" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "WebApplicationHW4.DataAccess.ArticleContext" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "ArticleContext" 
        // в файле конфигурации приложения.
        public ArticleContext()
            : base("name=ArticleContext")
        {
            //Database.SetInitializer(new NewsInitializer());
        }

        

         public  DbSet<Article> Articles { get; set; }
    }

    
}