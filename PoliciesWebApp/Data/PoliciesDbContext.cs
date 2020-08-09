using PoliciesWebApp.Models;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace PoliciesWebApp.Data
{
    public class PoliciesDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public PoliciesDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {

        }

        public DbSet<Policy> Policies { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<CoverageType> CoverageType { get; set; }
        public DbSet<RiskType> Risk { get; set; }
        public DbSet<PolicyClient> PolicyClient { get; set; }
        public DbSet<PolicyCoverageType> PolicyCoverageType { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Policy>()
                        .Property(i => i.Price)
                        .HasColumnType("Money");

            modelBuilder.Entity<Policy>()
                .Property("Id")
                .UseIdentityColumn();

            modelBuilder.Entity<PolicyClient>()
                .HasOne(p => p.Policy)
                .WithMany(p => p.PolicyClients)
                .HasForeignKey(p => p.PolicyId);

            modelBuilder.Entity<PolicyClient>()
                .HasOne(p => p.Client)
                .WithMany(p => p.PolicyClients)
                .HasForeignKey(p => p.ClientId);

            modelBuilder.Entity<PolicyCoverageType>()
                .HasOne(p => p.CoverageType)
                .WithMany(p => p.PolicyCoverageTypes)
                .HasForeignKey(p => p.CoverageTypeId);

            modelBuilder.Entity<PolicyCoverageType>()
                .HasOne(p => p.Policy)
                .WithMany(p => p.PolicyCoverageTypes)
                .HasForeignKey(p => p.PolicyId);

            //Seeding
            Seeding seedData = new Seeding();
            seedData.GetRandomData(out RiskType[] riskType, out CoverageType[] coverageTypes, out Client[] clients, 
                out Policy[] policies, out PolicyCoverageType[] policyCoverageTypes, out PolicyClient[] policyClients);

            modelBuilder.Entity<RiskType>().HasData(riskType);
            modelBuilder.Entity<CoverageType>().HasData(coverageTypes);
            modelBuilder.Entity<Client>().HasData(clients);
            modelBuilder.Entity<Policy>().HasData(policies);
            modelBuilder.Entity<PolicyCoverageType>().HasData(policyCoverageTypes);
            modelBuilder.Entity<PolicyClient>().HasData(policyClients);
        }
    }
}
