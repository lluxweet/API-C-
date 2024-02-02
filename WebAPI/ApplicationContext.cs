using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAPI.Models;

namespace WebAPI
{
    public class ApplicationContext : DbContext
    {
        private const string Password = "1234567890";
        private const string DataBaseName = "diplombase";
        private const int Port = 3306;
        private const string Server = "localhost";
        private const string UserName = "root";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql($"Server={Server};database={DataBaseName};Port={Port};User id={UserName};Password={Password}",new MySqlServerVersion(new Version(8,0,35)));

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserEntity>().HasOne(x => x.Role).WithMany().HasForeignKey(x => x.idRole).IsRequired();
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<UserEntity> user { get; set; }
        public DbSet<RoleEntity> role { get; set; }
        public DbSet<CategoriaEntity> categoria { get; set; }
        public DbSet<ClientEntity> client {  get; set; }       
        public DbSet<OrganizaciaEntity> organizacia { get; set; }     
        public DbSet<PredprinimatelEntity> predprinimatel { get; set; }
        public DbSet<ProductEntity> product { get; set; }       
        public DbSet<RazreshenieEntity> razreshenie { get; set; }
        public DbSet<StatusEntity> status { get; set; }
        public DbSet<StatusoplataEntity> statusoplata { get; set; }
        public DbSet<TypeoplataEntity> typeoplata { get; set; }
        public DbSet<ProdajaEntity> prodaja { get; set; }
      
        
    }
}
