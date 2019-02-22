namespace EfRepo.Context
{
    using EfRepo.Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class HiperContextCF : DbContext
    {
        // Your context has been configured to use a 'HiperContextCF' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'EfRepo.Context.HiperContextCF' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'HiperContextCF' 
        // connection string in the application configuration file.

        public HiperContextCF()
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nameOrConnectionString">"name=HiperContextCF"</param>
        public HiperContextCF(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {
            Database.CreateIfNotExists();
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

         //public virtual DbSet<Dms> Dms{ get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}