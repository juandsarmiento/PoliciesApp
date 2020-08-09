using System;
using Microsoft.AspNetCore.Hosting;
using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Newtonsoft.Json;
using Microsoft.AspNetCore.TestHost;
using PoliciesWebApp.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PoliciesWebApp.DTOs;
using System.Text;
using System.Collections.Generic;
using AutoMapper;
using PoliciesWebApp.Models;
using PoliciesWebApp.Repo;
using PoliciesWebAppTests.Controllers;
using IdentityServer4.EntityFramework.Options;
using Microsoft.Extensions.Options;

namespace PoliciesWebApp.Controllers.Tests
{
    [TestClass()]
    public class PoliciesControllerTests
    {
        private TestServer _server;
        public HttpClient Client { get; private set; }
        public PoliciesControllerTests()
        {
            SetUpClient();
        }
        [TestMethod()]
        public async Task CreatePolicy_Created()
        {
            Dictionary<string, object> data = new Dictionary<string, object>()
            {
                {"name", "Test1"},
                {"desc", ""},
                {"coverage", 30 },
                {"startDate", "2020-08-16" },
                {"price", 214435 },
                {"riskId", 3 },
                {"policyCoverageTypes", new int[]{0,1} },
                {"converageTime", 4 }
            };
            var response = await Client.PostAsync("/api/policies", new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json"));
            if(response.StatusCode != System.Net.HttpStatusCode.Created)
            {
                Assert.Fail($"Should be {System.Net.HttpStatusCode.Created}");
            }
        }
        [TestMethod()]
        public async Task CreatePolicy_Error()
        {
            Dictionary<string, object> data = new Dictionary<string, object>()
            {
                {"name", "Test2"},
                {"desc", ""},
                {"coverage", 70 },
                {"startDate", "2020-08-16" },
                {"price", 214435 },
                {"riskId", 3 },
                {"policyCoverageTypes", new int[]{0,1} },
                {"converageTime", 4 }
            };

            var response = await Client.PostAsync("/api/policies", new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json"));
            if (response.StatusCode != System.Net.HttpStatusCode.BadRequest)
            {
                Assert.Fail($"Should be {System.Net.HttpStatusCode.BadRequest}");
            }
        }


        private void SetUpClient()
        {
            IOptions<OperationalStoreOptions> options = Options.Create<OperationalStoreOptions>(new OperationalStoreOptions());

            var builder = new WebHostBuilder()
                    .UseStartup<PoliciesWebApp.Startup>()
                    .ConfigureServices(services =>
                    {
                        var context = new PoliciesDbContext(
                            new DbContextOptionsBuilder<PoliciesDbContext>()
                            .UseSqlite("DataSource=:memory:")
                            .EnableSensitiveDataLogging()
                            .Options,
                            options);

                        services.RemoveAll(typeof(PoliciesDbContext));
                        services.AddSingleton(context);
                        context.Database.OpenConnection();
                        context.Database.EnsureCreated();
                        context.SaveChanges();
                        foreach (var entity in context.ChangeTracker.Entries().ToList())
                        {
                            entity.State = EntityState.Detached;
                        }

                    });

            _server = new TestServer(builder);
            Client = _server.CreateClient();
        }
    }

    
}